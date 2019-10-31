using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using Zork.Builder.ViewModels;
using Zork.Builder.FormsFolder;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                   gameViewModelBindingSource.DataSource = mViewModel;
                }
            }

        }
        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }

        }

        private GameViewModel mViewModel;

        private void NewRoomButton_Click(object sender, EventArgs e)
        {
            using(AddNewRoomForm addRoomForm = new AddNewRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }
    }
}
