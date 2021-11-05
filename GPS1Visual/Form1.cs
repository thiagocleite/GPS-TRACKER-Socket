using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GPS1Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            Thread thrServidor = new Thread(new ThreadStart(Servidor));
            thrServidor.Start();

            CheckForIllegalCrossThreadCalls = false;
        }

        #region Variaveis

        private int Alarm;
        private TcpClient ConexaoCliente;
        private int id;
        private static int ContaCliente;
        private bool Retorno = false;
        private string GPSId = "";
        private char[] separador = { '<', '>' };
        private string[] guardaID;
        private bool add = true;
        public List<string> rgpsid = new List<string>();
        public List<string> pnumero = new List<string>();
        public List<string> nome = new List<string>();
        public string resultadoPnumero;
        public string resultadoNome;

        #endregion

        #region Inicia Socket

        public void Servidor()
        {
            populaList();
            int porta;
            porta = Convert.ToInt32(textBoxPorta.Text);
            textBoxPorta.Enabled = false;
            buttonIniciar.Enabled = false;
            TcpListener ConexaoServidor = new TcpListener(IPAddress.Any, porta);
            try
            {

                ConexaoServidor.Start();
                textBoxMostra.Text += String.Format("Servidor executando na porta: {0}  \r\n", porta);
                //para todo o sempre, aceitar novos clientes
                while (true)
                {
                    TcpClient ConexaoCliente = ConexaoServidor.AcceptTcpClient();
                    Cliente(ConexaoCliente);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                if (ConexaoServidor != null)
                {
                    ConexaoServidor.Stop();
                }
            }
        }


        public void Cliente(TcpClient conexao)
        {
            ConexaoCliente = conexao;
            id = ContaCliente++;
            //AtendePedido();
            //A Cada cliente Corresponde  um novo Thread
            Thread thrCliente = new Thread(new ThreadStart(this.AtendePedido));

            thrCliente.Start();
        }

        //atendimento de um pedido cliente  / thread desse cliente
        private void AtendePedido()
        {
            NetworkStream streamConexao = ConexaoCliente.GetStream();
            try
            {

                textBoxMostra.Text += String.Format("Conectado! GPS : {0} \r\n", id);
                int i;
                string data;
                Byte[] bytes = new Byte[256];
                while ((i = streamConexao.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    guardaID = data.Split(separador);
                    if (int.Parse(guardaID.Length.ToString()) >= 2) { GPSId = guardaID[1]; } else { GPSId = data; add = false; }
                    if (!comboBoxID.Items.Contains(GPSId) && add) { comboBoxID.Items.Add(GPSId); listBoxGPS.Items.Add(GPSId); textBoxGPSNum.Text = comboBoxID.Items.Count.ToString(); }
                    add = true;
                    if (Retorno && comboBoxID.SelectedItem.ToString() == GPSId)
                    {
                        byte[] retorno = System.Text.Encoding.ASCII.GetBytes(textBoxRetorno.Text);
                        streamConexao.Write(retorno, 0, retorno.Length);
                        textBoxMostra.Text += String.Format("Enviado para : {0} : {1} >> {2} \r\n", GPSId, DateTime.Now, textBoxRetorno.Text);
                        Retorno = false;
                    }
                    textBoxMostra.Text += String.Format(" {0} : {1} << {2} \r\n", GPSId, DateTime.Now, data);

                    textBoxMostra.Focus();
                    textBoxMostra.SelectionStart = textBoxMostra.TextLength;
                    textBoxMostra.ScrollToCaret();

                    string dir = @"C:\inetpub\wwwroot\fastlockServer\";

                    //Gera LOG
                    GeraKML(dir, data, GPSId);
                }
            }
            catch (Exception)
            {

                //textBoxMostra.Text = String.Format("Problema com cliente: {0} / {1}", ContaCliente, e);
            }
            finally
            {
                if (ConexaoCliente != null)
                {
                    ConexaoCliente.Close();
                    textBoxMostra.Text += String.Format("Desconectado! Cliente \r\n");
                    textBoxGPSNum.Text = "0";
                    listBoxGPS.Items.Clear();
                    comboBoxID.Items.Clear();
                }
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            Retorno = true;
        }
        #endregion

        #region GeraKML
        public void GeraKML(string dir, string data, string GPSId)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.master);
            try
            {
                for (int i = 0; i < rgpsid.Count; i++)
                {
                    if(rgpsid[i]==GPSId)
                    {
                        resultadoNome = nome[i];
                        resultadoPnumero = pnumero[i];
                        break;
                    }
                }

                StreamWriter v = new StreamWriter(dir + "logs\\" + resultadoPnumero + " " + DateTime.Now.ToString("dd MM yyyy") + ".txt", true, Encoding.ASCII);
                v.Write(DateTime.Now.ToString() + " GPS " + GPSId.ToString() + " " + data + "\r\n");
                v.Close();

                string d;
                string M;
                int conv;
                string incrementaZero;
                string lat = null;
                string longi = null;
                string str = null;
                string[] strArr = null;
                int count = 0;
                str = data;
                char[] splitchar = { ',', '>', '<', ';' };
                strArr = str.Split(splitchar);
                for (count = 0; count <= strArr.Length - 1; count++)
                {
                    switch (count)
                    {
                        case 3:
                            d = strArr[count].Substring(0, 3);
                            M = strArr[count].Substring(3, 7).Replace(".", "");
                            conv = int.Parse(M) / 60;
                            incrementaZero = conv.ToString();
                            while (incrementaZero.Length < 4)
                            {
                                incrementaZero = "0" + incrementaZero;
                            }
                            longi = d + "." + incrementaZero;
                            break;
                        case 4:
                            d = strArr[count].Substring(0, 4);
                            M = strArr[count].Substring(4, 7).Replace(".", "");
                            conv = int.Parse(M) / 60;
                            incrementaZero = conv.ToString();
                            while (incrementaZero.Length < 4)
                            {
                                incrementaZero = "0" + incrementaZero;
                            }
                            lat = d + "." + incrementaZero;
                            break;
                    }
                }
                string entrada;
                string saida;
                string img;
                switch (strArr[10])
                {
                    default:
                        entrada = "Veiculo ligado!";
                        img = "car-icon-on";
                        Alarm = 0;
                        break;
                    case "00":
                        entrada = "Veiculo desligado!";
                        img = "car-icon-off";
                        Alarm = 0;
                        break;
                    case "01":
                        entrada = "Veiculo ligado!";
                        img = "car-icon-on";
                        Alarm = 0;
                        break;
                    case "02":
                        Alarm++;
                        entrada = "Pânico apertado!";
                        img = "car-icon-war";
                        if (Alarm == 1)
                        {
                            Alarme al = new Alarme("Pânico pressionado no carro " +resultadoPnumero + " GPS " + strArr[1]);
                            al.ShowDialog();
                        }
                        Alarm++;
                        StreamWriter p = new StreamWriter(@"C:\users\Administrador\Desktop\Panico " + resultadoPnumero + ".txt", false, Encoding.Default);
                        p.WriteLine("Botão de pânico pressionado no carro! {0} cujo GPS é {1} !", resultadoPnumero, strArr[1]);
                        p.Close();
                        p.Dispose();
                        break;
                    case "03":
                        Alarm++;
                        entrada = "Pânico apertado! E ignição ligada!";
                        img = "car-icon-war-go";
                        if (Alarm == 1)
                        {
                            Alarme al2 = new Alarme("Pânico pressionado no carro " + resultadoPnumero + " GPS " + strArr[1] + ".\n E a ignição ainda está ligada!");
                            al2.ShowDialog();
                        }
                        Alarm++;
                        StreamWriter p2 = new StreamWriter(@"C:\users\Administrador\Desktop\Panico " + resultadoPnumero + ".txt", false, Encoding.Default);
                        p2.WriteLine("Botão de pânico pressionado no carro! {0} cujo GPS é {1} ! . O carro esta com a ignição ligada!", resultadoPnumero, strArr[1]);
                        p2.Close();
                        p2.Dispose();
                        break;
                }
                switch (strArr[11])
                {
                    default:
                        saida = "Veiculo";
                        break;
                    case "00":
                        saida = "Veiculo desbloqueado!";
                        break;
                    case "01":
                        saida = "Veiculo bloqueado!";
                        img = "car-icon-war";
                        break;
                    case "02":
                        saida = "Sirene acionada!";
                        img = "car-icon-war-go";
                        break;
                    case "03":
                        saida = "Veiculo bloqueado e sirene ativada!";
                        img = "car-icon-block";
                        break;
                }

                StreamWriter k = new StreamWriter(dir + "KML\\" + resultadoPnumero + ".kml", false, Encoding.ASCII);

                k.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                k.WriteLine("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
                k.WriteLine("<Document>");
                k.WriteLine("<name>{0}</name>", resultadoPnumero);
                k.WriteLine("<description>{0}</description>", resultadoNome);

                k.WriteLine("<Style id=\"normalPlacemark\">");
                k.WriteLine("<IconStyle>");
                k.WriteLine("<scale>2</scale>");
                k.WriteLine("<Icon>");
                k.WriteLine("<href>http://187.75.187.245/fastlockServer/eventos/{0}.png</href>", img);
                k.WriteLine("</Icon>");
                k.WriteLine("</IconStyle>");
                k.WriteLine("</Style>");
                k.WriteLine("<Style id=\"highlightPlacemark\">");
                k.WriteLine("<IconStyle>");
                k.WriteLine("<scale>3</scale>");
                k.WriteLine("<Icon>");
                k.WriteLine("<href>http://187.75.187.245/fastlockServer/eventos/{0}.png</href>", img);
                k.WriteLine("</Icon>");
                k.WriteLine("</IconStyle>");
                k.WriteLine("</Style>");


                k.WriteLine("<StyleMap id=\"exampleStyleMap\">");
                k.WriteLine("<Pair>");
                k.WriteLine("<key>normal</key>");
                k.WriteLine("<styleUrl>#normalPlacemark</styleUrl>");
                k.WriteLine("</Pair>");
                k.WriteLine("<Pair>");
                k.WriteLine("<key>highlight</key>");
                k.WriteLine("<styleUrl>#highlightPlacemark</styleUrl>");
                k.WriteLine("</Pair>");
                k.WriteLine("</StyleMap>");

                k.WriteLine("<Camera>");
                k.WriteLine("<longitude>{0}</longitude>", lat);
                k.WriteLine("<latitude>{0}</latitude>", longi);
                k.WriteLine("<altitude>500</altitude>");
                k.WriteLine("<heading>0</heading>");
                k.WriteLine("<tilt>0</tilt>");
                k.WriteLine("</Camera>");

                k.WriteLine("<Placemark>");
                k.WriteLine("<name>{0}, {5} , {1}KM , {2} Satelites, {3} , {4}</name>", resultadoPnumero, strArr[6], strArr[8], entrada, saida, DateTime.Now);
                k.WriteLine("<styleUrl>#exampleStyleMap</styleUrl>");
                k.WriteLine("<Point>");
                k.WriteLine("<coordinates>{0},{1},0</coordinates>", lat, longi);
                k.WriteLine("</Point>");
                k.WriteLine("</Placemark>");

                k.WriteLine("</Document>");
                k.WriteLine("</kml>");
                k.Close();

                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into gps(comunicacao,gpsid,data,latitude,longitude,altura,velocidade,grausdirecao,satelites,firme,entrada,saida)values(@comunicacao,@gpsid,@data,@latitude,@longitude,@altura,@velocidade,@grausdirecao,@satelites,@firme,@entrada,@saida)";
                cmd.Parameters.AddWithValue("@comunicacao", strArr[0]);
                cmd.Parameters.AddWithValue("@gpsid", strArr[1]);
                cmd.Parameters.AddWithValue("@data", DateTime.Now);
                cmd.Parameters.AddWithValue("@latitude", lat);
                cmd.Parameters.AddWithValue("@longitude", longi);
                cmd.Parameters.AddWithValue("@altura", strArr[5]);
                cmd.Parameters.AddWithValue("@velocidade", strArr[6]);
                cmd.Parameters.AddWithValue("@grausdirecao", strArr[7]);
                cmd.Parameters.AddWithValue("@satelites", strArr[8]);
                cmd.Parameters.AddWithValue("@firme", strArr[9]);
                cmd.Parameters.AddWithValue("@entrada", strArr[10]);
                cmd.Parameters.AddWithValue("@saida", strArr[11]);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception erro)
            {
                StreamWriter str = new StreamWriter(@"C:\inetpub\wwwroot\erro.txt", true, Encoding.Default);
                str.WriteLine(erro);
                str.WriteLine("----------------");
                str.Close();
            }

        }

        #endregion

        public void populaList()
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select nome,pnumero,rgpsid from clientes";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nome.Add(dr[0].ToString());
                    pnumero.Add(dr[1].ToString());
                    rgpsid.Add(dr[2].ToString());
                }
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Você está tentando fechar o programa, gostaria de salvar os dados enviados do dia?", "GPS TRACKER", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Cancel:
                    if (e != null)
                        e.Cancel = true;
                    break;
                case DialogResult.No:
                    Process process = Process.GetCurrentProcess();
                    process.Kill();
                    break;
                case DialogResult.Yes:
                    SalvarDadosEnviados();
                    Process process1 = Process.GetCurrentProcess();
                    process1.Kill();
                    break;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_FormClosing(null, null);
        }

        private void listBoxGPS_DoubleClick(object sender, EventArgs e)
        {
            MySqlConnection conexaoGmap = new MySqlConnection(Properties.Settings.Default.fastlock);
            try
            {
                conexaoGmap.Open();
                MySqlCommand cmdGmap = new MySqlCommand();
                cmdGmap.Connection = conexaoGmap;
                cmdGmap.CommandText = "select * from gps where gpsid=@id order by id DESC";
                cmdGmap.Parameters.AddWithValue("@id", listBoxGPS.SelectedItem);
                MySqlDataReader drGmap = cmdGmap.ExecuteReader();
                drGmap.Read();
                string url = "http://www.google.com.br/maps?q=" + drGmap["longitude"] + "," + drGmap["latitude"];
                Process.Start(url); 
                //FormMapa mapa = new FormMapa(@"http://www.google.com.br/maps?q=" + drGmap["latitude"] + "," + drGmap["longitude"]);
                //mapa.ShowDialog();
                conexaoGmap.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text == "") { listBoxAutoComplete.Visible = false; } else { listBoxAutoComplete.Visible = true; }
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.master);
            try
            {
                con.Open();
                string sql = "select pnumero from clientes where pnumero like \"%" + textBoxPesquisa.Text + "%\"";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                listBoxAutoComplete.DisplayMember = "pnumero";
                listBoxAutoComplete.DataSource = dt;

            }
            catch (MySqlException erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void listBoxAutoComplete_DoubleClick(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = listBoxAutoComplete.GetItemText(listBoxAutoComplete.SelectedItem);
            listBoxAutoComplete.Visible = false;
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro cad = new FormCadastro();
            cad.ShowDialog();
        }

        private void buttonBuscarPlaca_Click(object sender, EventArgs e)
        {
            FormPesquisaAltera fpa = new FormPesquisaAltera(textBoxPesquisa.Text);
            fpa.ShowDialog();
        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaAltera PA = new FormPesquisaAltera(null);
            PA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void SalvarDadosEnviados()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Arquivo de texto(*.txt) | *.txt";
            sf.Title = "GPS TRACKER";
            sf.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sf.FileName, textBoxMostra.Text);
            }
        }

        private void buttonClearDados_Click(object sender, EventArgs e)
        {
            textBoxMostra.Clear();
        }
    }
}