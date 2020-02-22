namespace DeliveryApp
{
    partial class ListEmployees
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
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiePracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZatrudnieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojazdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DeliveryApp.Database1DataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.pracownicyTableAdapter = new DeliveryApp.Database1DataSetTableAdapters.PracownicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(174, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPracownikaDataGridViewTextBoxColumn,
            this.imiePracownikaDataGridViewTextBoxColumn,
            this.nazwiskoPracownikaDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numerTelefonuDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.dataZatrudnieniaDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn,
            this.pojazdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownicyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 409);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            // 
            // idPracownikaDataGridViewTextBoxColumn
            // 
            this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
            this.idPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imiePracownikaDataGridViewTextBoxColumn
            // 
            this.imiePracownikaDataGridViewTextBoxColumn.DataPropertyName = "ImiePracownika";
            this.imiePracownikaDataGridViewTextBoxColumn.HeaderText = "ImiePracownika";
            this.imiePracownikaDataGridViewTextBoxColumn.Name = "imiePracownikaDataGridViewTextBoxColumn";
            // 
            // nazwiskoPracownikaDataGridViewTextBoxColumn
            // 
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.DataPropertyName = "NazwiskoPracownika";
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.HeaderText = "NazwiskoPracownika";
            this.nazwiskoPracownikaDataGridViewTextBoxColumn.Name = "nazwiskoPracownikaDataGridViewTextBoxColumn";
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
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            // 
            // dataZatrudnieniaDataGridViewTextBoxColumn
            // 
            this.dataZatrudnieniaDataGridViewTextBoxColumn.DataPropertyName = "DataZatrudnienia";
            this.dataZatrudnieniaDataGridViewTextBoxColumn.HeaderText = "DataZatrudnienia";
            this.dataZatrudnieniaDataGridViewTextBoxColumn.Name = "dataZatrudnieniaDataGridViewTextBoxColumn";
            // 
            // stanowiskoDataGridViewTextBoxColumn
            // 
            this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
            // 
            // pojazdDataGridViewTextBoxColumn
            // 
            this.pojazdDataGridViewTextBoxColumn.DataPropertyName = "Pojazd";
            this.pojazdDataGridViewTextBoxColumn.HeaderText = "Pojazd";
            this.pojazdDataGridViewTextBoxColumn.Name = "pojazdDataGridViewTextBoxColumn";
            // 
            // pracownicyBindingSource1
            // 
            this.pracownicyBindingSource1.DataMember = "Pracownicy";
            this.pracownicyBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.EnforceConstraints = false;
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(93, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eksportuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ListEmployees";
            this.Text = "Pracownicy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListEmployees_FormClosing_1);
            this.Load += new System.EventHandler(this.ListEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private Database1DataSetTableAdapters.PracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiePracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZatrudnieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pojazdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pracownicyBindingSource1;
    }
}