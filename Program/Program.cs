using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Vector;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tempTask = new Vector(); if (tempTask.taskData[0].Task != null) ;
                try
            {
                var vector1 = new Vector(3, 6, 7);
                var vector2 = new Vector(4, 8, 1);

                Console.WriteLine("Операции над векторами:");
                vector1.VectorInfo(vector1);
                vector2.VectorInfo(vector2);

                Console.WriteLine("\nДлинна вектора 1: " + vector1.Length(vector1));
                Console.WriteLine("Длинна вектора 2: " + vector1.Length(vector2));

                Console.WriteLine("\nСкалярное произведение векторов:" + vector1.ScalarMultiple(vector1, vector2));

                Console.WriteLine("\nПроизведение двух векторов: ");
                vector1.VectorInfo(vector1.VectorMultiple(vector1, vector2));

                Console.WriteLine("\nСумма векторов:");
                vector1.VectorInfo(vector1.VectorSum(vector1, vector2));

                Console.WriteLine("\nРазность векторов:");
                vector1.VectorInfo(vector1.VectorDifference(vector1, vector2));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение ", ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
