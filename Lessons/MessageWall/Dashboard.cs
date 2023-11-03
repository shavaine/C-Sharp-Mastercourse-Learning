using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            messageListBox.DataSource = messages;
            // messageListBox.DisplayMember = nameof(Dashboard.Text); // If you used a model and want to display specific prop
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = string.Empty;
            }
            messageText.Focus();
        }
    }
}
