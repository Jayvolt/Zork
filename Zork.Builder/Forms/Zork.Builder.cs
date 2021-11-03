using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork;
using Zork.Builder.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    internal interface IBlinkable
    {
        int Frequency { get; }
    }
    public partial class Zork_Builder : Form
    {
        private WorldViewModel _viewModel;
        private Control[] _worldDependentControls;
        private ToolStripMenuItem[] _worldDependentMenuItems;

        internal WorldViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    worldViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        private bool IsWorldLoaded
        {
            get
            {
                return _viewModel.WorldIsLoaded;
            }
            set
            {
                _viewModel.WorldIsLoaded = value;

                foreach (var control in _worldDependentControls)
                {
                    control.Enabled = _viewModel.WorldIsLoaded;
                }

                foreach (var menuItem in _worldDependentMenuItems)
                {
                    menuItem.Enabled = _viewModel.WorldIsLoaded;
                }
            }
        }
        public Zork_Builder()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();

            _worldDependentControls = new Control[]
            {
                addRoomButton,
                deleteRoomButton
            };

            IsWorldLoaded = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

    
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itemsGroup_Enter(object sender, EventArgs e)
        {

        }

        private void itemNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {

        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                    ViewModel.WorldIsLoaded = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "TestFile.json";
            _viewModel.SaveWorld(filename);
        }
    }
}
