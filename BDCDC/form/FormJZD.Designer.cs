namespace BDCDC.form
{
    partial class FormJZD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJZD));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.b_import_from_cad = new System.Windows.Forms.ToolStripButton();
            this.b_import_from_shape = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.b_add_jzd = new System.Windows.Forms.ToolStripButton();
            this.b_delete_jzd = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.b_import_from_excel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_import_from_cad,
            this.b_import_from_shape,
            this.b_import_from_excel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1245, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // b_import_from_cad
            // 
            this.b_import_from_cad.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_cad.Image")));
            this.b_import_from_cad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_cad.Name = "b_import_from_cad";
            this.b_import_from_cad.Size = new System.Drawing.Size(90, 44);
            this.b_import_from_cad.Text = "从CAD导入";
            this.b_import_from_cad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_import_from_shape
            // 
            this.b_import_from_shape.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_shape.Image")));
            this.b_import_from_shape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_shape.Name = "b_import_from_shape";
            this.b_import_from_shape.Size = new System.Drawing.Size(88, 44);
            this.b_import_from_shape.Text = "从宗地提取";
            this.b_import_from_shape.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(1245, 717);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_add_jzd,
            this.b_delete_jzd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1245, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // b_add_jzd
            // 
            this.b_add_jzd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_add_jzd.Image = ((System.Drawing.Image)(resources.GetObject("b_add_jzd.Image")));
            this.b_add_jzd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_add_jzd.Name = "b_add_jzd";
            this.b_add_jzd.Size = new System.Drawing.Size(24, 24);
            this.b_add_jzd.Text = "toolStripButton1";
            // 
            // b_delete_jzd
            // 
            this.b_delete_jzd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_delete_jzd.Image = ((System.Drawing.Image)(resources.GetObject("b_delete_jzd.Image")));
            this.b_delete_jzd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_delete_jzd.Name = "b_delete_jzd";
            this.b_delete_jzd.Size = new System.Drawing.Size(24, 24);
            this.b_delete_jzd.Text = "toolStripButton1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1245, 360);
            this.dataGridView2.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1245, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // b_import_from_excel
            // 
            this.b_import_from_excel.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_excel.Image")));
            this.b_import_from_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_excel.Name = "b_import_from_excel";
            this.b_import_from_excel.Size = new System.Drawing.Size(118, 44);
            this.b_import_from_excel.Text = "导入界址点成果";
            this.b_import_from_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FormJZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 764);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormJZD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "界址点成果";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton b_import_from_cad;
        private System.Windows.Forms.ToolStripButton b_import_from_shape;
        private System.Windows.Forms.ToolStripButton b_add_jzd;
        private System.Windows.Forms.ToolStripButton b_delete_jzd;
        private System.Windows.Forms.ToolStripButton b_import_from_excel;
    }
}