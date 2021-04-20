namespace 画图
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.铅笔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.橡皮擦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.形状ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粗细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brush1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brush2 = new System.Windows.Forms.ToolStripMenuItem();
            this.brush4 = new System.Windows.Forms.ToolStripMenuItem();
            this.brush8 = new System.Windows.Forms.ToolStripMenuItem();
            this.paint = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paint)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.形状ToolStripMenuItem,
            this.粗细ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.铅笔ToolStripMenuItem,
            this.橡皮擦ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 铅笔ToolStripMenuItem
            // 
            this.铅笔ToolStripMenuItem.Name = "铅笔ToolStripMenuItem";
            this.铅笔ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.铅笔ToolStripMenuItem.Text = "铅笔";
            this.铅笔ToolStripMenuItem.Click += new System.EventHandler(this.铅笔ToolStripMenuItem_Click);
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            this.橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            this.橡皮擦ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            this.橡皮擦ToolStripMenuItem.Click += new System.EventHandler(this.橡皮擦ToolStripMenuItem_Click);
            // 
            // 形状ToolStripMenuItem
            // 
            this.形状ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直线ToolStripMenuItem,
            this.圆ToolStripMenuItem,
            this.矩形ToolStripMenuItem,
            this.三角形ToolStripMenuItem});
            this.形状ToolStripMenuItem.Name = "形状ToolStripMenuItem";
            this.形状ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.形状ToolStripMenuItem.Text = "形状";
            // 
            // 直线ToolStripMenuItem
            // 
            this.直线ToolStripMenuItem.Name = "直线ToolStripMenuItem";
            this.直线ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.直线ToolStripMenuItem.Text = "直线";
            this.直线ToolStripMenuItem.Click += new System.EventHandler(this.直线ToolStripMenuItem_Click);
            // 
            // 圆ToolStripMenuItem
            // 
            this.圆ToolStripMenuItem.Name = "圆ToolStripMenuItem";
            this.圆ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.圆ToolStripMenuItem.Text = "圆";
            this.圆ToolStripMenuItem.Click += new System.EventHandler(this.圆ToolStripMenuItem_Click);
            // 
            // 矩形ToolStripMenuItem
            // 
            this.矩形ToolStripMenuItem.Name = "矩形ToolStripMenuItem";
            this.矩形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.矩形ToolStripMenuItem.Text = "矩形";
            this.矩形ToolStripMenuItem.Click += new System.EventHandler(this.矩形ToolStripMenuItem_Click);
            // 
            // 三角形ToolStripMenuItem
            // 
            this.三角形ToolStripMenuItem.Name = "三角形ToolStripMenuItem";
            this.三角形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.三角形ToolStripMenuItem.Text = "三角形";
            this.三角形ToolStripMenuItem.Click += new System.EventHandler(this.三角形ToolStripMenuItem_Click);
            // 
            // 粗细ToolStripMenuItem
            // 
            this.粗细ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brush1,
            this.brush2,
            this.brush4,
            this.brush8});
            this.粗细ToolStripMenuItem.Name = "粗细ToolStripMenuItem";
            this.粗细ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.粗细ToolStripMenuItem.Text = "粗细";
            // 
            // brush1
            // 
            this.brush1.Name = "brush1";
            this.brush1.Size = new System.Drawing.Size(93, 26);
            this.brush1.Text = "1";
            this.brush1.Click += new System.EventHandler(this.brush1_Click);
            // 
            // brush2
            // 
            this.brush2.Name = "brush2";
            this.brush2.Size = new System.Drawing.Size(93, 26);
            this.brush2.Text = "2";
            this.brush2.Click += new System.EventHandler(this.brush2_Click);
            // 
            // brush4
            // 
            this.brush4.Name = "brush4";
            this.brush4.Size = new System.Drawing.Size(93, 26);
            this.brush4.Text = "4";
            this.brush4.Click += new System.EventHandler(this.brush4_Click);
            // 
            // brush8
            // 
            this.brush8.Name = "brush8";
            this.brush8.Size = new System.Drawing.Size(93, 26);
            this.brush8.Text = "8";
            this.brush8.Click += new System.EventHandler(this.brush8_Click);
            // 
            // paint
            // 
            this.paint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paint.Location = new System.Drawing.Point(0, 31);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(1046, 422);
            this.paint.TabIndex = 1;
            this.paint.TabStop = false;
            this.paint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.paint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.paint);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 铅笔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 形状ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粗细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brush1;
        private System.Windows.Forms.ToolStripMenuItem brush2;
        private System.Windows.Forms.ToolStripMenuItem brush4;
        private System.Windows.Forms.ToolStripMenuItem brush8;
        private System.Windows.Forms.PictureBox paint;
    }
}

