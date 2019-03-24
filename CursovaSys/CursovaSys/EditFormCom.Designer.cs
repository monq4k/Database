namespace CursovaSys
{
    partial class EditFormCom
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
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.командаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.КомандаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(347, 277);
            this.dateTimePicker_DOB.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker_DOB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 41);
            this.label5.TabIndex = 22;
            this.label5.Text = "Дата заснування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 41);
            this.label4.TabIndex = 21;
            this.label4.Text = "Місто_Команди";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(347, 195);
            this.textBox_City.MaxLength = 50;
            this.textBox_City.Multiline = true;
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(221, 28);
            this.textBox_City.TabIndex = 2;
            this.textBox_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_City_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Країна_Команди";
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(347, 117);
            this.textBox_Country.MaxLength = 50;
            this.textBox_Country.Multiline = true;
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(221, 28);
            this.textBox_Country.TabIndex = 1;
            this.textBox_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Country_KeyPress);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(347, 356);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Назва_Команди";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(347, 43);
            this.textBox_Name.MaxLength = 50;
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(221, 30);
            this.textBox_Name.TabIndex = 0;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(45, 356);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Команда";
            this.bindingSource1.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // командаTableAdapter
            // 
            this.командаTableAdapter.ClearBeforeFill = true;
            // 
            // EditFormCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 447);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_OK);
            this.Name = "EditFormCom";
            this.Text = "EditFormCom";
            this.Load += new System.EventHandler(this.EditFormCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.КомандаTableAdapter командаTableAdapter;
    }
}