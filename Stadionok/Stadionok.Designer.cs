namespace Stadionok
{
    partial class Stadionok
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újStadionBeviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadionMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadionTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Stadionok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újStadionBeviteleToolStripMenuItem,
            this.stadionMódosításaToolStripMenuItem,
            this.stadionTörléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újStadionBeviteleToolStripMenuItem
            // 
            this.újStadionBeviteleToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.újStadionBeviteleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.újStadionBeviteleToolStripMenuItem.Name = "újStadionBeviteleToolStripMenuItem";
            this.újStadionBeviteleToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.újStadionBeviteleToolStripMenuItem.Text = "Új Stadion bevitele";
            this.újStadionBeviteleToolStripMenuItem.Click += new System.EventHandler(this.újStadionBeviteleToolStripMenuItem_Click);
            // 
            // stadionMódosításaToolStripMenuItem
            // 
            this.stadionMódosításaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stadionMódosításaToolStripMenuItem.Name = "stadionMódosításaToolStripMenuItem";
            this.stadionMódosításaToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.stadionMódosításaToolStripMenuItem.Text = "Stadion módosítása";
            this.stadionMódosításaToolStripMenuItem.Click += new System.EventHandler(this.stadionMódosításaToolStripMenuItem_Click);
            // 
            // stadionTörléseToolStripMenuItem
            // 
            this.stadionTörléseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stadionTörléseToolStripMenuItem.Name = "stadionTörléseToolStripMenuItem";
            this.stadionTörléseToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.stadionTörléseToolStripMenuItem.Text = "Stadion törlése";
            this.stadionTörléseToolStripMenuItem.Click += new System.EventHandler(this.stadionTörléseToolStripMenuItem_Click);
            // 
            // listBox_Stadionok
            // 
            this.listBox_Stadionok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox_Stadionok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_Stadionok.FormattingEnabled = true;
            this.listBox_Stadionok.ItemHeight = 16;
            this.listBox_Stadionok.Location = new System.Drawing.Point(0, 142);
            this.listBox_Stadionok.Name = "listBox_Stadionok";
            this.listBox_Stadionok.Size = new System.Drawing.Size(800, 308);
            this.listBox_Stadionok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(284, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stadionok adatai:";
            // 
            // Stadionok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Stadionok);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Stadionok";
            this.Text = "Stadionok";
            this.Load += new System.EventHandler(this.Stadionok_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újStadionBeviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadionMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadionTörléseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox_Stadionok;
    }
}

