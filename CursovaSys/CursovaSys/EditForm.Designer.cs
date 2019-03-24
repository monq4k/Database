namespace CursovaSys
{
    partial class EditForm
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
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_PIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.спортсменTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.СпортсменTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(12, 464);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_PIB
            // 
            this.textBox_PIB.Location = new System.Drawing.Point(353, 39);
            this.textBox_PIB.MaxLength = 50;
            this.textBox_PIB.Multiline = true;
            this.textBox_PIB.Name = "textBox_PIB";
            this.textBox_PIB.Size = new System.Drawing.Size(221, 30);
            this.textBox_PIB.TabIndex = 0;
            this.textBox_PIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PIB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "ПІБ_Спортсмена";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(368, 464);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стать";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Країна_Спортсмена";
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(353, 193);
            this.textBox_Country.MaxLength = 50;
            this.textBox_Country.Multiline = true;
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(221, 28);
            this.textBox_Country.TabIndex = 2;
            this.textBox_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Country_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Місто_Спортсмена";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(353, 279);
            this.textBox_City.MaxLength = 50;
            this.textBox_City.Multiline = true;
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(221, 28);
            this.textBox_City.TabIndex = 3;
            this.textBox_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_City_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата народження";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
            this.comboBox_Gender.Location = new System.Drawing.Point(353, 114);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(221, 30);
            this.comboBox_Gender.TabIndex = 1;
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(353, 361);
            this.dateTimePicker_DOB.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker_DOB.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Спортсмен";
            this.bindingSource1.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спортсменTableAdapter
            // 
            this.спортсменTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 542);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PIB);
            this.Controls.Add(this.button_OK);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_PIB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.СпортсменTableAdapter спортсменTableAdapter;
    }
}