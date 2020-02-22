using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void odbiorcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wyświetlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Pracownicy")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                ListEmployees f2 = new ListEmployees();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodaj pracownika")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddEmployee f2 = new AddEmployee();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodaj obiorce")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddReceiver f2 = new AddReceiver();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void wyświetlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Odbiorcy")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                ListReceivers f2 = new ListReceivers();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void wyświetlToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Produkty")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                ListProducts f2 = new ListProducts();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodaj produkt")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddProduct f2 = new AddProduct();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void wyświetlToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Zamówienia")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                ListOrders f2 = new ListOrders();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void dodajToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dodaj zamówienie")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddOrder f2 = new AddOrder();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Pomoc")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                Help f2 = new Help();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void miesięcznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
