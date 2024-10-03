using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAsyncSync_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task Topla(int sayi,int sayi2)
        {
           await Task.Run(() =>
            {

                Thread.Sleep(10000);
                MessageBox.Show($"{sayi+sayi2}");

            });
        }

        public void MesajGoster()
        {
            Thread.Sleep(10000);
            MessageBox.Show("Deneme");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Topla(2, 2);
            MessageBox.Show("Deneme");

            //MesajGoster();
        }


        public async Task Cikar(string item)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show(item);
               
              
            });
        }
    }
}
