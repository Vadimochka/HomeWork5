using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*	Заполнить массив из восьми элементов следующими значениями: 
             * первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, 
             * пятый — 34, шестой — 46, седьмой — 0, восьмой — 13.
            */
            //int[] value = { 37, 0, 50, 46, 34, 46, 0, 13 };

            #endregion

            #region 2
            /*Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы. */

            
            //int[] val = new int[10];

            //for (int i = 0; i < val.Length; i++)
            //{
            //    Console.Write($"{i}: ");
            //    val[i] = int.Parse(Console.ReadLine());
            //}
            //for (int j = 0; j < val.Length; j++)
            //{
            //    Console.Write($"{val[j]}\t");
            //}


            //Console.ReadKey();

            #endregion

            #region 4
            /*Массив предназначен для хранения значений роста двенадцати человек. 
             * С помощью датчика случайных чисел заполнить массив целыми значениями,
             * лежащими в диапазоне от 163 до 190 включительно.*/

            //Random rand = new Random();
            //for (int i =1 ; i <= 12; i++)
            //{
            //    int[] rise = new int[rand.Next(163,190)];
            //    Console.WriteLine(rand.Next(163, 190));

            //}

            //Console.ReadKey();

            #endregion

            #region 20
            /*	В массиве хранятся сведения о стоимости 12 различных предметов. 
             *	Определить общую стоимость всех предметов.*/

            //int[] price = { 5, 6, 8, 9, 10, 6, 50, 9, 74, 19};
            //int sum = price.Sum();
            //Console.WriteLine("Сумма элементов: " + sum);

            //Console.ReadKey();
            #endregion

            
        }
}
}
