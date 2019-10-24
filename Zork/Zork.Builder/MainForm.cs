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

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {

        private World World
        {
            get => mWorld;
            set => mWorld = value;
        }
        public ZorkBuilder()
        {
            InitializeComponent();

            //Player player = new Player();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RoomNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                FileNameTextBox.Text = openFileDialog.FileName;
            }

        }

        private World mWorld;
    }
}
