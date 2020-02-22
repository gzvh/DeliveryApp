namespace DeliveryApp
{
    partial class ListReceivers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idOdbiorcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieOdbiorcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoOdbiorcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odbiorcyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DeliveryApp.Database1DataSet();
            this.odbiorcyTableAdapter = new DeliveryApp.Database1DataSetTableAdapters.OdbiorcyTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbiorcyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.idOdbiorcyDataGridViewTextBoxColumn,
            this.imieOdbiorcyDataGridViewTextBoxColumn,
            this.nazwiskoOdbiorcyDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numerTelefonuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odbiorcyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            // 
            // idOdbiorcyDataGridViewTextBoxColumn
            // 
            this.idOdbiorcyDataGridViewTextBoxColumn.DataPropertyName = "IdOdbiorcy";
            this.idOdbiorcyDataGridViewTextBoxColumn.HeaderText = "IdOdbiorcy";
            this.idOdbiorcyDataGridViewTextBoxColumn.Name = "idOdbiorcyDataGridViewTextBoxColumn";
            this.idOdbiorcyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieOdbiorcyDataGridViewTextBoxColumn
            // 
            this.imieOdbiorcyDataGridViewTextBoxColumn.DataPropertyName = "ImieOdbiorcy";
            this.imieOdbiorcyDataGridViewTextBoxColumn.HeaderText = "ImieOdbiorcy";
            this.imieOdbiorcyDataGridViewTextBoxColumn.Name = "imieOdbiorcyDataGridViewTextBoxColumn";
            // 
            // nazwiskoOdbiorcyDataGridViewTextBoxColumn
            // 
            this.nazwiskoOdbiorcyDataGridViewTextBoxColumn.DataPropertyName = "NazwiskoOdbiorcy";
            this.nazwiskoOdbiorcyDataGridViewTextBoxColumn.HeaderText = "NazwiskoOdbiorcy";
            this.nazwiskoOdbiorcyDataGridViewTextBoxColumn.Name = "nazwiskoOdbiorcyDataGridViewTextBoxColumn";
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
            // odbiorcyBindingSource
            // 
            this.odbiorcyBindingSource.DataMember = "Odbiorcy";
            this.odbiorcyBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odbiorcyTableAdapter
            // 
            this.odbiorcyTableAdapter.ClearBeforeFill = true;
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(93, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eksportuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListReceivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListReceivers";
            this.Text = "Odbiorcy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListReceivers_FormClosing_1);
            this.Load += new System.EventHandler(this.ListReceivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbiorcyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource odbiorcyBindingSource;
        private Database1DataSetTableAdapters.OdbiorcyTableAdapter odbiorcyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOdbiorcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieOdbiorcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoOdbiorcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}