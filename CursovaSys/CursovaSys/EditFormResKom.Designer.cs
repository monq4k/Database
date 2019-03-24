namespace CursovaSys
{
    partial class EditFormResKom
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.comboBox_Komand = new System.Windows.Forms.ComboBox();
            this.командаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.comboBox_Turnir = new System.Windows.Forms.ComboBox();
            this.турнірBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Disciplina = new System.Windows.Forms.ComboBox();
            this.дисциплінаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.результат_командиTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.Результат_командиTableAdapter();
            this.командаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.КомандаTableAdapter();
            this.дисциплінаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.ДисциплінаTableAdapter();
            this.турнірTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.ТурнірTableAdapter();
            this.textBox_Misce = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнірBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплінаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 41);
            this.label3.TabIndex = 20;
            this.label3.Text = "Номер турніру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дисципліна";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(357, 368);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Команда";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(43, 368);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // comboBox_Komand
            // 
            this.comboBox_Komand.DataSource = this.командаBindingSource;
            this.comboBox_Komand.DisplayMember = "Назва";
            this.comboBox_Komand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Komand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Komand.FormattingEnabled = true;
            this.comboBox_Komand.Location = new System.Drawing.Point(357, 21);
            this.comboBox_Komand.Name = "comboBox_Komand";
            this.comboBox_Komand.Size = new System.Drawing.Size(246, 30);
            this.comboBox_Komand.TabIndex = 0;
            this.comboBox_Komand.ValueMember = "id_Команди";
            // 
            // командаBindingSource
            // 
            this.командаBindingSource.DataMember = "Команда";
            this.командаBindingSource.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Turnir
            // 
            this.comboBox_Turnir.DataSource = this.турнірBindingSource;
            this.comboBox_Turnir.DisplayMember = "id_Турніру";
            this.comboBox_Turnir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Turnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Turnir.FormattingEnabled = true;
            this.comboBox_Turnir.Location = new System.Drawing.Point(357, 156);
            this.comboBox_Turnir.Name = "comboBox_Turnir";
            this.comboBox_Turnir.Size = new System.Drawing.Size(246, 30);
            this.comboBox_Turnir.TabIndex = 2;
            this.comboBox_Turnir.ValueMember = "id_Турніру";
            // 
            // турнірBindingSource
            // 
            this.турнірBindingSource.DataMember = "Турнір";
            this.турнірBindingSource.DataSource = this.sportMainDataSet;
            // 
            // comboBox_Disciplina
            // 
            this.comboBox_Disciplina.DataSource = this.дисциплінаBindingSource;
            this.comboBox_Disciplina.DisplayMember = "Назва_дисципліни";
            this.comboBox_Disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Disciplina.FormattingEnabled = true;
            this.comboBox_Disciplina.Location = new System.Drawing.Point(357, 84);
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Результат_команди";
            this.bindingSource1.DataSource = this.sportMainDataSet;
            // 
            // результат_командиTableAdapter
            // 
            this.результат_командиTableAdapter.ClearBeforeFill = true;
            // 
            // командаTableAdapter
            // 
            this.командаTableAdapter.ClearBeforeFill = true;
            // 
            // дисциплінаTableAdapter
            // 
            this.дисциплінаTableAdapter.ClearBeforeFill = true;
            // 
            // турнірTableAdapter
            // 
            this.турнірTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_Misce
            // 
            this.textBox_Misce.Location = new System.Drawing.Point(357, 289);
            this.textBox_Misce.Multiline = true;
            this.textBox_Misce.Name = "textBox_Misce";
            this.textBox_Misce.Size = new System.Drawing.Size(246, 30);
            this.textBox_Misce.TabIndex = 4;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(357, 219);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(246, 30);
            this.textBox_Result.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(36, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 41);
            this.label6.TabIndex = 42;
            this.label6.Text = "Командне місце";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 41);
            this.label7.TabIndex = 41;
            this.label7.Text = "Результат_Команди";
            // 
            // EditFormResKom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 431);
            this.Controls.Add(this.textBox_Misce);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Disciplina);
            this.Controls.Add(this.comboBox_Turnir);
            this.Controls.Add(this.comboBox_Komand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OK);
            this.Name = "EditFormResKom";
            this.Text = "EditFormResKom";
            this.Load += new System.EventHandler(this.EditFormResKom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнірBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплінаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox_Komand;
        private System.Windows.Forms.ComboBox comboBox_Turnir;
        private System.Windows.Forms.ComboBox comboBox_Disciplina;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.Результат_командиTableAdapter результат_командиTableAdapter;
        private System.Windows.Forms.BindingSource командаBindingSource;
        private SportMainDataSetTableAdapters.КомандаTableAdapter командаTableAdapter;
        private System.Windows.Forms.BindingSource дисциплінаBindingSource;
        private SportMainDataSetTableAdapters.ДисциплінаTableAdapter дисциплінаTableAdapter;
        private System.Windows.Forms.BindingSource турнірBindingSource;
        private SportMainDataSetTableAdapters.ТурнірTableAdapter турнірTableAdapter;
        private System.Windows.Forms.TextBox textBox_Misce;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}