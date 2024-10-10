using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptionss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(txtFirst.Text) / Convert.ToInt32(txtSecond.Text);
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You  can not divide any numer to zero");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use only numers");
            }
            finally
            {
                MessageBox.Show("Program was finished");
            }
        }
    }
}
