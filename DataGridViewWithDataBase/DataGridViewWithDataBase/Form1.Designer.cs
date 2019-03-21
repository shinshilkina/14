namespace DataGridViewWithDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владельцыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._БД__1_DataSet = new DataGridViewWithDataBase._БД__1_DataSet();
            this.владельцыTableAdapter = new DataGridViewWithDataBase._БД__1_DataSetTableAdapters.ВладельцыTableAdapter();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SernameBox = new System.Windows.Forms.TextBox();
            this.SecondnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Insert2Button = new System.Windows.Forms.Button();
            this.Change2Button = new System.Windows.Forms.Button();
            this.TelephoneBox = new System.Windows.Forms.MaskedTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД__1_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.владельцыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(871, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // владельцыBindingSource
            // 
            this.владельцыBindingSource.DataMember = "Владельцы";
            this.владельцыBindingSource.DataSource = this._БД__1_DataSet;
            // 
            // _БД__1_DataSet
            // 
            this._БД__1_DataSet.DataSetName = "_БД__1_DataSet";
            this._БД__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // владельцыTableAdapter
            // 
            this.владельцыTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(916, 12);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(222, 33);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(916, 51);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(222, 33);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(916, 90);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(222, 33);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(917, 203);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(221, 28);
            this.NameBox.TabIndex = 4;
            // 
            // SernameBox
            // 
            this.SernameBox.Location = new System.Drawing.Point(917, 254);
            this.SernameBox.Multiline = true;
            this.SernameBox.Name = "SernameBox";
            this.SernameBox.Size = new System.Drawing.Size(221, 28);
            this.SernameBox.TabIndex = 5;
            // 
            // SecondnameBox
            // 
            this.SecondnameBox.Location = new System.Drawing.Point(917, 305);
            this.SecondnameBox.Multiline = true;
            this.SecondnameBox.Name = "SecondnameBox";
            this.SecondnameBox.Size = new System.Drawing.Size(221, 28);
            this.SecondnameBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(914, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчетсво";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Телефон";
            // 
            // Insert2Button
            // 
            this.Insert2Button.Location = new System.Drawing.Point(917, 439);
            this.Insert2Button.Name = "Insert2Button";
            this.Insert2Button.Size = new System.Drawing.Size(222, 33);
            this.Insert2Button.TabIndex = 12;
            this.Insert2Button.Text = "Добавить";
            this.Insert2Button.UseVisualStyleBackColor = true;
            this.Insert2Button.Click += new System.EventHandler(this.Insert2Button_Click);
            // 
            // Change2Button
            // 
            this.Change2Button.Location = new System.Drawing.Point(917, 399);
            this.Change2Button.Name = "Change2Button";
            this.Change2Button.Size = new System.Drawing.Size(222, 33);
            this.Change2Button.TabIndex = 13;
            this.Change2Button.Text = "Изменить";
            this.Change2Button.UseVisualStyleBackColor = true;
            this.Change2Button.Click += new System.EventHandler(this.Change2Button_Click);
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(916, 356);
            this.TelephoneBox.Mask = "00000000000";
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(223, 22);
            this.TelephoneBox.TabIndex = 14;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(917, 502);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(222, 33);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "В начало";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 547);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.Change2Button);
            this.Controls.Add(this.Insert2Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondnameBox);
            this.Controls.Add(this.SernameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1168, 6000);
            this.MinimumSize = new System.Drawing.Size(1168, 594);
            this.Name = "Form1";
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владельцыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._БД__1_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _БД__1_DataSet _БД__1_DataSet;
        private System.Windows.Forms.BindingSource владельцыBindingSource;
        private _БД__1_DataSetTableAdapters.ВладельцыTableAdapter владельцыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SernameBox;
        private System.Windows.Forms.TextBox SecondnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Insert2Button;
        private System.Windows.Forms.Button Change2Button;
        private System.Windows.Forms.MaskedTextBox TelephoneBox;
        private System.Windows.Forms.Button CancelButton;
    }
}

