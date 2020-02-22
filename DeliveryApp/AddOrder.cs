using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            ShowReceivers();
            ShowEmployyes();
            ShowProducts();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";
            myConnection.Open();
            SqlTransaction tx = myConnection.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Zamowienia VALUES (@IdOdbiorcy, @IdPracownika, @IdProduktu, @DataZamowienia, @DataWysylki, @DataOdbioru, @ModelPlatnosci, @StatusPlatnosci)";
            cmd.Connection = myConnection;
            cmd.Transaction = tx;
            cmd.Parameters.AddWithValue("@IdOdbiorcy", textBox1.Text);
            cmd.Parameters.AddWithValue("@IdPracownika", textBox2.Text);
            cmd.Parameters.AddWithValue("@IdProduktu", textBox3.Text);
            cmd.Parameters.AddWithValue("@DataZamowienia", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@DataWysylki", dateTimePicker3.Value);
            cmd.Parameters.AddWithValue("@DataOdbioru", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@ModelPlatnosci", comboBox4.SelectedItem);
            cmd.Parameters.AddWithValue("@StatusPlatnosci", comboBox5.SelectedItem);
            try
            {
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Dodano zamówienie pomyślnie");
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void ShowEmployyes()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";
            SqlCommand cmd = new SqlCommand("select * from Pracownicy", myConnection);
            myConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(dataSet.Tables[0].Rows[i][0] + " | " + dataSet.Tables[0].Rows[i][1] + " | " + dataSet.Tables[0].Rows[i][2]);
            }
            myConnection.Close();
        }

        public void ShowReceivers()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";
            SqlCommand cmd = new SqlCommand("select * from Odbiorcy", myConnection);
            myConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSet.Tables[0].Rows[i][0] + " | " + dataSet.Tables[0].Rows[i][1] + " | " + dataSet.Tables[0].Rows[i][2]);
            }
            myConnection.Close();
        }

        public void ShowProducts()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Przemek\Documents\GitHub\DeliveryApp\DeliveryApp\Database1.mdf;Integrated Security = True";
            SqlCommand cmd = new SqlCommand("select * from Produkty", myConnection);
            myConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                comboBox3.Items.Add(dataSet.Tables[0].Rows[i][0] + " | " + dataSet.Tables[0].Rows[i][1] + " | " + dataSet.Tables[0].Rows[i][2]);
            }
            myConnection.Close();
        }
    }
}
