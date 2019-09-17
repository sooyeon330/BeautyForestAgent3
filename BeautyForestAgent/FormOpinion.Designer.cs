namespace BeautyForestAgent
{
    partial class FormOpinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpinion));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tbsFont = new System.Windows.Forms.ToolStripButton();
            this.tbsColor = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 261);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(462, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsMenu
            // 
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsFont,
            this.tbsColor});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(462, 25);
            this.tlsMenu.TabIndex = 1;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "3616 채수연";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(462, 236);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = resources.GetString("rtbText.Text");
            // 
            // tbsFont
            // 
            this.tbsFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsFont.Image = ((System.Drawing.Image)(resources.GetObject("tbsFont.Image")));
            this.tbsFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsFont.Name = "tbsFont";
            this.tbsFont.Size = new System.Drawing.Size(23, 22);
            this.tbsFont.Text = "toolStripButton1";
            this.tbsFont.Click += new System.EventHandler(this.TbsFont_Click);
            // 
            // tbsColor
            // 
            this.tbsColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsColor.Image = ((System.Drawing.Image)(resources.GetObject("tbsColor.Image")));
            this.tbsColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsColor.Name = "tbsColor";
            this.tbsColor.Size = new System.Drawing.Size(23, 22);
            this.tbsColor.Text = "toolStripButton1";
            this.tbsColor.Click += new System.EventHandler(this.TbsColor_Click);
            // 
            // FormOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 283);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOpinion";
            this.Text = "3616채수연";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.ToolStripButton tbsFont;
        private System.Windows.Forms.ToolStripButton tbsColor;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}