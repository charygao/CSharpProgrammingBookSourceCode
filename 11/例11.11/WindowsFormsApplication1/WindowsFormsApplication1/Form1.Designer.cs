namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "20081014_66a5e6091b1fd1b5c73a47dXJagoM2LQ.jpg");
            this.imageList1.Images.SetKeyName(1, "20081014_16decbfaaaf7624d35f8K1d34MaRpcy5.jpg");
            this.imageList1.Images.SetKeyName(2, "20081014_19d32cae0bc871069cf47e1NEy5YtNuo.jpg");
            this.imageList1.Images.SetKeyName(3, "20081014_27b4b25c1d198fabd4c4UUUFp01z08Uw.jpg");
            this.imageList1.Images.SetKeyName(4, "20081014_37c9e2344cdb494e49b9bHmoKXwPJ6pA.jpg");
            this.imageList1.Images.SetKeyName(5, "20081014_57c926bdf2012079eea0vH44iicAcRUe.jpg");
            this.imageList1.Images.SetKeyName(6, "20081014_57f5f68fddb76927c2e7STMazfSpQUFO.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(115, 82);
            this.Name = "Form1";
            this.Text = "显示图像列表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;

    }
}

