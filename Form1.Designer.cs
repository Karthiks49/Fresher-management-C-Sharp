namespace FreshersInfo
{
    partial class Fresher
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
            this.createOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOption = new System.Windows.Forms.ToolStripMenuItem();
            this.exitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOption,
            this.viewOption,
            this.exitOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createOption
            // 
            this.createOption.Name = "createOption";
            this.createOption.Size = new System.Drawing.Size(66, 24);
            this.createOption.Text = "Create";
            this.createOption.Click += new System.EventHandler(this.createOption_Click);
            // 
            // viewOption
            // 
            this.viewOption.Name = "viewOption";
            this.viewOption.Size = new System.Drawing.Size(59, 24);
            this.viewOption.Text = "View ";
            this.viewOption.Click += new System.EventHandler(this.viewOption_Click);
            // 
            // exitOption
            // 
            this.exitOption.Name = "exitOption";
            this.exitOption.Size = new System.Drawing.Size(47, 24);
            this.exitOption.Text = "Exit";
            this.exitOption.Click += new System.EventHandler(this.exitOption_Click_1);
            // 
            // Fresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1263, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fresher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRESHER MANAGEMENT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createOption;
        private System.Windows.Forms.ToolStripMenuItem viewOption;
        private System.Windows.Forms.ToolStripMenuItem exitOption;
    }
}

