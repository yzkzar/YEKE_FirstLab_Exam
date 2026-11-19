using System;
using System.Windows.Forms;

namespace YEKE_FirstLab_Exam
{
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            SalesOutput.Text =
                $"Sales:\n" +
                $"Danielle: ₱{danielle}\n" +
                $"Edward: ₱{edward}\n" +
                $"Fatima: ₱{fatima}\n" +
                $"Total: ₱{danielle + edward + fatima}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
