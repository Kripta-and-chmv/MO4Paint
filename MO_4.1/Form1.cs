using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double _EPS1, _EPS2, _P, _alpha;
             Point x_0=new Point();
            x_0.X = Convert.ToDouble(x0_x.Text);
            x_0.Y = Convert.ToDouble(x0_y.Text);
            Point x_1=new Point();
            x_1.X = Convert.ToDouble(x1_x.Text);
            x_1.Y = Convert.ToDouble(x1_y.Text);
            _EPS1 = Convert.ToDouble(eps_x.Text);
            _EPS2 = Convert.ToDouble(eps_y.Text);
            _P = Convert.ToDouble(p.Text);
            _alpha = Convert.ToDouble(alpha.Text);
            Point result;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    rand_search A=new rand_search();
                    result = A.DoAlgorithm(x_0, x_1, _EPS1, _EPS2, _P);
                    xmin_x1.Text = Convert.ToString(result.X);
                    xmin_y1.Text = Convert.ToString(result.Y);
                    
                    break;
                case 1:
                    best_sample B=new best_sample();
                    result = B.DoAlgorithm(x_0, x_1, _EPS1, _EPS2, _P, _alpha);
                    xmin_x2.Text = Convert.ToString(result.X);
                    xmin_y2.Text = Convert.ToString(result.Y);
                    break;
            }
        }
    }
}
