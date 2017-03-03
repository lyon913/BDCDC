namespace BDCDC.form
{
    partial class FormLayerSelect
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
            this.cb_layers = new System.Windows.Forms.ComboBox();
            this.bt_selected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_layers
            // 
            this.cb_layers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_layers.FormattingEnabled = true;
            this.cb_layers.Location = new System.Drawing.Point(92, 45);
            this.cb_layers.Name = "cb_layers";
            this.cb_layers.Size = new System.Drawing.Size(188, 20);
            this.cb_layers.TabIndex = 0;
            // 
            // bt_selected
            // 
            this.bt_selected.Location = new System.Drawing.Point(92, 102);
            this.bt_selected.Name = "bt_selected";
            this.bt_selected.Size = new System.Drawing.Size(75, 23);
            this.bt_selected.TabIndex = 1;
            this.bt_selected.Text = "选择";
            this.bt_selected.UseVisualStyleBackColor = true;
            this.bt_selected.Click += new System.EventHandler(this.bt_selected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图层：";
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(186, 102);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // FormLayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 168);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_selected);
            this.Controls.Add(this.cb_layers);
            this.Name = "FormLayerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图层选择";
            this.Load += new System.EventHandler(this.FormLayerSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_layers;
        private System.Windows.Forms.Button bt_selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_close;
    }
}