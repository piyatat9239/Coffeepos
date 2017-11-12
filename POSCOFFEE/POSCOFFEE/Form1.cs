using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSCOFFEE
{
    public partial class Form1 : Form
    {
        string file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        public void drink(string menu, string bath)
        {
            string[] array = { menu, bath };
            var Ad = new ListViewItem(array);
            listView1.Items.Add(Ad);
            aj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drink("Esspesso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drink("Esspesso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drink("Esspesso(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drink("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drink("Americano(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drink("Lette(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            drink("Lette(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            drink("Lette(Frappe)", "50");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            drink("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            drink("Mocha(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            drink("Mocha(Frappe)", "50");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            drink("Capuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            drink("Capuccino(Ice)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            drink("Capuccino(Frappe)", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            drink("GreenTea(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            drink("GreenTea(Ice)", "25");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            drink("GreenTea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            drink("ThaiTea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            drink("ThaiTea(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            drink("ThaiTea(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            drink("CoCoa(Hot)", "20");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            drink("CoCoa(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            drink("CoCoa(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            drink("Milk(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            drink("Milk(Ice)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            drink("Milk(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            drink("MilkTea(Ice)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            drink("MilkTea(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            drink("LemonTea(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            drink("LemonTea(Frappe)", "30");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            drink("Milo(Hot)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            drink("Milo(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            drink("Milo(Freppe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            drink("Nescafe(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            drink("Nescafe(Ice)", "25");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            drink("Nescafe(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            drink("NesteaTea(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            drink("NesteaTea(Ice)", "25");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            drink("NesteaTea(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            drink("Italian Soda", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            drink("Red lime Soda", "25");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drink("Honey lime Soda", "25");
        }

        double x;
        private int i;

        public string[] aj()
        {
            x = 0;
            string[] mk = new string[listView1.Items.Count];
            int k = listView1.Items.Count;
            for (int i = 0; i < k; i++)
            {
                x += double.Parse(listView1.Items[i].SubItems[1].Text);
                mk[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label26.Text = x.ToString();
            return mk;
        }
        public string[] aj1()
        {
            string[] mk = new string[listView1.Items.Count];
            int k = listView1.Items.Count;
            for (int i = 0; i < k; i++)
            {
                mk[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            return mk;
        }

        public void ff()
        {
            string[] uu = aj1(); string[] kk = aj();           
            string pp = "I Love Beyond Cafe" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string qq = "I Love Beyond Cafe";
            qq += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd:mm:yyyy") + "\r\n" + "\r\n";
            qq += "•••• All Menu ••••" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                qq += kk[i] + new String(' ', 5) + "\r\n";
            }
            qq += "\r\n";
            qq += "Total Price : " + label26.Text + " Bath" + "\r\n" + "\r\n" + "\r\n" + " •••• ขอบคุณที่ใช้บริการครับ •••• ";
            System.IO.File.WriteAllText(file + @"\" + pp + ".txt", qq);
            textBox1.Text += qq + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at : " + file + @"\" + pp + ".txt";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage2);
        }
        bool ko = false;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage2);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (ko == false)
            {
                tabControl1.TabPages.Insert(1, tabPage2); ko = true;
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                tabControl1.SelectedTab =tabPage2;
            }
            if (listView1.Items.Count > 0)
                ff();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ko = false;
            tabControl1.Controls.Remove(listView1);
            label26.Text = "0";
            textBox1.Text = "ไม่มีรายการที่สั่งครับ";
        }
    }
}
