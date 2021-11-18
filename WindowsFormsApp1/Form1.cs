using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateArr(arr1, 10);
            sw.Start();
            BubbleSort(arr1);
            sw.Stop();
            chart1.Series["BubbleSort"].Points.AddXY("10", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr2, 100);
            sw.Start();
            BubbleSort(arr2);
            sw.Stop();
            chart1.Series["BubbleSort"].Points.AddXY("100", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr3, 1000);
            sw.Start();
            BubbleSort(arr3);
            sw.Stop();
            chart1.Series["BubbleSort"].Points.AddXY("1000", sw.ElapsedMilliseconds);
            sw.Reset();

            //CreateArr(arr4, 9000);
            //sw.Start();
            //BubbleSort(arr4);
            //sw.Stop();
            //chart1.Series["BubbleSort"].Points.AddXY("9000", sw.ElapsedMilliseconds);
            //sw.Reset();


            //1301; 827

            CreateArr(arr1, 10);
            sw.Start();
            RadixSort(arr1);
            sw.Stop();
            chart1.Series["RadixSort"].Points.AddXY("10", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr2, 100);
            sw.Start();
            RadixSort(arr2);
            sw.Stop();
            chart1.Series["RadixSort"].Points.AddXY("100", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr3, 1000);
            sw.Start();
            RadixSort(arr3);
            sw.Stop();
            chart1.Series["RadixSort"].Points.AddXY("1000", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr4, 9000);
            sw.Start();
            RadixSort(arr4);
            sw.Stop();
            chart1.Series["RadixSort"].Points.AddXY("9000", sw.ElapsedMilliseconds);
            sw.Reset();




            CreateArr(arr1, 10);
            sw.Start();
            QuickSort(arr1);
            sw.Stop();
            chart1.Series["QuickSort"].Points.AddXY("10", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr2, 100);
            sw.Start();
            QuickSort(arr2);
            sw.Stop();
            chart1.Series["QuickSort"].Points.AddXY("100", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr3, 1000);
            sw.Start();
            QuickSort(arr3);
            sw.Stop();
            chart1.Series["QuickSort"].Points.AddXY("1000", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr4, 9000);
            sw.Start();
            QuickSort(arr4);
            sw.Stop();
            chart1.Series["QuickSort"].Points.AddXY("9000", sw.ElapsedMilliseconds);
            sw.Reset();




            CreateArr(arr1, 10);
            sw.Start();
            InsertionSort(arr1);
            sw.Stop();
            chart1.Series["InsertionSort"].Points.AddXY("10", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr2, 100);
            sw.Start();
            InsertionSort(arr2);
            sw.Stop();
            chart1.Series["InsertionSort"].Points.AddXY("100", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr3, 1000);
            sw.Start();
            InsertionSort(arr3);
            sw.Stop();
            chart1.Series["InsertionSort"].Points.AddXY("1000", sw.ElapsedMilliseconds);
            sw.Reset();

            //CreateArr(arr4, 9000);
            //sw.Start();
            //InsertionSort(arr4);
            //sw.Stop();
            //chart1.Series["InsertionSort"].Points.AddXY("9000", sw.ElapsedMilliseconds);
            //sw.Reset();




            CreateArr(arr1, 10);
            sw.Start();
            MergeSort(arr1);
            sw.Stop();
            chart1.Series["MergeSort"].Points.AddXY("10", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr2, 100);
            sw.Start();
            MergeSort(arr2);
            sw.Stop();
            chart1.Series["MergeSort"].Points.AddXY("100", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr3, 1000);
            sw.Start();
            MergeSort(arr3);
            sw.Stop();
            chart1.Series["MergeSort"].Points.AddXY("1000", sw.ElapsedMilliseconds);
            sw.Reset();

            CreateArr(arr4, 9000);
            sw.Start();
            MergeSort(arr4);
            sw.Stop();
            chart1.Series["MergeSort"].Points.AddXY("9000", sw.ElapsedMilliseconds);
            sw.Reset();

        }






        static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }



        static void RadixSort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }




        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }


        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }


        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }




        static int[] CreateArr(int[] arr, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next();
            }
            return arr;
        }

        Stopwatch sw = new Stopwatch();
        int[] arr1 = new int[10];
        int[] arr2 = new int[100];
        int[] arr3 = new int[1000];
        int[] arr4 = new int[9000];

    }
}
