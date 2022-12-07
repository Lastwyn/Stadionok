namespace Stadionok
{
    partial class modositstadion
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
            this.textBox_varos = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_ferohely = new System.Windows.Forms.TextBox();
            this.textBox_epult = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_modosit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_varos
            // 
            this.textBox_varos.Location = new System.Drawing.Point(389, 107);
            this.textBox_varos.Name = "textBox_varos";
            this.textBox_varos.Size = new System.Drawing.Size(126, 20);
            this.textBox_varos.TabIndex = 22;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(135, 132);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(124, 20);
            this.textBox_nev.TabIndex = 21;
            // 
            // textBox_ferohely
            // 
            this.textBox_ferohely.Location = new System.Drawing.Point(136, 181);
            this.textBox_ferohely.Name = "textBox_ferohely";
            this.textBox_ferohely.Size = new System.Drawing.Size(123, 20);
            this.textBox_ferohely.TabIndex = 19;
            // 
            // textBox_epult
            // 
            this.textBox_epult.Location = new System.Drawing.Point(389, 162);
            this.textBox_epult.Name = "textBox_epult";
            this.textBox_epult.Size = new System.Drawing.Size(126, 20);
            this.textBox_epult.TabIndex = 20;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(136, 85);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(79, 20);
            this.textBox_id.TabIndex = 18;
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(206, 252);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(177, 41);
            this.button_modosit.TabIndex = 17;
            this.button_modosit.Text = "Móddosítás";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(202, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stadion módosítása";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amikor épült:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Város ahol van:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Férőhely:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stadion neve:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id:";
            // 
            // modositstadion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(575, 334);
            this.Controls.Add(this.textBox_varos);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_ferohely);
            this.Controls.Add(this.textBox_epult);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modositstadion";
            this.Text = "Stadion módosítása";
            this.Load += new System.EventHandler(this.modositstadion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_varos;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.TextBox textBox_ferohely;
        public System.Windows.Forms.TextBox textBox_epult;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}