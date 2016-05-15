using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using point = System.Windows.Point;

namespace MO_4._1
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pic1.Size.Width, pic1.Size.Height);
            label6.Visible = false;
            alpha.Visible = false;
            label13.Visible = false;
            m.Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double _EPS1, _EPS2, _P, _alpha;
            int N;
            point x_0 = new point();
            x_0.X = Convert.ToDouble(x0_x.Text);
            x_0.Y = Convert.ToDouble(x0_y.Text);
            point x_1 = new point();
            x_1.X = Convert.ToDouble(x1_x.Text);
            x_1.Y = Convert.ToDouble(x1_y.Text);
            _EPS1 = Convert.ToDouble(eps_x.Text);
            _EPS2 = Convert.ToDouble(eps_y.Text);
            point result;
            Graphics g = Graphics.FromImage(bmp);
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    _P = Convert.ToDouble(p.Text);
                    rand_search A = new rand_search();
                    label5.Visible = true;
                    p.Visible = true;
                    result = A.DoAlgorithm(x_0, x_1, _EPS1, _EPS2, _P);
                    xmin_x1.Text = Convert.ToString(result.X);
                    xmin_y1.Text = Convert.ToString(result.Y);
                    f1.Text = Convert.ToString(A.Function(result));
                    iter1.Text = Convert.ToString(A.countCalc);
                    drawPoints(A.PVector, x_0, x_1, result);
                    break;
                case 1:
                    _alpha = Convert.ToDouble(alpha.Text);
                    N = Convert.ToInt32(m.Text);
                    label5.Visible = false;
                    p.Visible = false;
                    best_sample B = new best_sample();
                    result = B.DoAlgorithm(x_0, x_1, _EPS1, _EPS2, _alpha, N);
                    xmin_x2.Text = Convert.ToString(result.X);
                    xmin_y2.Text = Convert.ToString(result.Y);
                    f2.Text = Convert.ToString(B.Function(result));
                    iter2.Text = Convert.ToString(B.countCalc);
                    drawSquares(B.squeres, x_0, x_1, result);
                    break;
            }
        }


        private void drawPoints(List<point> points, point x_0, point x_1, point x_min)
        {
            // Найдем коэффициент масштабирование и смещение относительно полотна
            DrawningData ddata = getDrawningData(x_0, x_1);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Отрисовка рамки
            drawFrame(g, x_0, x_1, ddata);

            // Отрисовка всех точек
            point curPoint = new point();
            for (int i = 0; i < points.Count; i++)
            {
                curPoint.X = ddata.bias.X + ddata.k * (points[i].X - x_0.X) - 2;
                curPoint.Y = ddata.bias.Y + ddata.k * (points[i].Y - x_0.Y) - 2;

                SolidBrush brush = new SolidBrush(Color.Chocolate);
                g.FillRectangle(brush, new Rectangle(Convert.ToInt32(curPoint.X), Convert.ToInt32(curPoint.Y), 2, 2));
            }
            x_min.X = ddata.bias.X + ddata.k * (x_min.X - x_0.X) - 2;
            x_min.Y = ddata.bias.Y + ddata.k * (x_min.Y - x_0.Y) - 2;

            SolidBrush brush1 = new SolidBrush(Color.Purple);
            g.FillRectangle(brush1, new Rectangle(Convert.ToInt32(x_min.X), Convert.ToInt32(x_min.Y), 6, 6));
            drawLimitLine(g, x_0, x_1, ddata);
            pic1.Image = bmp;
            g.Dispose();
        }

        private void drawSquares(List<Area> squares, point x_0, point x_1, point x_min)
        {
            Area area = new Area(x_0, x_1);
            // Найдем коэффициент масштабирование и смещение относительно полотна
            DrawningData ddata = getDrawningData(x_0, x_1);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Отрисовка рамки
            drawFrame(g, x_0, x_1, ddata);

            // Отрисовка всех квадратов
            int x0, y0, dx, dy;
            for (int i = 0; i < squares.Count; i++)
            {
                x0 = Convert.ToInt32(ddata.bias.X + ddata.k * (squares[i].p1.X - area.p1.X));
                y0 = Convert.ToInt32(ddata.bias.Y + ddata.k * (squares[i].p1.Y - area.p1.Y));
                dx = Convert.ToInt32(ddata.k * Math.Abs(squares[i].p2.X - squares[i].p1.X));
                dy = Convert.ToInt32(ddata.k * Math.Abs(squares[i].p2.Y - squares[i].p1.Y));
                g.DrawRectangle(new Pen(Color.Black), new Rectangle(x0, y0, dx, dy));
            }
            x_min.X = ddata.bias.X + ddata.k * (x_min.X - x_0.X) - 2;
            x_min.Y = ddata.bias.Y + ddata.k * (x_min.Y - x_0.Y) - 2;

            SolidBrush brush1 = new SolidBrush(Color.Purple);
            g.FillRectangle(brush1, new Rectangle(Convert.ToInt32(x_min.X), Convert.ToInt32(x_min.Y), 4, 4));
            drawLimitLine(g, x_0, x_1, ddata);
            pic2.Image = bmp;
            g.Dispose();
        }

        private void drawFrame(Graphics g, point x_0, point x_1, DrawningData ddata)
        {
            Pen pen = new Pen(Color.Gray);
            int x0, y0, dx, dy;
            x0 = Convert.ToInt32(ddata.bias.X);
            y0 = Convert.ToInt32(ddata.bias.Y);
            double width = Math.Abs(x_1.X - x_0.X),
                height = Math.Abs(x_1.Y - x_0.Y);
            dx = Convert.ToInt32(ddata.k * width - 1);
            dy = Convert.ToInt32(ddata.k * height - 1);
            g.DrawRectangle(pen, new Rectangle(x0, y0, dx, dy));
        }

        private void drawLimitLine(Graphics g, point x_0, point x_1, DrawningData ddata)
        {
            LimitLine line = new LimitLine(x_0, x_1);

            Pen pen = new Pen(Color.Blue);
            int x0, y0, x1, y1;
            x0 = Convert.ToInt32(ddata.bias.X + ddata.k * (line.p1.X - x_0.X));
            y0 = Convert.ToInt32(ddata.bias.Y + ddata.k * (line.p1.Y - x_0.Y));
            x1 = Convert.ToInt32(ddata.bias.X + ddata.k * (line.p2.X - x_0.X));
            y1 = Convert.ToInt32(ddata.bias.Y + ddata.k * (line.p2.Y - x_0.Y));

            g.DrawLine(pen, x0, y0, x1, y1);
        }

        private DrawningData getDrawningData(point x_0, point x_1)
        {
            DrawningData ddata = new DrawningData();

            double width = Math.Abs(x_1.X - x_0.X),
                height = Math.Abs(x_1.Y - x_0.Y);
            if (((float)bmp.Width / (float)bmp.Height) > (width / height))
            {
                ddata.k = bmp.Height / height;
                ddata.bias.X = (bmp.Width - ddata.k * width) / 2.0;
                ddata.bias.Y = 0;
            }
            else
            {
                ddata.k = bmp.Width / width;
                ddata.bias.X = 0;
                ddata.bias.Y = (bmp.Height - ddata.k * height) / 2.0;
            }

            return ddata;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    label5.Visible = true;
                    p.Visible = true;
                    label6.Visible = false;
                    alpha.Visible = false;
                    label13.Visible = false;
                    m.Visible = false;
                    break;
                case 1:
                    label5.Visible = false;
                    p.Visible = false;
                    label6.Visible = true;
                    alpha.Visible = true;
                    label13.Visible = true;
                    m.Visible = true;
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            x0_x.Clear();
            x0_y.Clear();
            x1_x.Clear();
            x1_y.Clear();
            p.Clear();
            m.Clear();
            alpha.Clear();
        }
    }
}
