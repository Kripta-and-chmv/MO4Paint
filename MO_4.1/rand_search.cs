using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_4._1
{
    class rand_search
    {
	/*double _EPS1, _EPS2, _P, _P_eps, _V, _V_eps;
	Point x_0, x_1;//гиперквадрат
	int N;
	int countIter = 0,countCalc=0;*/

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
	int test_number(Point x_0, Point x_1, double _EPS1, double _EPS2, double _P)
	{
        double _P_eps, _V, _V_eps;
		_V = Math.Abs((x_0.Y - x_0.X)*(x_1.Y - x_1.X));
		_V_eps = _EPS1*_EPS2;
		_P_eps = _V_eps / _V; //Вероятность попадания в эту окрестность при одном испытании равна
		return (int) Math.Abs(Math.Log(1 - _P) / Math.Log(1 - _P_eps));//число испытаний
	}
    public Point DoAlgorithm(Point x_0, Point x_1, double _EPS1, double _EPS2, double _P)
	{
		int N = test_number(x_0, x_1, _EPS1, _EPS2, _P);
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
			
			//countIter++;
		}
		return _x_min;
	}

    }
}
