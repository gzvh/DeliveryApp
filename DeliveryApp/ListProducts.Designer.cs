namespace DeliveryApp
{
    partial class ListProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieSprzedawcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoSprzedawcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagaProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaJednostkowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DeliveryApp.Database1DataSet();
            this.produktyTableAdapter = new DeliveryApp.Database1DataSetTableAdapters.ProduktyTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(174, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktuDataGridViewTextBoxColumn,
            this.nazwaProduktuDataGridViewTextBoxColumn,
            this.imieSprzedawcyDataGridViewTextBoxColumn,
            this.nazwiskoSprzedawcyDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numerTelefonuDataGridViewTextBoxColumn,
            this.wagaProduktuDataGridViewTextBoxColumn,
            this.cenaJednostkowaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.produktyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 409);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // idProduktuDataGridViewTextBoxColumn
            // 
            this.idProduktuDataGridViewTextBoxColumn.DataPropertyName = "IdProduktu";
            this.idProduktuDataGridViewTextBoxColumn.HeaderText = "IdProduktu";
            this.idProduktuDataGridViewTextBoxColumn.Name = "idProduktuDataGridViewTextBoxColumn";
            this.idProduktuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaProduktuDataGridViewTextBoxColumn
            // 
            this.nazwaProduktuDataGridViewTextBoxColumn.DataPropertyName = "NazwaProduktu";
            this.nazwaProduktuDataGridViewTextBoxColumn.HeaderText = "NazwaProduktu";
            this.nazwaProduktuDataGridViewTextBoxColumn.Name = "nazwaProduktuDataGridViewTextBoxColumn";
            // 
            // imieSprzedawcyDataGridViewTextBoxColumn
            // 
            this.imieSprzedawcyDataGridViewTextBoxColumn.DataPropertyName = "ImieSprzedawcy";
            this.imieSprzedawcyDataGridViewTextBoxColumn.HeaderText = "ImieSprzedawcy";
            this.imieSprzedawcyDataGridViewTextBoxColumn.Name = "imieSprzedawcyDataGridViewTextBoxColumn";
            // 
            // nazwiskoSprzedawcyDataGridViewTextBoxColumn
            // 
            this.nazwiskoSprzedawcyDataGridViewTextBoxColumn.DataPropertyName = "NazwiskoSprzedawcy";
            this.nazwiskoSprzedawcyDataGridViewTextBoxColumn.HeaderText = "NazwiskoSprzedawcy";
            this.nazwiskoSprzedawcyDataGridViewTextBoxColumn.Name = "nazwiskoSprzedawcyDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            this.kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // numerTelefonuDataGridViewTextBoxColumn
            // 
            this.numerTelefonuDataGridViewTextBoxColumn.DataPropertyName = "NumerTelefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.HeaderText = "NumerTelefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.Name = "numerTelefonuDataGridViewTextBoxColumn";
            // 
            // wagaProduktuDataGridViewTextBoxColumn
            // 
            this.wagaProduktuDataGridViewTextBoxColumn.DataPropertyName = "WagaProduktu";
            this.wagaProduktuDataGridViewTextBoxColumn.HeaderText = "WagaProduktu";
            this.wagaProduktuDataGridViewTextBoxColumn.Name = "wagaProduktuDataGridViewTextBoxColumn";
            // 
            // cenaJednostkowaDataGridViewTextBoxColumn
            // 
            this.cenaJednostkowaDataGridViewTextBoxColumn.DataPropertyName = "CenaJednostkowa";
            this.cenaJednostkowaDataGridViewTextBoxColumn.HeaderText = "CenaJednostkowa";
            this.cenaJednostkowaDataGridViewTextBoxColumn.Name = "cenaJednostkowaDataGridViewTextBoxColumn";
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(93, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eksportuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ListProducts";
            this.Text = "Produkty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListProducts_FormClosing);
            this.Load += new System.EventHandler(this.ListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Database1DataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieSprzedawcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoSprzedawcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wagaProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaJednostkowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}