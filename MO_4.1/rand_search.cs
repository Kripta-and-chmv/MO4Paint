using System;
using System.Collections.Generic;
using System.Windows;
using point = System.Windows.Point;
namespace MO_4._1
{
    class rand_search
    {
        public List<point> PVector = new List<Point>();
        public int countCalc = 0;
        public double Function(point p)
        {
            int A1 = 1, A2 = 3;
            int a1 = 2, a2 = 1;
            int b1 = 3, b2 = 1;
            int c1 = 2, c2 = 1;
            int d1 = 3, d2 = 2;
            double x = p.X,
                y = p.Y;

            return -((A1 / (1 + Math.Pow(((x - a1) / b1), 2) + Math.Pow(((y - c1) / d1), 2))) + (A2 / (1 + Math.Pow(((x - a2) / b2), 2) + Math.Pow(((y - c2) / d2), 2))));
        }
        int test_number(point x_0, point x_1, double _EPS1, double _EPS2, double _P)
        {
            double _P_eps, _V, _V_eps;
            _V = Math.Abs((x_0.Y - x_0.X) * (x_1.Y - x_1.X));
            _V_eps = _EPS1 * _EPS2;
            _P_eps = _V_eps / _V; //Вероятность попадания в эту окрестность при одном испытании равна
            return (int)Math.Abs(Math.Log(1 - _P) / Math.Log(1 - _P_eps));//число испытаний
        }

        public point DoAlgorithm(point x_0, point x_1, double _EPS1, double _EPS2, double _P)
        {
            int N = test_number(x_0, x_1, _EPS1, _EPS2, _P);
            double c_x = 0, c_y;
            double _x_lenght = Math.Abs(x_1.X - x_0.X),
                _y_lenght = Math.Abs(x_1.Y - x_0.Y);
            double _min_func = double.MaxValue;//DBL_MAX
            point _xk = x_0, _x_min = x_0;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                c_x = rnd.NextDouble();
                c_y = rnd.NextDouble();
                _xk.X = _x_lenght * c_x + x_0.X;
                countCalc++;
                _xk.Y = _y_lenght * c_y + x_0.Y;
                PVector.Add(_xk);
                if (_xk.X + _xk.Y <= 1)
                {

                    if (Function(_xk) < _min_func)
                    {
                        _min_func = Function(_xk);
                        _x_min = _xk;
                    }

                }
            }
            return _x_min;
        }

    }
}
struct DrawningData
{
    public double k;
    public point bias;
}
struct LimitLine
{
    public point p1, p2;

    public LimitLine(point x_0, point x_1)
    {
        // Если пересечение линии ограничения и прямой y1 правее прямой x2, то надо обрезать линию ограничения
        if (1 - x_0.Y < x_1.X)
        {
            p1 = new point();
            p1.Y = x_0.Y;
            p1.X = 1 - p1.Y;
        }
        else
        {
            p1 = new point();
            p1.X = x_1.X;
            p1.Y = 1 - p1.X;
        }

        // Если пересечение линии ограничения и прямой y2 правее прямой x1, то надо обрезать линию ограничения
        if (1 - x_1.Y > x_0.X)
        {
            p2 = new point();
            p2.Y = x_1.Y;
            p2.X = 1 - p2.Y;
        }
        else
        {
            p2 = new point();
            p2.X = x_0.X;
            p2.Y = 1 - p2.X;
        }
    }
}

