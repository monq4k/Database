namespace CursovaSys
{
    partial class EditFormSportcom
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
            this.comboBox_Sportsmen = new System.Windows.Forms.ComboBox();
            this.спортсменBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportMainDataSet = new CursovaSys.SportMainDataSet();
            this.comboBox_Komanda = new System.Windows.Forms.ComboBox();
            this.командаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Tournir = new System.Windows.Forms.ComboBox();
            this.турнірBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.спорткомітетTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.СпорткомітетTableAdapter();
            this.спортсменTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.СпортсменTableAdapter();
            this.командаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.КомандаTableAdapter();
            this.турнірTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.ТурнірTableAdapter();
            this.результатСпортсменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.результат_СпортсменаTableAdapter = new CursovaSys.SportMainDataSetTableAdapters.Результат_СпортсменаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.спортсменBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнірBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатСпортсменаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 41);
            this.label3.TabIndex = 20;
            this.label3.Text = "Номер турніру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Команда";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Cancel.Location = new System.Drawing.Point(281, 382);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(233, 51);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "ВІДМІНА";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Спортсмен";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_OK.Location = new System.Drawing.Point(11, 382);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(237, 51);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // comboBox_Sportsmen
            // 
            this.comboBox_Sportsmen.DataSource = this.спортсменBindingSource;
            this.comboBox_Sportsmen.DisplayMember = "ПІБ";
            this.comboBox_Sportsmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sportsmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Sportsmen.FormattingEnabled = true;
            this.comboBox_Sportsmen.Location = new System.Drawing.Point(281, 80);
            this.comboBox_Sportsmen.Name = "comboBox_Sportsmen";
            this.comboBox_Sportsmen.Size = new System.Drawing.Size(226, 30);
            this.comboBox_Sportsmen.TabIndex = 0;
            this.comboBox_Sportsmen.ValueMember = "id_Спортсмена";
            // 
            // спортсменBindingSource
            // 
            this.спортсменBindingSource.DataMember = "Спортсмен";
            this.спортсменBindingSource.DataSource = this.sportMainDataSet;
            // 
            // sportMainDataSet
            // 
            this.sportMainDataSet.DataSetName = "SportMainDataSet";
            this.sportMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Komanda
            // 
            this.comboBox_Komanda.DataSource = this.командаBindingSource;
            this.comboBox_Komanda.DisplayMember = "Назва";
            this.comboBox_Komanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Komanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Komanda.FormattingEnabled = true;
            this.comboBox_Komanda.Location = new System.Drawing.Point(281, 158);
            this.comboBox_Komanda.Name = "comboBox_Komanda";
            this.comboBox_Komanda.Size = new System.Drawing.Size(226, 30);
            this.comboBox_Komanda.TabIndex = 1;
            this.comboBox_Komanda.ValueMember = "id_Команди";
            // 
            // командаBindingSource
            // 
            this.командаBindingSource.DataMember = "Команда";
            this.командаBindingSource.DataSource = this.sportMainDataSet;
            // 
            // comboBox_Tournir
            // 
            this.comboBox_Tournir.DataSource = this.турнірBindingSource;
            this.comboBox_Tournir.DisplayMember = "id_Турніру";
            this.comboBox_Tournir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tournir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Tournir.FormattingEnabled = true;
            this.comboBox_Tournir.Location = new System.Drawing.Point(281, 242);
            this.comboBox_Tournir.Name = "comboBox_Tournir";
            this.comboBox_Tournir.Size = new System.Drawing.Size(226, 30);
            this.comboBox_Tournir.TabIndex = 2;
            this.comboBox_Tournir.ValueMember = "id_Турніру";
            // 
            // турнірBindingSource
            // 
            this.турнірBindingSource.DataMember = "Турнір";
            this.турнірBindingSource.DataSource = this.sportMainDataSet;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.sportMainDataSet;
            this.bindingSource1.Position = 0;
            // 
            // спорткомітетTableAdapter
            // 
            this.спорткомітетTableAdapter.ClearBeforeFill = true;
            // 
            // спортсменTableAdapter
            // 
            this.спортсменTableAdapter.ClearBeforeFill = true;
            // 
            // командаTableAdapter
            // 
            this.командаTableAdapter.ClearBeforeFill = true;
            // 
            // турнірTableAdapter
            // 
            this.турнірTableAdapter.ClearBeforeFill = true;
            // 
            // результатСпортсменаBindingSource
            // 
            this.результатСпортсменаBindingSource.DataMember = "Результат_Спортсмена";
            this.результатСпортсменаBindingSource.DataSource = this.sportMainDataSet;
            // 
            // результат_СпортсменаTableAdapter
            // 
            this.результат_СпортсменаTableAdapter.ClearBeforeFill = true;
            // 
            // EditFormSportcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 478);
            this.Controls.Add(this.comboBox_Tournir);
            this.Controls.Add(this.comboBox_Komanda);
            this.Controls.Add(this.comboBox_Sportsmen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OK);
            this.Name = "EditFormSportcom";
            this.Text = "EditFormSportcom";
            this.Load += new System.EventHandler(this.EditFormSportcom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.спортсменBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportMainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.турнірBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.результатСпортсменаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox_Sportsmen;
        private System.Windows.Forms.ComboBox comboBox_Komanda;
        private System.Windows.Forms.ComboBox comboBox_Tournir;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SportMainDataSet sportMainDataSet;
        private SportMainDataSetTableAdapters.СпорткомітетTableAdapter спорткомітетTableAdapter;
        private System.Windows.Forms.BindingSource спортсменBindingSource;
        private SportMainDataSetTableAdapters.СпортсменTableAdapter спортсменTableAdapter;
        private System.Windows.Forms.BindingSource командаBindingSource;
        private SportMainDataSetTableAdapters.КомандаTableAdapter командаTableAdapter;
        private System.Windows.Forms.BindingSource турнірBindingSource;
        private SportMainDataSetTableAdapters.ТурнірTableAdapter турнірTableAdapter;
        private System.Windows.Forms.BindingSource результатСпортсменаBindingSource;
        private SportMainDataSetTableAdapters.Результат_СпортсменаTableAdapter результат_СпортсменаTableAdapter;
    }
}