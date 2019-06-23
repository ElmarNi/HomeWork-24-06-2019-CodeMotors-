namespace CodeMotors
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewModelToolStripMenuItem,
            this.createNewBrandToolStripMenuItem,
            this.createNewCarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createNewModelToolStripMenuItem
            // 
            this.createNewModelToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.createNewModelToolStripMenuItem.Name = "createNewModelToolStripMenuItem";
            this.createNewModelToolStripMenuItem.Size = new System.Drawing.Size(209, 27);
            this.createNewModelToolStripMenuItem.Text = "Create new model";
            // 
            // createNewBrandToolStripMenuItem
            // 
            this.createNewBrandToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.createNewBrandToolStripMenuItem.Name = "createNewBrandToolStripMenuItem";
            this.createNewBrandToolStripMenuItem.Size = new System.Drawing.Size(207, 27);
            this.createNewBrandToolStripMenuItem.Text = "Create new brand";
            // 
            // createNewCarToolStripMenuItem
            // 
            this.createNewCarToolStripMenuItem.AccessibleDescription = "";
            this.createNewCarToolStripMenuItem.AccessibleName = "";
            this.createNewCarToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.createNewCarToolStripMenuItem.Name = "createNewCarToolStripMenuItem";
            this.createNewCarToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.createNewCarToolStripMenuItem.Size = new System.Drawing.Size(180, 27);
            this.createNewCarToolStripMenuItem.Text = "Create new car";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNewModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCarToolStripMenuItem;
    }
}

