using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaSolutionEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            int N = 0;
            int M = 0;
            Rational[,] matrix = { };
            Rational[] freeVector = { };
            for (int i = 0; i < MatrixText.Lines.Length; i++)
            {
                string line = MatrixText.Lines[i];
                if (i == 0)
                {
                    N = MatrixText.Lines.Length;
                    M = N;
                    matrix = new Rational[N, M];
                    freeVector = new Rational[N];
                }
                for (int j = 0; j < N; j++)
                    try
                    {
                        string temp = line.Split(' ')[j];
                        if (temp.Contains(",") == true)
                        {
                            temp = temp.Split(',')[0] + temp.Split(',')[1] + '/' + temp.Split(',')[1].Length * 10;
                        }
                        else temp = line.Split(' ')[j] + "/1";
                        matrix[i, j] = new Rational(Convert.ToInt32(temp.Split('/')[0]),
                            Convert.ToInt32(temp.Split('/')[1]));
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Answer.Text = "Ошибка ввода";
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Answer.Text = "Ошибка типа входных данных";
                        break;
                    }
                try
                {
                    string temp = line.Split(' ')[N];
                    if (temp.Contains(",")==true) 
                    {
                        temp = temp.Split(',')[0] + temp.Split(',')[1]+'/'+ temp.Split(',')[1].Length*10;
                    } 
                    else temp = line.Split(' ')[N] + "/1";
                    freeVector[i] = new Rational(Convert.ToInt32(temp.Split('/')[0]), 
                        Convert.ToInt32(temp.Split('/')[1])) ;
                }
                catch (System.FormatException)
                {
                    Answer.Text = "Ошибка типа входных данных";
                    break;
                }
                catch (IndexOutOfRangeException)
                {
                    Answer.Text = "Ошибка ввода входных данных";
                    break;
                }
            }
            TEquation equation = new TEquation(matrix, freeVector, N, M);
            equation.ReductionTriangularForm();
            Triangular.Text = "Треугольный вид:\n"+equation.ToStringMatrix();
            string solution = equation.SystemSolution();
            if (solution == "None")
                Answer.Text = "Нет решений";
            else if (solution == "Inf")
                Answer.Text = "Бесконечное число решений";
            else Answer.Text = "X = (" + solution + ")";
        }

        private void MatrixText_TextChanged(object sender, EventArgs e)
        {

        }

        private void прочитатьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            StreamReader text = new StreamReader(openFile.FileName);
            string allText = "";
            while (text.Peek()!=-1)
            {
                allText += text.ReadLine() + "\n";
            }
            MatrixText.Text = allText;
        }
    }
}
