namespace CursovaSys
{
    partial class EditFormResSport
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
            this.comboBox_Disciplina = new System.Windows.Forms.ComboBox();
            this.дисциплінаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.comboBox_Sportsmen = new System.Windows.Forms.ComboBox();
            this.спорткомітетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Sportsmen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.результат_СпортсменаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.Результат_СпортсменаTableAdapter();
            this.спорткомітетTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.СпорткомітетTableAdapter();
            this.дисциплінаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.ДисциплінаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплінаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спорткомітетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Disciplina
            // 
            this.comboBox_Disciplina.DataSource = this.дисциплінаBindingSource;
            this.comboBox_Disciplina.DisplayMember = "Назва_дисципліни";
            this.comboBox_Disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Disciplina.FormattingEnabled = true;
            this.comboBox_Disciplina.Location = new System.Drawing.Point(374, 100);
            this.comboBox_Disciplina.Name = "comboBox_Disciplina";
            this.comboBox_Disciplina.Size = new System.Drawing.Size(246, 30);
            this.comboBox_Disciplina.TabIndex = 1;
            this.comboBox_Disciplina.ValueMember = "id_дисципліни";
            // 
            // дисциплінаBindingSource
            // 
            this.дисциплінаBindingSource.DataMember = "Дисципліна";
            this.дисциплінаBindingSource.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Sportsmen
            // 
            this.comboBox_Sportsmen.DataSource = this.спорткомітетBindingSource;
            this.comboBox_Sportsmen.DisplayMember = "id_Спортсмена_на_турнірі";
            this.comboBox_Sportsmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sportsmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Sportsmen.FormattingEnabled = true;
            this.comboBox_Sportsmen.Location = new System.Drawing.Point(374, 33);
            this.comboBox_Sportsmen.Name = "comboBox_Sportsmen";
            this.comboBox_Sportsmen.Size = new System.Drawing.Size(246, 30);
            this.comboBox_Sportsmen.TabIndex = 0;
            this.comboBox_Sportsmen.ValueMember = "id_Спортсмена_на_турнірі";
            // 
            // спорткомітетBindingSource
            // 
            this.спорткомітетBindingSource.DataMember = "Спорткомітет";
            this.спорткомітетBindingSource.DataSource = this.sportMainDataSet;
            // 
            // label_Sportsmen
            // 
            this.label_Sportsmen.AutoSize = true;
            this.label_Sportsmen.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label_Sportsmen.Location = new System.Drawing.Point(71, 33);
            this.label_Sportsmen.Name = "label_Sportsmen";
            this.label_Sportsmen.Size = new System.Drawing.Size(180, 41);
            this.label_Sportsmen.TabIndex = 33;
            this.label_Sportsmen.Text = "Спортсмен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дисципліна";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(364, 239);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(35, 239);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(374, 164);
            this.textBox_Result.MaxLength = 5;
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(246, 30);
            this.textBox_Result.TabIndex = 2;
            this.textBox_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Result_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 41);
            this.label7.TabIndex = 41;
            this.label7.Text = "Результат_Спортсмена";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Результат_Спортсмена";
            this.bindingSource1.DataSource = this.sportMainDataSet;
            // 
            // результат_СпортсменаTableAdapter
            // 
            this.результат_СпортсменаTableAdapter.ClearBeforeFill = true;
            // 
            // спорткомітетTableAdapter
            // 
            this.спорткомітетTableAdapter.ClearBeforeFill = true;
            // 
            // дисциплінаTableAdapter
            // 
            this.дисциплінаTableAdapter.ClearBeforeFill = true;
            // 
            // EditFormResSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 322);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Disciplina);
            this.Controls.Add(this.comboBox_Sportsmen);
            this.Controls.Add(this.label_Sportsmen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "EditFormResSport";
            this.Text = "EditFormResSport";
            this.Load += new System.EventHandler(this.EditFormResSport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.дисциплінаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спорткомітетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Disciplina;
        private System.Windows.Forms.ComboBox comboBox_Sportsmen;
        private System.Windows.Forms.Label label_Sportsmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.Результат_СпортсменаTableAdapter результат_СпортсменаTableAdapter;
        private System.Windows.Forms.BindingSource спорткомітетBindingSource;
        private SportMainDataSetTableAdapters.СпорткомітетTableAdapter спорткомітетTableAdapter;
        private System.Windows.Forms.BindingSource дисциплінаBindingSource;
        private SportMainDataSetTableAdapters.ДисциплінаTableAdapter дисциплінаTableAdapter;
    }
}