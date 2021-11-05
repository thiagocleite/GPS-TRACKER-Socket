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
using System.IO;

namespace GPS1Visual
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxGPSID.Text.Trim() == "" || textBoxPNumero.Text == "") { MessageBox.Show("Os campos \"GPSID\" e \"Número da placa do veículo\" não poderão ficar vazios!"); }
            else{
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into clientes(nome,endereco,numero,bairro,cep,cpfcnpj,rg,telefones,email,1responsavel,1endereco,1bairro,1numero,1cep,1telefones,1email,2responsavel,2endereco,2bairro,2numero,2cep,2telefones,2email,senhaverbal,csenhaverbal,pnumero,pmodelo,pmarca,pcor,rmodelo,rchip,rnumero,rtipo,rgpsid,login,senha,obs)values(@nome,@endereco,@numero,@bairro,@cep,@cpfcnpj,@rg,@telefones,@email,@1responsavel,@1endereco,@1bairro,@1numero,@1cep,@1telefones,@1email,@2responsavel,@2endereco,@2bairro,@2numero,@2cep,@2telefones,@2email,@senhaverbal,@csenhaverbal,@pnumero,@pmodelo,@pmarca,@pcor,@rmodelo,@rchip,@rnumero,@rtipo,@rgpsid,@login,MD5(@senha),@obs)";
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
                MessageBox.Show("Cadastro efetuado com sucesso!");

                GeraNetworkLink nl = new GeraNetworkLink();
                nl.GeraKmlNetworkLink();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
        }
        public void button2_Click(object sender, EventArgs e)
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
            textBoxSenhaVerbal.Clear();
            textBoxContraSenha.Clear();
            textBoxObs.Clear();
        }
    }
}
