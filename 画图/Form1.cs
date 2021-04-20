using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 画图
{
    public partial class Form1 : Form
    {
        string filePath = "$";   //默认文件目录，空
        Color color = Color.Black;  //默认颜色，黑
        bool isDrawing = false;   //判断是否正在画图
        Point oldPoint;    //记录鼠标画图时的老坐标
        Point startPoint;   //记录鼠标画图时的开始坐标
        bool isSave = true;  //标记文件是否保存

        Graphics g;
        Pen p;
        enum toolBox
        {
            mouse,pen,earser,line,circle,rectangle,triangle
        };
        toolBox drawTool = toolBox.pen; //默认初始为画笔工具
        public Form1()
        {
            InitializeComponent();
            this.Text = "Rabbit House的记事板";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = paint.CreateGraphics();

            p = new Pen(Color.Black);

            brush1.Checked = true;    //设置默认工具大小为1

            铅笔ToolStripMenuItem.Checked = true;


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if(drawTool!=toolBox.mouse)
                {
                    isSave = false;
                }
                isDrawing = true;  //正在画图
                oldPoint = new Point(e.X, e.Y);
                startPoint = oldPoint;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                
                Point mousepoint = new Point(e.X, e.Y);
                switch(drawTool)
                {
                    case toolBox.pen:
                        g.DrawLine(p, oldPoint, mousepoint);
                        oldPoint = mousepoint;
                        break;
                    case toolBox.earser:
                        p.Color = Color.White;
                        g.DrawLine(p, oldPoint, mousepoint);
                        oldPoint = mousepoint;
                        break;
                    default:
                        oldPoint = mousepoint;
                        break;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                switch (drawTool)
                {
                    case toolBox.line:
                        g.DrawLine(p, startPoint, oldPoint);
                        break;
                    case toolBox.rectangle:
                        g.DrawRectangle(p, startPoint.X, startPoint.Y, 
                            oldPoint.X - startPoint.X, oldPoint.Y - startPoint.Y);
                        break;
                    case toolBox.circle:
                        g.DrawEllipse(p, startPoint.X, startPoint.Y, 
                            oldPoint.X - startPoint.X, oldPoint.Y - startPoint.Y);
                        break;
                    case toolBox.triangle:
                        Point point1 = new Point((startPoint.X + oldPoint.X) / 2, startPoint.Y);  //三角形的顶点之一
                        Point point2 = new Point(startPoint.X, oldPoint.Y);
                        Point[] points = { point1, point2, oldPoint };
                        g.DrawLine(p, point1, oldPoint);
                        g.DrawLines(p, points);
                        break;
                }
            }
            isDrawing = false;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                p.Color = colorDialog.Color;
            }
        }

        private void 橡皮擦ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = true;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            圆ToolStripMenuItem.Checked = false;
            矩形ToolStripMenuItem.Checked = false;
            三角形ToolStripMenuItem.Checked = false;
            drawTool = toolBox.earser;
        }

        private void 直线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = false;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = true;
            圆ToolStripMenuItem.Checked = false;
            矩形ToolStripMenuItem.Checked = false;
            三角形ToolStripMenuItem.Checked = false;
            drawTool = toolBox.line;
        }

        private void 圆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = false;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            圆ToolStripMenuItem.Checked = true;
            矩形ToolStripMenuItem.Checked = false;
            三角形ToolStripMenuItem.Checked = false;
            drawTool = toolBox.circle;
        }

        private void 矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = false;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            圆ToolStripMenuItem.Checked = false;
            矩形ToolStripMenuItem.Checked = true;
            三角形ToolStripMenuItem.Checked = false;
            drawTool = toolBox.rectangle;
        }

        private void 三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = false;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            圆ToolStripMenuItem.Checked = false;
            矩形ToolStripMenuItem.Checked = false;
            三角形ToolStripMenuItem.Checked =true;
            drawTool = toolBox.triangle;
        }

        private void brush1_Click(object sender, EventArgs e)
        {
            brush1.Checked = true;
            brush2.Checked = false;
            brush4.Checked = false;
            brush8.Checked = false;
            p.Width = 1;
        }

        private void brush2_Click(object sender, EventArgs e)
        {
            brush1.Checked = false;
            brush2.Checked = true;
            brush4.Checked = false;
            brush8.Checked = false;
            p.Width = 2;
        }

        private void brush4_Click(object sender, EventArgs e)
        {
            brush1.Checked = false;
            brush2.Checked = false;
            brush4.Checked = true;
            brush8.Checked = false;
            p.Width = 4;
        }

        private void brush8_Click(object sender, EventArgs e)
        {
            brush1.Checked = false;
            brush2.Checked = false;
            brush4.Checked = false;
            brush8.Checked = true;
            p.Width = 8;
        }

        private void 铅笔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            橡皮擦ToolStripMenuItem.Checked = true;
            铅笔ToolStripMenuItem.Checked = false;
            直线ToolStripMenuItem.Checked = false;
            圆ToolStripMenuItem.Checked = false;
            矩形ToolStripMenuItem.Checked = false;
            三角形ToolStripMenuItem.Checked = false;
            drawTool = toolBox.pen;
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave == true)
            {
                g.Clear(Color.White);     //重置画图板
            }
            else
            {
                string name = this.Text;
                DialogResult result = MessageBox.Show("                  是否将更改保存到" + name, "RabbitHouse记事本", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:         //执行保存操作
                        保存ToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.No:                  //重置画板
                        g.Clear(Color.White);
                        isSave = true;
                        break;
                    case DialogResult.Cancel:               //取消什么都不做
                        break;
                }
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  //默认桌面作为打开文件路径
                openFileDialog.Filter = "PNG(*.png)|*.png | GIF(*.gif)|*.gif | ICO(*.ico)|*.ico | JPEG(*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*jpeg;*jpe;*jfif | 所有图片文件|*.png;*.gif;*.bmp;*.wmf;*.ico;*.cur;*.jpg;*.jpeg;*.jpe*,jfif  | 所有文件(.)|*.*";
                openFileDialog.FilterIndex = 5;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Bitmap.FromFile(openFileDialog.FileName);
                    g.DrawImage(image, this.ClientRectangle);
                    this.Text = openFileDialog.FileName.Substring(openFileDialog.FileName.IndexOf("//") + 1);
                    filePath = openFileDialog.FileName;
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "$")
            {
                isSave = true;
                paint.Image.Save(filePath);
            }
            else
            {
                另存为ToolStripMenuItem_Click(sender, e);
            }
                
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG(*.png)|*.png | GIF(*.gif)|*.gif | JPEG(*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg";
            saveFileDialog.FilterIndex = 3;
            Bitmap bitmat = paint.Image as Bitmap;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pictureName = saveFileDialog.FileName;
                try
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        //这句很重要，不然不能正确保存图片或出错（关键就这一句）
                        Bitmap bmp = new Bitmap(paint.Image);
                        //保存到磁盘文件
                        bmp.Save(@pictureName, paint.Image.RawFormat);
                        bmp.Dispose();
                        MessageBox.Show("附件另存成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //将image作为流数据进行保存
                    MemoryStream mstream = new MemoryStream();
                    if (saveFileDialog.FilterIndex == 1)
                        paint.Image.Save(filePath, ImageFormat.Png);
                    else if (saveFileDialog.FilterIndex == 2)
                        paint.Image.Save(filePath, ImageFormat.Gif);
                    else if (saveFileDialog.FilterIndex == 3)
                        paint.Image.Save(filePath, ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("保存失败！");
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此软件由KafuuChino开发，版权归RabbitHouse©所有,仅用于Windows体系编程实验验收");
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.ShowDialog();
        }
    }
}
