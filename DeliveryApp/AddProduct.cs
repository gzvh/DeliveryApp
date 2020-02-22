using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
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
            cmd.CommandText = "INSERT INTO Produkty VALUES (@NazwaProduktu, @ImieSprzedawcy, @NazwiskoSprzedawcy, @Ulica, @KodPocztowy, @Miejscowosc, @Email, @NumerTelefonu, @WagaProduktu, @CenaJednostkowa, @Ilosc)";
            cmd.Connection = myConnection;
            cmd.Transaction = tx;
            cmd.Parameters.AddWithValue("@NazwaProduktu", textBox11.Text);
            cmd.Parameters.AddWithValue("@ImieSprzedawcy", textBox1.Text);
            cmd.Parameters.AddWithValue("@NazwiskoSprzedawcy", textBox2.Text);
            cmd.Parameters.AddWithValue("@Ulica", textBox3.Text);
            cmd.Parameters.AddWithValue("@KodPocztowy", textBox4.Text);
            cmd.Parameters.AddWithValue("@Miejscowosc", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox6.Text);
            cmd.Parameters.AddWithValue("@NumerTelefonu", textBox7.Text);
            cmd.Parameters.AddWithValue("@WagaProduktu", textBox8.Text);
            cmd.Parameters.AddWithValue("@CenaJednostkowa", textBox9.Text);
            cmd.Parameters.AddWithValue("@Ilosc", textBox10.Text);
            try
            {
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Dodano produkt pomyślnie");
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
    }
}
