using Burbuja.Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnagg_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TbNumber.Text);
            numbers[i++] = number;

            ShowNumbers();
        }
        private void ShowNumbers()
        {
            if (numbers.Length > 0)
            {
                LbXNumber.Items.Clear();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                LbXNumber.Items.Add(numbers[i]);

            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            MetBurbuja burbuja = new MetBurbuja();
            burbuja.OrdenarBurbuja(numbers);
            ShowNumbers();
        }
    }
}
