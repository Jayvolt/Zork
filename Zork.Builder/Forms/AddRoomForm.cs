using System;
using System.Windows.Forms;
using Zork;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    { 
        public string RoomName => NameTextBox.Text;
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {

        }
    }
}
