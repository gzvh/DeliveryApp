using System;
using System.IO;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class ListProducts : Form
    {
        private bool daneZmienione = false;
        public ListProducts()
        {
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.database1DataSet.Produkty);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.database1DataSet.Produkty);
            daneZmienione = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.produktyTableAdapter.Update(this.database1DataSet.Produkty);
            MessageBox.Show("Dane zapisane");
            daneZmienione = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ListProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!daneZmienione) return;
            switch (MessageBox.Show("Czy zapisać zmiany w bazie danych?", this.Text, MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel: e.Cancel = true; break;
                case DialogResult.No: break;
                case DialogResult.Yes:
                    try
                    {
                        this.Validate();
                        this.produktyBindingSource.EndEdit();
                        this.produktyTableAdapter.Update(database1DataSet.Produkty); //MessageBox.Show("Dane zapisane do bazy"); }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Zapisywanie danych nie powiodło się (" + exc.Message + ")");
                        throw;
                    }
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            daneZmienione = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string csv = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    csv += column.HeaderText + ';';
                }
                csv += "\r\n";
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        csv += cell.Value.ToString().Replace(",", ";") + ';';
                    }
                    csv += "\r\n";
                }

                try
                {
                    File.WriteAllText(sfd.FileName, csv);
                    MessageBox.Show("Zapisano pomyślnie");
                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }
    }
}
