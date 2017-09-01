using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopAllAlgorithmApplication.Core;
using TopAllAlgorithmApplication.Algorithms;

namespace TopAllAlgorithmApplication
{
    public partial class Form1 : Form
    {
        SelectionAlgorithm SelectedAlg;
        public Form1()
        {
            InitializeComponent();

            SelectedAlg = new SelectionAlgorithm();
        }


        private void ShowSourceArray()
        {
            richTextBox1.Text = "Source array " + "\n";
            foreach (int i in SelectedAlg.Mas)
            richTextBox1.Text +=  i + "\t";
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            

            
            BubbleSortAlgorithm BubbleSort = new BubbleSortAlgorithm();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = BubbleSort;
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);

            richTextBox1.Text += "\n\n" + "Bubble Sort" + "\n";
            for(int i =0; i< SelectedAlg.Mas.Length; i++)
            richTextBox1.Text += SelectedAlg.Mas[i].ToString()+ "\t";
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
           
            InsertionSortAlgorithm InsertioSort = new InsertionSortAlgorithm();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = InsertioSort;
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);

            richTextBox1.Text += "\n\n" + "Insertion Sort" + "\n";
            for (int i = 0; i < SelectedAlg.Mas.Length; i++)
                richTextBox1.Text += SelectedAlg.Mas[i].ToString() + "\t";
        }

        private void SelectionSort_Click(object sender, EventArgs e)
        {
           
            SelectionSortAlgorithm SelectionSort = new SelectionSortAlgorithm();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = SelectionSort;
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);

            richTextBox1.Text += "\n\n" + "Selection Sort" + "\n";
            for (int i = 0; i < SelectedAlg.Mas.Length; i++)
                richTextBox1.Text += SelectedAlg.Mas[i].ToString() + "\t";
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            MergeSort MergeS = new MergeSort();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = MergeS;
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);

            richTextBox1.Text += "\n\n" + "Merge Sort" + "\n";
            for (int i = 0; i < SelectedAlg.Mas.Length; i++)
                richTextBox1.Text += SelectedAlg.Mas[i].ToString() + "\t";
        }

        private void BinarySearchButton_Click(object sender, EventArgs e)
        {
            BubbleSortAlgorithm BubbleSortBinary = new BubbleSortAlgorithm();
            BinarySearchAlgorithm BinarySearch = new BinarySearchAlgorithm();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = BubbleSortBinary;
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);



            SelectedAlg.SelectAlgorithm = BinarySearch;
            richTextBox1.Text += "\n\n" + "Binary Search" + "\n";

            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);

            
            
        }

        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            LinearSearchAlgorithm LinearSearch = new LinearSearchAlgorithm();
            SelectedAlg.SetMassive();

            ShowSourceArray();

            SelectedAlg.SelectAlgorithm = LinearSearch;


            richTextBox1.Text += "\n\n" + "Linear Search" + "\n";
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);
        }

        private void buttonFactorialAlgorithm_Click(object sender, EventArgs e)
        {
            FactorialAlgorithm FactorialEquals = new FactorialAlgorithm();
            SelectedAlg.SetMassive();
            

            SelectedAlg.SelectAlgorithm = FactorialEquals;

            richTextBox1.Text += "Factorial ";
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);
        }

        private void buttonFibonacci_Click(object sender, EventArgs e)
        {
            FibonacciSequenceAlgorithm FibonacciEquals = new FibonacciSequenceAlgorithm();
            SelectedAlg.SetMassive();
           
            SelectedAlg.SelectAlgorithm = FibonacciEquals;

            richTextBox1.Text += "Fibonacci ";
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);
        }

        private void buttonStringReverseAlgorithm_Click(object sender, EventArgs e)
        {
            StringReverseAlgorithm StringReverse = new StringReverseAlgorithm();

            SelectedAlg.SetMassive();

            SelectedAlg.SelectAlgorithm = StringReverse;

            richTextBox1.Text += "String Reverse ";
            SelectedAlg.SelectAlgorithm.StartAlgorithm(SelectedAlg.Mas);
        }
    }
}
