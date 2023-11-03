using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SayHiButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameText.Text) && string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please enter first and last name.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameText.Focus();
            } 
            else if (string.IsNullOrEmpty(firstNameText.Text))
            {
                MessageBox.Show("Please enter first name.", "No First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameText.Focus();
            }
            else if (string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please enter last name.", "No Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameText.Focus();
            } 
            else
            {
                MessageBox.Show($"Hi {firstNameText.Text} {lastNameText.Text}");
                firstNameText.Text = string.Empty;
                lastNameText.Text = string.Empty;
            }
            
        }
    }
}
