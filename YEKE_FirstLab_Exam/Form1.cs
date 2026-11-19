using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YEKE_FirstLab_Exam
{
    public partial class Form1 : Form
    {
        private double total_Danielle = 0.0;
        private double total_Edward = 0.0;
        private double total_Fatima = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        { 
            if (salesInitial == "D")
            {
                total_Danielle += salesAmount;
                Output.Text = $"Updated Total Sales:\nDanielle: ₱{total_Danielle}";
            }
            else if (salesInitial == "E")
            {
                total_Edward += salesAmount;
                Output.Text = $"Updated Total Sales:\nEdward: ₱{total_Edward}";
            }
            else if (salesInitial == "F")
            {
                total_Fatima += salesAmount;
                Output.Text = $"Updated Total Sales:\nFatima: ₱{total_Fatima}";
            }
            else
            {
                Output.Text = "Invalid Sales Person Initial.";
            }
          }

        private void clearEntry()
        {
            Output.Text = "";
            textBox_Initial.Text = "";
            textBox_Amount.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_Amount.Text, out double saleAmount))
            {
                getSalesPerson_Amount(textBox_Initial.Text, saleAmount);
            }
            else
            {
                Output.Text = "Please enter a valid number for the sale amount.";
            }

        }



        private void Btn_Clear_Click_Click_1(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 summary = new Form2(total_Danielle, total_Edward, total_Fatima);
            summary.ShowDialog(this);
        }
    }
}

