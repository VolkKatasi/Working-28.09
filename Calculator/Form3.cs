using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
            form1 = new Form1();
            form2 = new Form2();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Color newColor = Color.Black; // цвет

            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
           
            form1.ChangeColor1(newColor);
            form2.ChangeColor1(newColor);
            this.BackColor = newColor;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Color newColor = Color.White; //  цвет

           

            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            

            // Изменяем цвет
            form1.ChangeColor2(newColor);
            form2.ChangeColor2(newColor);
            this.BackColor = newColor;
        }
    }
}
