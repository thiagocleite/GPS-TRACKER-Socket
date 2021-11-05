using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GPS1Visual
{
    public partial class FormPesquisaAltera : Form
    {
        GeraNetworkLink nl = new GeraNetworkLink();
        public FormPesquisaAltera(string pesquisa)
        {
            InitializeComponent();
            Init(pesquisa,"pnumero");
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Placa");
        }
        private string vAnterior;
        private string sAnterior;
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNome.ReadOnly = false;
            textBoxEndereco.ReadOnly = false;
            textBoxNumero.ReadOnly = false;
            textBoxBairro.ReadOnly = false;
            textBoxCEP.ReadOnly = false;
            textBoxCPFCNPJ.ReadOnly = false;
            textBoxRG.ReadOnly = false;
            textBoxTelefones.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBox1Responsavel.ReadOnly = false;
            textBox1Endereco.ReadOnly = false;
            textBox1Numero.ReadOnly = false;
            textBox1CEP.ReadOnly = false;
            textBox1Bairro.ReadOnly = false;
            textBox1Telefones.ReadOnly = false;
            textBox1Email.ReadOnly = false;
            textBox2Responsavel.ReadOnly = false;
            textBox2Endereco.ReadOnly = false;
            textBox2Numero.ReadOnly = false;
            textBox2CEP.ReadOnly = false;
            textBox2Bairro.ReadOnly = false;
            textBox2Telefones.ReadOnly = false;
            textBox2Email.ReadOnly = false;
            textBoxPNumero.ReadOnly = false;
            textBoxPModelo.ReadOnly = false;
            textBoxPMarca.ReadOnly = false;
            textBoxPCor.ReadOnly = false;
            textBoxRNumero.ReadOnly = false;
            textBoxRModelo.ReadOnly = false;
            textBoxRChip.ReadOnly = false;
            textBoxRTipo.ReadOnly = false;
            textBoxGPSID.ReadOnly = false;
            textBoxLogin.ReadOnly = false;
            textBoxSenha.ReadOnly = false;
            textBoxSenhaVerbal.ReadOnly = false;
            textBoxContraSenha.ReadOnly = false;
            textBoxObs.ReadOnly = false;
            button1.Enabled = true;
            vAnterior = textBoxGPSID.Text;
            sAnterior = textBoxSenha.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                if (sAnterior == textBoxSenha.Text)
                    cmd.CommandText = "update clientes set nome=@nome,endereco=@endereco,numero=@numero,bairro=@bairro,cep=@cep,cpfcnpj=@cpfcnpj,rg=@rg,telefones=@telefones,email=@email,1responsavel=@1responsavel,1endereco=@1endereco,1bairro=@1bairro,1numero=@1numero,1cep=@1cep,1telefones=@1telefones,1email=@1email,2responsavel=@2responsavel,2endereco=@2endereco,2bairro=@2bairro,2numero=@2numero,2cep=@2cep,2telefones=@2telefones,2email=@2email,senhaverbal=@senhaverbal,csenhaverbal=@csenhaverbal,pnumero=@pnumero,pmodelo=@pmodelo,pmarca=@pmarca,pcor=@pcor,rmodelo=@rmodelo,rchip=@rchip,rnumero=@rnumero,rtipo=@rtipo,rgpsid=@rgpsid,login=@login,senha=@senha,obs=@obs where idclientes='" + textBoxIDCliente.Text + "'";
                else
                    cmd.CommandText = "update clientes set nome=@nome,endereco=@endereco,numero=@numero,bairro=@bairro,cep=@cep,cpfcnpj=@cpfcnpj,rg=@rg,telefones=@telefones,email=@email,1responsavel=@1responsavel,1endereco=@1endereco,1bairro=@1bairro,1numero=@1numero,1cep=@1cep,1telefones=@1telefones,1email=@1email,2responsavel=@2responsavel,2endereco=@2endereco,2bairro=@2bairro,2numero=@2numero,2cep=@2cep,2telefones=@2telefones,2email=@2email,senhaverbal=@senhaverbal,csenhaverbal=@csenhaverbal,pnumero=@pnumero,pmodelo=@pmodelo,pmarca=@pmarca,pcor=@pcor,rmodelo=@rmodelo,rchip=@rchip,rnumero=@rnumero,rtipo=@rtipo,rgpsid=@rgpsid,login=@login,senha=MD5(@senha),obs=@obs where idclientes='" + textBoxIDCliente.Text + "'";
                cmd.Parameters.AddWithValue("@nome", textBoxNome.Text.Trim());
                cmd.Parameters.AddWithValue("@endereco", textBoxEndereco.Text.Trim());
                cmd.Parameters.AddWithValue("@numero", textBoxNumero.Text.Trim());
                cmd.Parameters.AddWithValue("@bairro", textBoxBairro.Text.Trim());
                cmd.Parameters.AddWithValue("@cep", textBoxCEP.Text.Trim());
                cmd.Parameters.AddWithValue("@cpfcnpj", textBoxCPFCNPJ.Text.Trim());
                cmd.Parameters.AddWithValue("@rg", textBoxRG.Text.Trim());
                cmd.Parameters.AddWithValue("@telefones", textBoxTelefones.Text.Trim());
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@1responsavel", textBox1Responsavel.Text.Trim());
                cmd.Parameters.AddWithValue("@1endereco", textBox1Endereco.Text.Trim());
                cmd.Parameters.AddWithValue("@1bairro", textBox1Bairro.Text.Trim());
                cmd.Parameters.AddWithValue("@1numero", textBox1Numero.Text.Trim());
                cmd.Parameters.AddWithValue("@1cep", textBox1CEP.Text.Trim());
                cmd.Parameters.AddWithValue("@1telefones", textBox1Telefones.Text.Trim());
                cmd.Parameters.AddWithValue("@1email", textBox1Email.Text.Trim());
                cmd.Parameters.AddWithValue("@2responsavel", textBox2Responsavel.Text.Trim());
                cmd.Parameters.AddWithValue("@2endereco", textBox2Endereco.Text.Trim());
                cmd.Parameters.AddWithValue("@2bairro", textBox2Bairro.Text.Trim());
                cmd.Parameters.AddWithValue("@2numero", textBox2Numero.Text.Trim());
                cmd.Parameters.AddWithValue("@2cep", textBox2CEP.Text.Trim());
                cmd.Parameters.AddWithValue("@2telefones", textBox2Telefones.Text.Trim());
                cmd.Parameters.AddWithValue("@2email", textBox2Email.Text.Trim());
                cmd.Parameters.AddWithValue("@senhaverbal", textBoxSenhaVerbal.Text.Trim());
                cmd.Parameters.AddWithValue("@csenhaverbal", textBoxContraSenha.Text.Trim());
                cmd.Parameters.AddWithValue("@pnumero", textBoxPNumero.Text.Trim());
                cmd.Parameters.AddWithValue("@pmodelo", textBoxPModelo.Text.Trim());
                cmd.Parameters.AddWithValue("@pmarca", textBoxPMarca.Text.Trim());
                cmd.Parameters.AddWithValue("@pcor", textBoxPCor.Text.Trim());
                cmd.Parameters.AddWithValue("@rmodelo", textBoxRModelo.Text.Trim());
                cmd.Parameters.AddWithValue("@rchip", textBoxRChip.Text.Trim());
                cmd.Parameters.AddWithValue("@rnumero", textBoxRNumero.Text.Trim());
                cmd.Parameters.AddWithValue("@rtipo", textBoxRTipo.Text.Trim());
                cmd.Parameters.AddWithValue("@rgpsid", textBoxGPSID.Text.Trim());
                cmd.Parameters.AddWithValue("@login", textBoxLogin.Text.Trim());
                cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text.Trim());
                cmd.Parameters.AddWithValue("@obs", textBoxObs.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();

                if (vAnterior != textBoxGPSID.Text)
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update gps set gpsid=@gpsid where gpsid=@antigo";
                    cmd.Parameters.AddWithValue("@gpsid", textBoxGPSID.Text.Trim());
                    cmd.Parameters.AddWithValue("@antigo",vAnterior);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Alteração efetuada com sucesso!");
                nl.GeraKmlNetworkLink();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o KML verifica a .DLL GeraKmlNetworkLink");
            }

        }
        public void Init(string pesquisa,string campo)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);            
            try
            {
                con.Open();
                string sql = "select * from clientes where "+campo+"=\"" + pesquisa + "\"";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBoxIDCliente.Text = dr["idclientes"].ToString();
                textBoxNome.Text = dr["nome"].ToString();
                textBoxEndereco.Text = dr["endereco"].ToString();
                textBoxNumero.Text = dr["numero"].ToString();
                textBoxBairro.Text = dr["bairro"].ToString();
                textBoxCEP.Text = dr["cep"].ToString();
                textBoxCPFCNPJ.Text = dr["cpfcnpj"].ToString();
                textBoxRG.Text = dr["rg"].ToString();
                textBoxTelefones.Text = dr["telefones"].ToString();
                textBoxEmail.Text = dr["email"].ToString();
                textBox1Responsavel.Text = dr["1responsavel"].ToString();
                textBox1Endereco.Text = dr["1endereco"].ToString();
                textBox1Bairro.Text = dr["1bairro"].ToString();
                textBox1Numero.Text = dr["1numero"].ToString();
                textBox1CEP.Text = dr["1cep"].ToString();
                textBox1Telefones.Text = dr["1telefones"].ToString();
                textBox1Email.Text = dr["1email"].ToString();
                textBox2Responsavel.Text = dr["2responsavel"].ToString();
                textBox2Endereco.Text = dr["2endereco"].ToString();
                textBox2Bairro.Text = dr["2bairro"].ToString();
                textBox2Numero.Text = dr["2numero"].ToString();
                textBox2CEP.Text = dr["2cep"].ToString();
                textBox2Telefones.Text = dr["2telefones"].ToString();
                textBox2Email.Text = dr["2email"].ToString();
                textBoxSenhaVerbal.Text = dr["senhaverbal"].ToString();
                textBoxContraSenha.Text = dr["csenhaverbal"].ToString();
                textBoxPNumero.Text = dr["pnumero"].ToString();
                textBoxPModelo.Text = dr["pmodelo"].ToString();
                textBoxPMarca.Text = dr["pmarca"].ToString();
                textBoxPCor.Text = dr["pcor"].ToString();
                textBoxRModelo.Text = dr["rmodelo"].ToString();
                textBoxRNumero.Text = dr["rnumero"].ToString();
                textBoxRChip.Text = dr["rchip"].ToString();
                textBoxRTipo.Text = dr["rtipo"].ToString();
                textBoxGPSID.Text = dr["rgpsid"].ToString();
                textBoxLogin.Text = dr["login"].ToString();
                textBoxSenha.Text = dr["senha"].ToString();
                textBoxObs.Text = dr["obs"].ToString();

            }
            catch (MySqlException)
            {
            }
            finally
            {
                con.Close();
            }

        }

        public string campo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Placa":
                    campo = "pnumero";
                    break;
                case "Nome":
                    campo = "nome";
                    break;
                case "GPSID":
                    campo = "rgpsid";
                    break;
                case "ClienteID":
                    campo = "idclientes";
                    break;
                case "CPF ou CNPJ":
                    campo = "cpfcnpj";
                    break;
            }
            if (textBox1.Text == "" && !checkBox1.Checked) { listBoxAutoComplete.Visible = false; } else { listBoxAutoComplete.Visible = true; }
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            try
            {
                con.Open();
                string sql = "select "+campo+" from clientes where "+campo+" like \"%" + textBox1.Text + "%\" order by "+campo+" ASC";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                listBoxAutoComplete.DisplayMember = campo;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
            textBox1_TextChanged(null, null);
        }

        private void listBoxAutoComplete_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listBoxAutoComplete.GetItemText(listBoxAutoComplete.SelectedItem);
            listBoxAutoComplete.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { listBoxAutoComplete.Visible = true; } else { listBoxAutoComplete.Visible = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Placa":
                    campo = "pnumero";
                    break;
                case "Nome":
                    campo = "nome";
                    break;
                case "GPSID":
                    campo = "rgpsid";
                    break;
                case "ClienteID":
                    campo = "idclientes";
                    break;
                case "CPF ou CNPJ":
                    campo = "cpfcnpj";
                    break;
            }
            Init(textBox1.Text,campo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxIDCliente.Text.Trim() == "")
            {
                MessageBox.Show("Não é possivel excluir nenhum cliente!");
            }
            else if (MessageBox.Show("Tem certeza que deseja excluir o cliente " + textBoxNome.Text, "Exclusão do cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            try
            {
                con.Open();
                string sql = "delete from clientes where idclientes=\"" + textBoxIDCliente.Text + "\"";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from gps where gpsid=\""+textBoxGPSID.Text+"\"";
                
                CleanButtons();
                nl.GeraKmlNetworkLink();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.ToString());
            }
            }
        }
        public void CleanButtons()
        {
            textBoxNome.Clear();
            textBoxIDCliente.Clear();
            textBoxEndereco.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCEP.Clear();
            textBoxCPFCNPJ.Clear();
            textBoxRG.Clear();
            textBoxTelefones.Clear();
            textBoxEmail.Clear();
            textBox1Responsavel.Clear();
            textBox1Endereco.Clear();
            textBox1Numero.Clear();
            textBox1CEP.Clear();
            textBox1Bairro.Clear();
            textBox1Telefones.Clear();
            textBox1Email.Clear();
            textBox2Responsavel.Clear();
            textBox2Endereco.Clear();
            textBox2Numero.Clear();
            textBox2CEP.Clear();
            textBox2Bairro.Clear();
            textBox2Telefones.Clear();
            textBox2Email.Clear();
            textBoxPNumero.Clear();
            textBoxPModelo.Clear();
            textBoxPMarca.Clear();
            textBoxPCor.Clear();
            textBoxRNumero.Clear();
            textBoxRModelo.Clear();
            textBoxRChip.Clear();
            textBoxRTipo.Clear();
            textBoxGPSID.Clear();
            textBoxLogin.Clear();
            textBoxSenha.Clear();
            textBoxSenhaVerbal.Clear();
            textBoxContraSenha.Clear();
            textBoxObs.Clear();
        }
    }
}
