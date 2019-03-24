namespace CursovaSys
{
    partial class Stat
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
            this.dataGridView_Zvit = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_LichDelo = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Numer = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zvit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Zvit
            // 
            this.dataGridView_Zvit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Zvit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Zvit.Location = new System.Drawing.Point(12, 357);
            this.dataGridView_Zvit.Name = "dataGridView_Zvit";
            this.dataGridView_Zvit.RowTemplate.Height = 24;
            this.dataGridView_Zvit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Zvit.Size = new System.Drawing.Size(1090, 316);
            this.dataGridView_Zvit.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(655, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кількість спортсменів на турнірах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(655, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Турнір та місцезнаходженя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_LichDelo
            // 
            this.button_LichDelo.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_LichDelo.Location = new System.Drawing.Point(12, 178);
            this.button_LichDelo.Name = "button_LichDelo";
            this.button_LichDelo.Size = new System.Drawing.Size(329, 132);
            this.button_LichDelo.TabIndex = 2;
            this.button_LichDelo.Text = "Учасники турнірів індивідуальних видів спорту";
            this.button_LichDelo.UseVisualStyleBackColor = true;
            this.button_LichDelo.Click += new System.EventHandler(this.button_LichDelo_Click);
            // 
            // button_Print
            // 
            this.button_Print.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Print.Location = new System.Drawing.Point(781, 22);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(321, 79);
            this.button_Print.TabIndex = 4;
            this.button_Print.Text = "Експорт в Excel";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 41);
            this.label1.TabIndex = 27;
            this.label1.Text = "Звіт №:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_ID.ForeColor = System.Drawing.Color.Black;
            this.textBox_ID.Location = new System.Drawing.Point(150, 313);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(97, 35);
            this.textBox_ID.TabIndex = 28;
            // 
            // label_Numer
            // 
            this.label_Numer.AutoSize = true;
            this.label_Numer.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.label_Numer.Location = new System.Drawing.Point(1027, 357);
            this.label_Numer.Name = "label_Numer";
            this.label_Numer.Size = new System.Drawing.Size(75, 41);
            this.label_Numer.TabIndex = 29;
            this.label_Numer.Text = "null";
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button_Send.Location = new System.Drawing.Point(673, 119);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(420, 184);
            this.button_Send.TabIndex = 5;
            this.button_Send.Text = "Розсилка листів";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CursovaSys.Properties.Resources.origin;
            this.pictureBox7.Location = new System.Drawing.Point(673, 22);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 79);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(347, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 132);
            this.button3.TabIndex = 3;
            this.button3.Text = "Учасники турнірів командних видів спорту";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1114, 685);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.dataGridView_Zvit);
            this.Controls.Add(this.label_Numer);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_LichDelo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(1033, 692);
            this.Name = "Stat";
            this.Text = "Stat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zvit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Zvit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_LichDelo;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Numer;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button3;
    }
}