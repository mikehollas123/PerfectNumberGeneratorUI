using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Numerics;

namespace PerfectNumberGeneratorUI
{
    
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
          
        }
        public void WriteToBox(string message)
        {
            RTBConsole.AppendText("\r" + message);

        }
        private async System.Threading.Tasks.Task ComputeTask()
        {
            WriteToBox("Starting Algorithm:");
            int p = 2;
            int primeCount = 0;
            var startTime = DateTime.Now;

            while (primeCount < Convert.ToInt32(txtPNumCount.Text))
            {
                BigInteger num = PerfectNumbers.Generate_single(p);
                if (num > 0)
                {
                    primeCount++;
                    WriteToBox("Perfect number found: " + num + "- in " + (DateTime.Now - startTime));
                }
                p++;
            }
            WriteToBox("all Perfect Numbers Found!");
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => ComputeTask());
            

          
        }

       
    }
}
