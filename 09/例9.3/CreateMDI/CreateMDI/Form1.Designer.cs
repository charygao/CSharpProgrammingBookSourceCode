namespace CreateMDI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.子窗体1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.子窗体2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.子窗体1ToolStripMenuItem,
            this.子窗体2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 子窗体1ToolStripMenuItem
            // 
            this.子窗体1ToolStripMenuItem.Name = "子窗体1ToolStripMenuItem";
            this.子窗体1ToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.子窗体1ToolStripMenuItem.Text = "子窗体1";
            this.子窗体1ToolStripMenuItem.Click += new System.EventHandler(this.子窗体1ToolStripMenuItem_Click);
            // 
            // 子窗体2ToolStripMenuItem
            // 
            this.子窗体2ToolStripMenuItem.Name = "子窗体2ToolStripMenuItem";
            this.子窗体2ToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.子窗体2ToolStripMenuItem.Text = "子窗体2";
            this.子窗体2ToolStripMenuItem.Click += new System.EventHandler(this.子窗体2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 181);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "父窗体";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 子窗体1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 子窗体2ToolStripMenuItem;
    }
}

