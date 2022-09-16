using System;
using System.Linq;


    /*Класс простых уравнений*/
    class TSimpleEquation
    {
        public Rational[] _freeVector;
        public Rational[,] _matrix;
        public int N, M;
        public TSimpleEquation(Rational[,] matrixUser, Rational[] freeVectorUser, int n, int m)
        {
            _freeVector = freeVectorUser;
            _matrix = matrixUser;
            N = n;
            M = m;
        }
        // Функция для изменения позиций двух строк.
        private Rational[,] SwapString(Rational[,] matrix, int i1, int i2)
        {
            for (int j = 0; j < M; j++)
            {
                Rational m = matrix[i1, j];
                matrix[i1, j] = matrix[i2, j];
                matrix[i2, j] = m;
            }
            return matrix;
        }
        // Функция для изменения позиции двух столбцов.
        private Rational[,] SwapColumn(Rational[,] matrix, int j1, int j2)
        {
            for (int i = 0; i < N; i++)
            {
                Rational n = matrix[i, j1];
                matrix[i, j1] = matrix[i, j2];
                matrix[i, j2] = n;
            }
            return matrix;
        }
        // Функция для проверки на вид матрицы (треугольная или нет).
        private bool TriangularMatrix(Rational[,] matrix)
        {
            bool flag = true;
            for (int j = 0; j < M - 1; j++)
            {
                for (int i = j; i < N - 1; i++)
                    if (matrix[i + 1, j] != 0)
                        flag = false;
            }
            return flag;
        }
        // Функция удаления строк с нулями.
        private Rational[,] DeleteZeroString(Rational[,] matrixr)
        {
            bool flag = false;
            int k = 0;
            while (k < N)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (_matrix[i, j] != 0)
                            flag = true;
                    }
                    if (_freeVector[i] != 0)
                        flag = true;
                    if (flag == false)
                    {
                        SwapString(_matrix, N - 1, i);
                        N--;
                        k = 0;
                    }
                    else
                        k++;
                    flag = false;
                }
            }
            return _matrix;
        }
        protected internal string MethodGauss()
        {
            // Убираем все строки с нулями.
            _matrix = DeleteZeroString(_matrix);
            // Рассматривается случай когда вся матрица нулевая.
            if (N == 0)
                M = 0;
            if (!TriangularMatrix(_matrix))
            {
                // В случае если это верхняя треугольная,
                // то преобразуем её а нижнюю треугольную.
                Rational[,] matrixTmp = _matrix;
                for (int i = 0; i < N; i++)
                    for (int j = i + 1; j < N; j++)
                        SwapString(matrixTmp, i, j);
                if (!TriangularMatrix(matrixTmp))
                {
                    for (int i = 0; i < M; i++)
                        for (int j = i + 1; j < M; j++)
                            SwapColumn(_matrix, i, j);
                    if (!TriangularMatrix(_matrix))
                    {
                        for (int i = 0; i < N; i++)
                            for (int j = i + 1; j < N; j++)
                                SwapString(_matrix, i, j);
                        if (!TriangularMatrix(_matrix))
                            return "Impossible";
                    }
                }
                else
                    _matrix = matrixTmp;
            }
            // Переменная, которая будет отслеживать кол-во
            // отличных от нулей чисел на последней строке.
            int tmp = 0;
            // Подсчет числа отличных от нуля "ячеек".
            for (int j = 0; j < M; j++)
                if (_matrix[N - 1, j] != 0)
                    tmp++;
            if ((tmp > 1) || (N == 0))
                // Бесконечное число решений.
                return "Inf";
            else if (tmp == 0)
                // Нет решений.
                return "None";

            // Реализовать обратный ход.
            Rational[] vector = new Rational[M];
            string x;
            vector[M - 1] = _freeVector[M - 1] / _matrix[N - 1, M - 1];
            for (int i = N - 2; i > -1; i--)
            {
                Rational sum = new Rational(0,1);
                for (int j = M - 1; j > -1; j--)
                {
                    sum += _matrix[i, j] * vector[j];
                }
                sum = (_freeVector[i] - sum) / _matrix[i, i];
                vector[i] = sum;
            }
            //vector = vector.Reverse().ToArray();
            x = vector[0].RatioToString();
            for (int i = 1; i < M; i++)
                x += " ; " + vector[i].RatioToString();
            return x;
        }
        public virtual string SystemSolution()
        {
            return (MethodGauss());
        }
        // функция вывода массива.
        public void PrintMatrix()
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Свободный вектор:");
            foreach (Rational i in _freeVector)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
    // Создание класса наследника.
    class TEquation : TSimpleEquation
    {
        public TEquation(Rational[,] matrixUser, Rational[] freeVectorUser, int n, int m) : base(matrixUser, freeVectorUser, n, m)
        {
        }

        // Приведение к треугольному виду.
        public void ReductionTriangularForm()
        {
            Rational koe = new Rational(0,1);
            for (int k = 0; k < N; k++)
            {
                for (int j = k + 1; j < M; j++)
                {
                    koe = _matrix[j, k] / _matrix[k, k];
                    for (int i = k; i < M; i++)
                    {
                        _matrix[j, i] = _matrix[j, i] - koe * _matrix[k, i];
                    }
                    _freeVector[j] = _freeVector[j] - koe * _freeVector[k];
                }
            }
        }
        public override string SystemSolution()
        {
            ReductionTriangularForm();
            return MethodGauss();
        }
    }
    
