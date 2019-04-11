namespace WindowsServiceClient
{
    partial class StartForm
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
            this.install = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.uninstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(12, 30);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(75, 23);
            this.install.TabIndex = 0;
            this.install.Text = "安装服务";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(103, 30);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "启动服务";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(195, 30);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "停止服务";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // uninstall
            // 
            this.uninstall.Location = new System.Drawing.Point(295, 30);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(75, 23);
            this.uninstall.TabIndex = 3;
            this.uninstall.Text = "卸载服务";
            this.uninstall.UseVisualStyleBackColor = true;
            this.uninstall.Click += new System.EventHandler(this.uninstall_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 86);
            this.Controls.Add(this.uninstall);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.install);
            this.Name = "StartForm";
            this.Text = "服务窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button uninstall;
    }
}

