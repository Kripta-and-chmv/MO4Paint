using System;
using System.Collections.Generic;
using point = System.Windows.Point;



namespace MO_4._1
{
    class best_sample
    {

        public List<Area> squeres=new List<Area>();
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
	point rand_search(point x_0, point x_1,int N)
	{
		double c_x = 0, c_y=0; 
		double _x_lenght = Math.Abs(x_1.X - x_0.X),
			_y_lenght = Math.Abs(x_1.Y - x_0.Y);
		double _min_func = double.MaxValue;//DBL_MAX
		point _xk =x_0, _x_min=x_0;
        Random rnd=new Random();
		for (int i = 0; i < N; i++)
		{
            c_x = rnd.NextDouble();
            c_y = rnd.NextDouble();
				_xk.X = _x_lenght*c_x + x_0.X;
				_xk.Y = _y_lenght*c_y + x_0.Y;
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
    int test_number(point x_0, point x_1, double _EPS1, double _EPS2, double _P)
	{
        double _P_eps, _V, _V_eps;
        _V = Math.Abs((x_0.Y - x_0.X) * (x_1.Y - x_1.X));
        _V_eps = _EPS1 * _EPS2;
        _P_eps = _V_eps / _V; //Вероятность попадания в эту окрестность при одном испытании равна
        return (int)Math.Abs(Math.Log(1 - _P) / Math.Log(1 - _P_eps));//число испытаний
	}
	public point DoAlgorithm(point x_0, point x_1, double _EPS1, double _EPS2, double _alpha, int N)
	{
        Area firstSquare=new Area(x_0, x_1);
		point _xk = x_0, _x_min = x_0;
        Area cSquare = firstSquare;
        while (Math.Abs(cSquare.p2.X - cSquare.p1.X) > _EPS1 || Math.Abs(cSquare.p2.Y - cSquare.p1.Y) > _EPS2)
		{
			_xk = _x_min;
			_x_min = rand_search(x_0, x_1, N);
            squeres.Add(cSquare);
			x_0.X = _x_min.X + (x_0.Y - x_0.X) / (2 * _alpha);
			x_1.X = _x_min.X  -(x_0.Y - x_0.X) / (2 * _alpha);
			x_0.Y = _x_min.Y + (x_1.Y - x_1.X) / (2 * _alpha);
			x_1.Y = _x_min.Y - (x_1.Y - x_1.X) / (2 * _alpha);
            
		    if (Function(_x_min) < Function(_xk))
		        _alpha *= 2;
            else 
                _alpha /= 2;
            cSquare=new Area(x_0, x_1);
            countCalc++;
		}
	    squeres.Add(cSquare);
		return _x_min;
	}

    }
}

struct Area
{
    public point p1, p2;

    public Area(point x_0, point x_1)
    {
        p1 = new point();
        p1.X = x_0.X;
        p1.Y = x_0.Y;
        p2 = new point();
        p2.X = x_1.X;
        p2.Y = x_1.Y;
    }
}