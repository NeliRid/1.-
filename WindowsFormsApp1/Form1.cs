using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private List<int[]> aList;
        private void button1_Click(object sender, EventArgs e)
        {

            label5.Text = "";
            aList = new List<int[]>();
            int min, max, len;
            len = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            max = Convert.ToInt32(textBox3.Text);
            int[] masiv = new int[len];

            for (int i = 0; i < len; i++)
            {
                masiv[i] = rnd.Next(min, max);
                label5.Text += masiv[i].ToString() + " ";
            }
            int[] masiv2 = (int[])masiv.Clone();
            int[] masiv3 = (int[])masiv.Clone();
            int[] masiv4 = (int[])masiv.Clone();
            Sort.bubble(masiv2);
            for (int i = 0; i < len; i++)
            {
                textBox4.Text += masiv2[i].ToString() + " ";
            }
            Sort.quickSort(masiv3);
            for (int i = 0; i < len; i++)
            {
                textBox5.Text += masiv2[i].ToString() + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    public class Sort
    {

        public static void bubble(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }

        public static void quickSort(int[] arr)
        {
            quick(arr, 0, arr.Length - 1);
        }

        private static void quick(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p1 = partition(arr, low, high);
                quick(arr, low, p1 - 1);
                quick(arr, p1 + 1, high);
            }
        }

        private static int partition(int[] arr, int low, int high)
        {
            int p = arr[high];
            int i = (low - 1);
            int tmp = 0;

            for (int j = low; j <= high - i; j++)
            {
                if (arr[j] < p)
                {
                    i++;
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
            tmp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tmp;
            return (i + 1);
        }
    }
}
