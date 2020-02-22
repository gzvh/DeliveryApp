using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";
            myConnection.Open();
            SqlTransaction tx = myConnection.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Pracownicy VALUES (@ImiePracownika, @NazwiskoPracownika, @Ulica, @KodPocztowy, @Miejscowosc, @Email, @NumerTelefonu, @DataUrodzenia, @DataZatrudnienia, @Stanowisko, @Pojazd)";
            cmd.Connection = myConnection;
            cmd.Transaction = tx;
            cmd.Parameters.AddWithValue("@ImiePracownika", textBox1.Text);
            cmd.Parameters.AddWithValue("@NazwiskoPracownika", textBox2.Text);
            cmd.Parameters.AddWithValue("@Ulica", textBox3.Text);
            cmd.Parameters.AddWithValue("@KodPocztowy", textBox4.Text);
            cmd.Parameters.AddWithValue("@Miejscowosc", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox6.Text);
            cmd.Parameters.AddWithValue("@NumerTelefonu", textBox7.Text);
            cmd.Parameters.AddWithValue("@DataUrodzenia", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@DataZatrudnienia", dateTimePicker3.Value);
            cmd.Parameters.AddWithValue("@Stanowisko", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@Pojazd", comboBox1.SelectedItem);
            try
            {
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Dodano użytkownika pomyślnie");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                tx.Rollback();
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
