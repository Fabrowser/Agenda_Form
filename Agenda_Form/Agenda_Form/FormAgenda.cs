namespace Agenda_Form
{
    public partial class FormAgenda : Form
    {

        Contatos contatos = new Contatos();

        public FormAgenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Limpar();
            textBoxEmail.Focus();

        }

        private void Limpar()
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxTelefones.Text = "";
            textBoxData.Text = "";
            comboBoxTipo.Text = "";
            listBoxTelefones.Items.Clear();
            checkBoxPrincipal.Checked = false;
        }

        private void buttonGrava_Click(object sender, EventArgs e)
        {

            
            string email = textBoxEmail.Text;
            string nome = textBoxNome.Text;
            DateTime dtNasc = DateTime.Parse(textBoxData.Text);

            //Instancia Telefone
            List<Telefone> telefones = new List<Telefone>();

            for (int i = 0; i < listBoxTelefones.Items.Count; i++)
            {
                string tip = comboBoxTipo.Text;
                string numero = listBoxTelefones.Items[0].ToString();
                bool princ;

                if (checkBoxPrincipal.Checked == true)
                {
                    princ = true;
                }
                else
                {
                    princ = false;
                }
                Telefone tel = new Telefone(tip, numero, princ);
                telefones.Add(tel);  
            }

            Contato contato = new Contato(email, nome, dtNasc, telefones);

            contatos.adicionar(contato);
            listBoxContatos.Items.Add(contato.ToString());
            MessageBox.Show(contato.ToString());

            Limpar();

            textBoxEmail.Focus();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBoxTelefones.Items.Add(textBoxTelefones.Text);
            textBoxTelefones.Text = "";
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {

        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show(contatos.ListaContatos());
            Limpar();
            textBoxEmail.Focus();
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {


            Contato contato_retornado = contatos.pesquisar(textBoxEmail.Text);

            if (contato_retornado != null)
            {
                MessageBox.Show(contato_retornado.ToString());
            }
            else
            {
                MessageBox.Show("Contato não encontrato com o email: " + textBoxEmail.Text);
            }

            
                
        }
    }
}