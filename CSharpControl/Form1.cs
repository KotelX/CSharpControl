using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AutoGenerateArray_Click(object sender, EventArgs e)
        {
            var random = new Random();
            for (int i = 0; i < random.Next(1, 20); i++)
                ArrayInput.Rows.Add(random.Next(-100, 100).ToString());
        }

        private void SortSecond_Click(object sender, EventArgs e)
        {
            var arr = new double[ArrayInput.RowCount - 1];
            for (int i = 0; i < ArrayInput.RowCount - 1; i++)
            {
                arr[i] = double.Parse(ArrayInput[0, i].Value.ToString());
            }
            if (Method.SelectedIndex == 1) CombSort(arr); else ShakerSort(arr);
            ArrayOutput.Rows.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                ArrayOutput.Rows.Add(arr[i].ToString());
            }
        }

        static void Swap(double[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void ShakerSort(double[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i])
                        Swap(arr, i - 1, i);
                }
                left++;
            }
        }

        static void CombSort(double[] arr)
        {
            double gap = arr.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) gap = 1;
                int i = 0;
                swaps = false;
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    if (arr[i] > arr[igap])
                    {
                        Swap(arr, i, igap);
                        swaps = true;
                    }
                    i++;
                }
            }
        }
    }
}
