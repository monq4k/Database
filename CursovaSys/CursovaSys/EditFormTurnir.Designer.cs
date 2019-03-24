namespace CursovaSys
{
    partial class EditFormTurnir
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
            this.dateTimePicker_NACALO = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Kilkist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.dateTimePicker_KONEC = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Misce = new System.Windows.Forms.ComboBox();
            this.місцеположеннятурніруBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.турнірTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.ТурнірTableAdapter();
            this.місцеположення_турніруTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.Місцеположення_турніруTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.місцеположеннятурніруBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_NACALO
            // 
            this.dateTimePicker_NACALO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_NACALO.Location = new System.Drawing.Point(383, 277);
            this.dateTimePicker_NACALO.MaxDate = new System.DateTime(2018, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker_NACALO.Name = "dateTimePicker_NACALO";
            this.dateTimePicker_NACALO.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker_NACALO.TabIndex = 3;
            this.dateTimePicker_NACALO.Value = new System.DateTime(2018, 12, 25, 23, 59, 59, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 41);
            this.label5.TabIndex = 33;
            this.label5.Text = "Кількість учасників";
            // 
            // textBox_Kilkist
            // 
            this.textBox_Kilkist.Location = new System.Drawing.Point(383, 197);
            this.textBox_Kilkist.MaxLength = 15;
            this.textBox_Kilkist.Multiline = true;
            this.textBox_Kilkist.Name = "textBox_Kilkist";
            this.textBox_Kilkist.Size = new System.Drawing.Size(221, 28);
            this.textBox_Kilkist.TabIndex = 2;
            this.textBox_Kilkist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kilkist_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(62, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 41);
            this.label3.TabIndex = 30;
            this.label3.Text = "Місце проведення";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(371, 455);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "Вид спорту";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(69, 455);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // dateTimePicker_KONEC
            // 
            this.dateTimePicker_KONEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_KONEC.Location = new System.Drawing.Point(383, 334);
            this.dateTimePicker_KONEC.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker_KONEC.Name = "dateTimePicker_KONEC";
            this.dateTimePicker_KONEC.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker_KONEC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Дата кінця";
            // 
            // comboBox_Misce
            // 
            this.comboBox_Misce.DataSource = this.місцеположеннятурніруBindingSource;
            this.comboBox_Misce.DisplayMember = "Назва";
            this.comboBox_Misce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Misce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Misce.FormattingEnabled = true;
            this.comboBox_Misce.Location = new System.Drawing.Point(383, 127);
            this.comboBox_Misce.Name = "comboBox_Misce";
            this.comboBox_Misce.Size = new System.Drawing.Size(221, 30);
            this.comboBox_Misce.TabIndex = 1;
            this.comboBox_Misce.ValueMember = "id_Місця";
            // 
            // місцеположеннятурніруBindingSource
            // 
            this.місцеположеннятурніруBindingSource.DataMember = "Місцеположення_турніру";
            this.місцеположеннятурніруBindingSource.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Турнір";
            this.bindingSource1.DataSource = this.sportMainDataSet;
            // 
            // турнірTableAdapter
            // 
            this.турнірTableAdapter.ClearBeforeFill = true;
            // 
            // місцеположення_турніруTableAdapter
            // 
            this.місцеположення_турніруTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(62, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 41);
            this.label4.TabIndex = 38;
            this.label4.Text = "Дата початку";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Індивідуальний",
            "Командний"});
            this.comboBox1.Location = new System.Drawing.Point(383, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // EditFormTurnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 577);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Misce);
            this.Controls.Add(this.dateTimePicker_KONEC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_NACALO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Kilkist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OK);
            this.Name = "EditFormTurnir";
            this.Text = "EditFormTurnir";
            this.Load += new System.EventHandler(this.EditFormTurnir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.місцеположеннятурніруBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_NACALO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Kilkist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KONEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Misce;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.ТурнірTableAdapter турнірTableAdapter;
        private System.Windows.Forms.BindingSource місцеположеннятурніруBindingSource;
        private SportMainDataSetTableAdapters.Місцеположення_турніруTableAdapter місцеположення_турніруTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}