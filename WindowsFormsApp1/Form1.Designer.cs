
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPokupkabiletovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenabiletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerzalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Nazvanie_filma = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDNazvanieFilmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new WindowsFormsApp1.testDataSet();
            this.ID_Sposob_oplati = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDSposoboplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDSotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Klient = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDKlientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Mesto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDMestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupkabiletovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupka_biletovTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.Pokupka_biletovTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.iD_Nazvanie_filmaTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.ID_Nazvanie_filmaTableAdapter();
            this.iD_MestoTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.ID_MestoTableAdapter();
            this.iD_KlientTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.ID_KlientTableAdapter();
            this.iD_SotrudnikTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.ID_SotrudnikTableAdapter();
            this.iD_Sposob_oplatiTableAdapter = new WindowsFormsApp1.testDataSetTableAdapters.ID_Sposob_oplatiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNazvanieFilmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSposoboplatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDKlientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDMestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkabiletovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPokupkabiletovDataGridViewTextBoxColumn,
            this.cenabiletaDataGridViewTextBoxColumn,
            this.nomerzalaDataGridViewTextBoxColumn,
            this.ID_Nazvanie_filma,
            this.ID_Sposob_oplati,
            this.ID_Sotrudnik,
            this.ID_Klient,
            this.ID_Mesto});
            this.dataGridView1.DataSource = this.pokupkabiletovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDPokupkabiletovDataGridViewTextBoxColumn
            // 
            this.iDPokupkabiletovDataGridViewTextBoxColumn.DataPropertyName = "ID_Pokupka_biletov";
            this.iDPokupkabiletovDataGridViewTextBoxColumn.HeaderText = "ID_Pokupka_biletov";
            this.iDPokupkabiletovDataGridViewTextBoxColumn.Name = "iDPokupkabiletovDataGridViewTextBoxColumn";
            this.iDPokupkabiletovDataGridViewTextBoxColumn.Width = 150;
            // 
            // cenabiletaDataGridViewTextBoxColumn
            // 
            this.cenabiletaDataGridViewTextBoxColumn.DataPropertyName = "Cena_bileta";
            this.cenabiletaDataGridViewTextBoxColumn.HeaderText = "Цена билета";
            this.cenabiletaDataGridViewTextBoxColumn.Name = "cenabiletaDataGridViewTextBoxColumn";
            // 
            // nomerzalaDataGridViewTextBoxColumn
            // 
            this.nomerzalaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_zala";
            this.nomerzalaDataGridViewTextBoxColumn.HeaderText = "Номер зала";
            this.nomerzalaDataGridViewTextBoxColumn.Name = "nomerzalaDataGridViewTextBoxColumn";
            // 
            // ID_Nazvanie_filma
            // 
            this.ID_Nazvanie_filma.DataPropertyName = "ID_Nazvanie_filma";
            this.ID_Nazvanie_filma.DataSource = this.iDNazvanieFilmaBindingSource;
            this.ID_Nazvanie_filma.DisplayMember = "Nazvanie_filma";
            this.ID_Nazvanie_filma.HeaderText = "Название фильма";
            this.ID_Nazvanie_filma.Name = "ID_Nazvanie_filma";
            this.ID_Nazvanie_filma.ValueMember = "ID_Nazvanie_filma";
            // 
            // iDNazvanieFilmaBindingSource
            // 
            this.iDNazvanieFilmaBindingSource.DataMember = "ID_Nazvanie filma";
            this.iDNazvanieFilmaBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Sposob_oplati
            // 
            this.ID_Sposob_oplati.DataPropertyName = "ID_Sposob_oplati";
            this.ID_Sposob_oplati.DataSource = this.iDSposoboplatiBindingSource;
            this.ID_Sposob_oplati.DisplayMember = "Sposob_oplati";
            this.ID_Sposob_oplati.HeaderText = "Способ оплаты";
            this.ID_Sposob_oplati.Name = "ID_Sposob_oplati";
            this.ID_Sposob_oplati.ValueMember = "ID_Sposob_oplati";
            // 
            // iDSposoboplatiBindingSource
            // 
            this.iDSposoboplatiBindingSource.DataMember = "ID_Sposob_oplati";
            this.iDSposoboplatiBindingSource.DataSource = this.testDataSet;
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.iDSotrudnikBindingSource;
            this.ID_Sotrudnik.DisplayMember = "Familia_sotrudnika";
            this.ID_Sotrudnik.HeaderText = "Сотрудник";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // iDSotrudnikBindingSource
            // 
            this.iDSotrudnikBindingSource.DataMember = "ID_Sotrudnik";
            this.iDSotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // ID_Klient
            // 
            this.ID_Klient.DataPropertyName = "ID_Klient";
            this.ID_Klient.DataSource = this.iDKlientBindingSource;
            this.ID_Klient.DisplayMember = "Familia_klienta";
            this.ID_Klient.HeaderText = "Клиент";
            this.ID_Klient.Name = "ID_Klient";
            this.ID_Klient.ValueMember = "ID_Klient";
            // 
            // iDKlientBindingSource
            // 
            this.iDKlientBindingSource.DataMember = "ID_Klient";
            this.iDKlientBindingSource.DataSource = this.testDataSet;
            // 
            // ID_Mesto
            // 
            this.ID_Mesto.DataPropertyName = "ID_Mesto";
            this.ID_Mesto.DataSource = this.iDMestoBindingSource;
            this.ID_Mesto.DisplayMember = "Mesto";
            this.ID_Mesto.HeaderText = "Место";
            this.ID_Mesto.Name = "ID_Mesto";
            this.ID_Mesto.ValueMember = "ID_Mesto";
            // 
            // iDMestoBindingSource
            // 
            this.iDMestoBindingSource.DataMember = "ID_Mesto";
            this.iDMestoBindingSource.DataSource = this.testDataSet;
            // 
            // pokupkabiletovBindingSource
            // 
            this.pokupkabiletovBindingSource.DataMember = "Pokupka_biletov";
            this.pokupkabiletovBindingSource.DataSource = this.testDataSet;
            // 
            // pokupka_biletovTableAdapter
            // 
            this.pokupka_biletovTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 443);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // iD_Nazvanie_filmaTableAdapter
            // 
            this.iD_Nazvanie_filmaTableAdapter.ClearBeforeFill = true;
            // 
            // iD_MestoTableAdapter
            // 
            this.iD_MestoTableAdapter.ClearBeforeFill = true;
            // 
            // iD_KlientTableAdapter
            // 
            this.iD_KlientTableAdapter.ClearBeforeFill = true;
            // 
            // iD_SotrudnikTableAdapter
            // 
            this.iD_SotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // iD_Sposob_oplatiTableAdapter
            // 
            this.iD_Sposob_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Покупка билетов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDNazvanieFilmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSposoboplatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDKlientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDMestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkabiletovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public testDataSet testDataSet;
        public System.Windows.Forms.BindingSource pokupkabiletovBindingSource;
        public testDataSetTableAdapters.Pokupka_biletovTableAdapter pokupka_biletovTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource iDNazvanieFilmaBindingSource;
        private testDataSetTableAdapters.ID_Nazvanie_filmaTableAdapter iD_Nazvanie_filmaTableAdapter;
        private System.Windows.Forms.BindingSource iDMestoBindingSource;
        private testDataSetTableAdapters.ID_MestoTableAdapter iD_MestoTableAdapter;
        private System.Windows.Forms.BindingSource iDKlientBindingSource;
        private testDataSetTableAdapters.ID_KlientTableAdapter iD_KlientTableAdapter;
        private System.Windows.Forms.BindingSource iDSotrudnikBindingSource;
        private testDataSetTableAdapters.ID_SotrudnikTableAdapter iD_SotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource iDSposoboplatiBindingSource;
        private testDataSetTableAdapters.ID_Sposob_oplatiTableAdapter iD_Sposob_oplatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPokupkabiletovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenabiletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerzalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Nazvanie_filma;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sposob_oplati;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Klient;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Mesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

