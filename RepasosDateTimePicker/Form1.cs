using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasosDateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dateTimePicker1.Text;
            //textBox1.Text = dateTimePicker1.Value.ToString();

            DateTime dt = dateTimePicker1.Value;
            string s = dt.Day + "/" + dt.Month + "/" + dt.Year;
            textBox1.Text = s;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = "Inicio: " + e.Start.ToShortDateString() + "\r\nFin: " + e.End.ToShortDateString();
        }
    }
}
