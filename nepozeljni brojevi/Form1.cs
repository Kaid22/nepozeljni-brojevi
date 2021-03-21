using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nepozeljni_brojevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string temp;
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool gotovo = false;
            string[] subs = textBox1.Text.Split(' ');
            List<int> lista = new List<int>();
            List<int> toremove = new List<int>();
            foreach(string s in subs)
            {
                lista.Add(int.Parse(s));
            }
            while (gotovo==false)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista.Count % lista[i] == 0)
                    {
                        toremove.Add(lista[i]);
                    }
                }
                foreach(int x in toremove)
                {
                    lista.Remove(x);
                }
                if (toremove.Count == 0)
                {
                    gotovo = true;
                }
                toremove.Clear();
                
                                                
            }
            label1.Text = null;
            foreach(int x in lista)
            {
                temp += x.ToString() + " ";
            }
            label1.Text = temp;
        }
    }
}
