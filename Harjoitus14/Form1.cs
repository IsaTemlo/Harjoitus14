using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\s2000934\\Desktop\\Isa\\Isa.gataev\\Repos\\CRUD-projekti\\CRUD-PROJEKTI\\Harjoitus 14\\Demo.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH.mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\s2000934\\Desktop\\Isa\\Isa.gataev\\Repos\\CRUD-projekti\\CRUD-PROJEKTI\\Harjoitus 14\\Demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
