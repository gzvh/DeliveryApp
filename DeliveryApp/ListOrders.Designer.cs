namespace DeliveryApp
{
    partial class ListOrders
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new DeliveryApp.Database1DataSet();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaTableAdapter = new DeliveryApp.Database1DataSetTableAdapters.ZamowieniaTableAdapter();
            this.idZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOdbiorcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWysylkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOdbioruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelPlatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPlatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZamowieniaDataGridViewTextBoxColumn,
            this.idOdbiorcyDataGridViewTextBoxColumn,
            this.idPracownikaDataGridViewTextBoxColumn,
            this.idProduktuDataGridViewTextBoxColumn,
            this.dataZamowieniaDataGridViewTextBoxColumn,
            this.dataWysylkiDataGridViewTextBoxColumn,
            this.dataOdbioruDataGridViewTextBoxColumn,
            this.modelPlatnosciDataGridViewTextBoxColumn,
            this.statusPlatnosciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowieniaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 409);
            this.dataGridView1.TabIndex = 7;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.database1DataSet;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // idZamowieniaDataGridViewTextBoxColumn
            // 
            this.idZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.HeaderText = "IdZamowienia";
            this.idZamowieniaDataGridViewTextBoxColumn.Name = "idZamowieniaDataGridViewTextBoxColumn";
            this.idZamowieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOdbiorcyDataGridViewTextBoxColumn
            // 
            this.idOdbiorcyDataGridViewTextBoxColumn.DataPropertyName = "IdOdbiorcy";
            this.idOdbiorcyDataGridViewTextBoxColumn.HeaderText = "IdOdbiorcy";
            this.idOdbiorcyDataGridViewTextBoxColumn.Name = "idOdbiorcyDataGridViewTextBoxColumn";
            // 
            // idPracownikaDataGridViewTextBoxColumn
            // 
            this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "IdPracownika";
            this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
            // 
            // idProduktuDataGridViewTextBoxColumn
            // 
            this.idProduktuDataGridViewTextBoxColumn.DataPropertyName = "IdProduktu";
            this.idProduktuDataGridViewTextBoxColumn.HeaderText = "IdProduktu";
            this.idProduktuDataGridViewTextBoxColumn.Name = "idProduktuDataGridViewTextBoxColumn";
            // 
            // dataZamowieniaDataGridViewTextBoxColumn
            // 
            this.dataZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "DataZamowienia";
            this.dataZamowieniaDataGridViewTextBoxColumn.HeaderText = "DataZamowienia";
            this.dataZamowieniaDataGridViewTextBoxColumn.Name = "dataZamowieniaDataGridViewTextBoxColumn";
            // 
            // dataWysylkiDataGridViewTextBoxColumn
            // 
            this.dataWysylkiDataGridViewTextBoxColumn.DataPropertyName = "DataWysylki";
            this.dataWysylkiDataGridViewTextBoxColumn.HeaderText = "DataWysylki";
            this.dataWysylkiDataGridViewTextBoxColumn.Name = "dataWysylkiDataGridViewTextBoxColumn";
            // 
            // dataOdbioruDataGridViewTextBoxColumn
            // 
            this.dataOdbioruDataGridViewTextBoxColumn.DataPropertyName = "DataOdbioru";
            this.dataOdbioruDataGridViewTextBoxColumn.HeaderText = "DataOdbioru";
            this.dataOdbioruDataGridViewTextBoxColumn.Name = "dataOdbioruDataGridViewTextBoxColumn";
            // 
            // modelPlatnosciDataGridViewTextBoxColumn
            // 
            this.modelPlatnosciDataGridViewTextBoxColumn.DataPropertyName = "ModelPlatnosci";
            this.modelPlatnosciDataGridViewTextBoxColumn.HeaderText = "ModelPlatnosci";
            this.modelPlatnosciDataGridViewTextBoxColumn.Name = "modelPlatnosciDataGridViewTextBoxColumn";
            // 
            // statusPlatnosciDataGridViewTextBoxColumn
            // 
            this.statusPlatnosciDataGridViewTextBoxColumn.DataPropertyName = "StatusPlatnosci";
            this.statusPlatnosciDataGridViewTextBoxColumn.HeaderText = "StatusPlatnosci";
            this.statusPlatnosciDataGridViewTextBoxColumn.Name = "statusPlatnosciDataGridViewTextBoxColumn";
            // 
            // ListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ListOrders";
            this.Text = "Zamówienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListOrders_FormClosing);
            this.Load += new System.EventHandler(this.ListOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private Database1DataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOdbiorcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWysylkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOdbioruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelPlatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPlatnosciDataGridViewTextBoxColumn;
    }
}