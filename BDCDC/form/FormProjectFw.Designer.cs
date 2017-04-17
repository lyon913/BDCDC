namespace BDCDC.form
{
    partial class FormProjectFw
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
            this.tv = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.集体土地房屋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_create_ljz = new System.Windows.Forms.ToolStripMenuItem();
            this.create_h = new System.Windows.Forms.ToolStripMenuItem();
            this.国有建设用地房屋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fwlz = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv.Location = new System.Drawing.Point(0, 25);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(243, 536);
            this.tv.TabIndex = 1;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(243, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 536);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.集体土地房屋ToolStripMenuItem,
            this.国有建设用地房屋ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 集体土地房屋ToolStripMenuItem
            // 
            this.集体土地房屋ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_create_ljz,
            this.create_h});
            this.集体土地房屋ToolStripMenuItem.Name = "集体土地房屋ToolStripMenuItem";
            this.集体土地房屋ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.集体土地房屋ToolStripMenuItem.Text = "集体土地房屋";
            // 
            // m_create_ljz
            // 
            this.m_create_ljz.Name = "m_create_ljz";
            this.m_create_ljz.Size = new System.Drawing.Size(152, 22);
            this.m_create_ljz.Text = "新建逻辑幢";
            this.m_create_ljz.Click += new System.EventHandler(this.m_create_ljz_Click);
            // 
            // create_h
            // 
            this.create_h.Name = "create_h";
            this.create_h.Size = new System.Drawing.Size(152, 22);
            this.create_h.Text = "新建户";
            this.create_h.Click += new System.EventHandler(this.create_h_Click);
            // 
            // 国有建设用地房屋ToolStripMenuItem
            // 
            this.国有建设用地房屋ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fwlz});
            this.国有建设用地房屋ToolStripMenuItem.Name = "国有建设用地房屋ToolStripMenuItem";
            this.国有建设用地房屋ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.国有建设用地房屋ToolStripMenuItem.Text = "国有建设用地房屋";
            // 
            // m_fwlz
            // 
            this.m_fwlz.Name = "m_fwlz";
            this.m_fwlz.Size = new System.Drawing.Size(152, 22);
            this.m_fwlz.Text = "房屋落宗";
            this.m_fwlz.Click += new System.EventHandler(this.m_fwlz_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(691, 536);
            this.dgv.TabIndex = 0;
            // 
            // FormProjectFw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProjectFw";
            this.Text = "房屋调查成果";
            this.Load += new System.EventHandler(this.FormProjectFw_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 集体土地房屋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_create_ljz;
        private System.Windows.Forms.ToolStripMenuItem create_h;
        private System.Windows.Forms.ToolStripMenuItem 国有建设用地房屋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_fwlz;
        private System.Windows.Forms.DataGridView dgv;
    }
}