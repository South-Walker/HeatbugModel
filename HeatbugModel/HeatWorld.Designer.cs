namespace HeatbugModel
{
    partial class HeatWorld
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbHeatWorld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeatWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHeatWorld
            // 
            this.pbHeatWorld.Location = new System.Drawing.Point(0, 0);
            this.pbHeatWorld.Name = "pbHeatWorld";
            this.pbHeatWorld.Size = new System.Drawing.Size(320, 320);
            this.pbHeatWorld.TabIndex = 0;
            this.pbHeatWorld.TabStop = false;
            // 
            // HeatWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 321);
            this.Controls.Add(this.pbHeatWorld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HeatWorld";
            this.Text = "HeatWorld";
            this.Load += new System.EventHandler(this.HeatWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeatWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeatWorld;
    }
}

