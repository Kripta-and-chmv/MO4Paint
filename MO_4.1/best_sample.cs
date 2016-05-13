using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_4._1
{
    class best_sample
    {


	public double Function(Point p)
	{
		int A1 = 1, A2 = 3;
		int a1 = 2, a2 = 1;
		int b1 = 3, b2 = 1;
		int c1 = 2, c2 = 1;
		int d1 = 3, d2 = 2;
		double x = p.X,
			y = p.Y;
		//countCalc++;
		return -((A1 / (1 + Math.Pow(((x - a1) / b1), 2) + Math.Pow(((y - c1) / d1), 2))) + (A2 / (1 + Math.Pow(((x - a2) / b2), 2) + Math.Pow(((y - c2) / d2), 2))));
	}
	Point rand_search(Point x_0, Point x_1,int N)
	{
		double c = 0; 
		double _x_lenght = Math.Abs(x_1.X - x_0.X),
			_y_lenght = Math.Abs(x_1.Y - x_0.Y);
		double _min_func = double.MaxValue;//DBL_MAX
		Point _xk =x_0, _x_min=x_0;
        Random rnd=new Random();
		for (int i = 0; i < N; i++)
		{
		    c = rnd.NextDouble();
				_xk.X = _x_lenght*c + x_0.X;
				_xk.Y = _y_lenght*c + x_0.Y;
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
    int test_number(Point x_0, Point x_1, double _EPS1, double _EPS2, double _P)
	{
        double _P_eps, _V, _V_eps;
        _V = Math.Abs((x_0.Y - x_0.X) * (x_1.Y - x_1.X));
        _V_eps = _EPS1 * _EPS2;
        _P_eps = _V_eps / _V; //Вероятность попадания в эту окрестность при одном испытании равна
        return (int)Math.Abs(Math.Log(1 - _P) / Math.Log(1 - _P_eps));//число испытаний
	}
	public Point DoAlgorithm(Point x_0, Point x_1, double _EPS1, double _EPS2, double _P, double _alpha)
	{
		int N;
		Point _xk = x_0, _x_min = x_0;

		while (Math.Abs(x_1.X - x_0.X) > _EPS1 || Math.Abs(x_1.Y - x_0.Y) > _EPS2)
		{
			_xk = _x_min;
			N = test_number(x_0, x_1, _EPS1, _EPS2, _P);
			_x_min = rand_search(x_0, x_1, N);
			x_0.X = _x_min.X + (x_0.Y - x_0.X) / (2 * _alpha);
			x_1.X = _x_min.X  -(x_0.Y - x_0.X) / (2 * _alpha);
			x_0.Y = _x_min.Y + (x_1.Y - x_1.X) / (2 * _alpha);
			x_1.Y = _x_min.Y - (x_1.Y - x_1.X) / (2 * _alpha);

		    if (Function(_x_min) < Function(_xk))
		        _alpha *= 2;
            else 
                _alpha /= 2;
		} 

		return _x_min;
	}




    }
}
