using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace locatudo
{
    public partial class frlocatudo : Form
    {
        public frlocatudo()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locatudo";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "root";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }


        private void btlimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }


        private void limparCampos()
        {
            txativo.Clear();
            txnome.Clear();
            txtelefone.Clear();            
            txcpf.Clear();
            txendereco.Clear();
            txsexo.Clear();
            txid.Clear();
        }

        private void frlocatudo_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cadastro_pessoas where ativo = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgtab.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgtab.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(0);//id
                    row.Cells[1].Value = reader.GetString(1);//nome
                    row.Cells[2].Value = reader.GetString(2);//telefone
                    dgtab.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }


        private void btsalvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO cadastro_pessoas (nome,telefone,cpf,endereco,sexo) " +
                    "VALUES('" + txnome.Text + "','" + txtelefone.Text + "','" + txcpf.Text + "','" + txendereco.Text + "','" + txsexo.Text + "')";
                    comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgtab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgtab.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                dgtab.CurrentRow.Selected = true;
                txid.Text = dgtab.Rows[e.RowIndex].Cells["dgid"].FormattedValue.ToString();
                txnome.Text = dgtab.Rows[e.RowIndex].Cells["dgnome"].FormattedValue.ToString();
                txtelefone.Text = dgtab.Rows[e.RowIndex].Cells["dgtelefone"].FormattedValue.ToString();
                }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco


                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); 
                comandoMySql.CommandText = "UPDATE cadastro_pessoas SET nome = '" + txnome.Text + "', " + 
                    "telefone = '" + txtelefone.Text + "', " +
                    "cpf = '" + txcpf.Text + "', " +
                    "endereco = '" + txendereco.Text + "', " +
                    "sexo = '" + txsexo.Text + "', " +
                    "ativo = " + Convert.ToInt16(txativo.Text) + 
                    " WHERE id_pessoa = " + txid.Text + "";

                comandoMySql.ExecuteNonQuery();


                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel atualizar o registro! ");
                Console.WriteLine(ex.Message);
            }

        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open(); //Abre a conexão com o banco


                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                                                                                   // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                                                                                   //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                    comandoMySql.CommandText = "DELETE FROM CADASTRO_PESSOAS WHERE ID_PESSOA = " + txid.Text + "";


                    comandoMySql.ExecuteNonQuery();


                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                    atualizaGrid();
                    limparCampos();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Não foi possivel abrir a conexão! ");
                    Console.WriteLine(ex.Message);
                }

            }
        }    
    
}
