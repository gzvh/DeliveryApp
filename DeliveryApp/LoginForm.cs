using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class LoginForm : Form
    {

        String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Proszę wprowadzić nazwę uzytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Proszę wprowadzić hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Login,Haslo FROM Login WHERE Login = @Login AND Haslo = @Haslo", myConnection);

                SqlParameter uName = new SqlParameter("@Login", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Haslo", SqlDbType.VarChar);

                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("Zalogowano pomyślnie " + txtUserName.Text);
                    this.Hide();
                    Form form = new MainForm();
                    form.ShowDialog();
                }


                else
                {
                    MessageBox.Show("Wystąpił błąd podczas logowania... Sprobój jeszcze raz!", "Bląd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Login' . Możesz go przenieść lub usunąć.
            this.loginTableAdapter.Fill(this.database1DataSet.Login);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
