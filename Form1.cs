using System.Data;

namespace consultarcep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void tbcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        { //Limpar campos 
            tbcep.Text = String.Empty;
            tbendereco.Text = String.Empty;
            tbbairro.Text = String.Empty;
            tbendereco.Text = String.Empty;
            tbcidade.Text = String.Empty;
            tbuf.Text = String.Empty;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", tbcep.Text);
                ds.ReadXml(xml);
                tbendereco.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                tbbairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                tbcidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                tbuf.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}