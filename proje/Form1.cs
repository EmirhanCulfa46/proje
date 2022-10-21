using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(1, 50);
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[listBox1.Items.Count];
            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = int.Parse(listBox1.Items[i].ToString());

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                    listBox2.Items.Add(dizi[i]);
                else if (dizi[i] % 2 == 1)
                    listBox3.Items.Add(dizi[i]);

            }
        }
    }
}
