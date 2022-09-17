using System;

/*(m,n)*/
class Rational
{
    /*Числитель нашей дроби*/
    private int _m;
    public int M
    {
        get { return _m; }
        set { _m = value; }
    }
    /*Знаменатель нашей дроби*/
    private int _n;
    /*Сокращение дроби*/
    private void FractionReduction()
    {
        int temp = Gcd(Math.Abs(_n), Math.Abs(_m));
        if (temp != 0)
        {
            _n = _n / temp;
            _m = _m / temp;
        }
        if (_n < 0)
        {
            _m = -_m;
            _n = -_n;
        }
    }
    public int N
    {
        get { return _n; }
        set { if (value !=0) _n = value;}
    }
	/*Конструктор класса*/
    public Rational(int m, int n)
    {
        if (n==0) 
        {
            _n = 1;
        }
        else _n = n;
        _m = m;
        FractionReduction();
    }
    /*Алгоритм Евклида для избавления от "больших" чисел*/
    private int Gcd(int val1, int val2)
    {
        while ((val1 != 0) && (val2 != 0))
        {
            if (val1 > val2)
                val1 -= val2;
            else
                val2 -= val1;
        }

        return Math.Max(val1, val2);
    }
    /*Метод перевода Rational в String*/
    public string RatioToString()
    {
        FractionReduction();
        if (_n == 1)
            return _m.ToString();
        else return _m + "/" + _n;
    }
    /*Операция сложения дробей*/
    public static Rational operator +(Rational a, Rational b)
    {
        return new Rational(a.M * b.N + b.M * a.N, a.N * b.N);
    }
    /*Операция умножения дробей*/
    public static Rational operator *(Rational a, Rational b)
    {
        if (b == null)
            b = new Rational(0, 1);
        if (a == null)
            a = new Rational(0, 1);
        return new Rational(a.M * b.M, a.N * b.N);
    }
    /*Операция деленя дробей*/
    public static Rational operator /(Rational a, Rational b)
    {
        return new Rational(a.M * b.N, a.N * b.M);
    }
    /*Операция унарный минус*/
    public static Rational operator -(Rational a)
    {
        return new Rational(-a.M, a.N);
    }
    /*Операция бинарного минуса*/
    public static Rational operator -(Rational a, Rational b)
    {
        return a + (-b);
    }
    /*Операция сравнения > Rational и  Int*/
    public static bool operator >(Rational a, int b)
    {
        if ((Convert.ToDouble(a.M) / Convert.ToDouble(a.N)) > b)
        {
            return true;
        }
        else return false;
        
    }
    /*Операция сравнения < Rational и  Int*/
    public static bool operator <(Rational a, int b)
    {
        if ((Convert.ToDouble(a.M) / Convert.ToDouble(a.N)) < b)
        {
            return true;
        }
        else return false;
    }
    /*Оператор != Rational и Int*/
    public static bool operator !=(Rational a, int b)
    {
        if (a.M != b)
            return true;
        else return false;
    }
    /*Оператор == Rational и Int*/
    public static bool operator ==(Rational a, int b)
    {
        if ((a.M == b) && (a.N == 1))
            return true;
        else return false;
    }
}