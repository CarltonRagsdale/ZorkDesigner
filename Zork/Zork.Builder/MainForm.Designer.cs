namespace Zork.Builder
{
    partial class ZorkBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoomList = new System.Windows.Forms.ListBox();
            this.GameTabPage = new System.Windows.Forms.TabPage();
            this.RoomTabPage = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoomNameBox = new System.Windows.Forms.TextBox();
            this.NeighborsBox = new System.Windows.Forms.GroupBox();
            this.UserInputPage = new System.Windows.Forms.TabControl();
            this.NewRoomButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.ListOfRooms = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.neighborView1 = new Zork.Builder.NeighborView();
            this.neighborView2 = new Zork.Builder.NeighborView();
            this.neighborView3 = new Zork.Builder.NeighborView();
            this.neighborView4 = new Zork.Builder.NeighborView();
            this.RoomTabPage.SuspendLayout();
            this.DescriptionBox.SuspendLayout();
            this.NeighborsBox.SuspendLayout();
            this.UserInputPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomList
            // 
            this.RoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RoomList.FormattingEnabled = true;
            this.RoomList.Location = new System.Drawing.Point(2, 29);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(238, 524);
            this.RoomList.TabIndex = 0;
            // 
            // GameTabPage
            // 
            this.GameTabPage.Location = new System.Drawing.Point(4, 22);
            this.GameTabPage.Name = "GameTabPage";
            this.GameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GameTabPage.Size = new System.Drawing.Size(374, 505);
            this.GameTabPage.TabIndex = 1;
            this.GameTabPage.Text = "Game Tab";
            this.GameTabPage.UseVisualStyleBackColor = true;
            // 
            // RoomTabPage
            // 
            this.RoomTabPage.Controls.Add(this.DeleteButton);
            this.RoomTabPage.Controls.Add(this.RoomNameLabel);
            this.RoomTabPage.Controls.Add(this.DescriptionBox);
            this.RoomTabPage.Controls.Add(this.RoomNameBox);
            this.RoomTabPage.Controls.Add(this.NeighborsBox);
            this.RoomTabPage.Location = new System.Drawing.Point(4, 22);
            this.RoomTabPage.Name = "RoomTabPage";
            this.RoomTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoomTabPage.Size = new System.Drawing.Size(374, 505);
            this.RoomTabPage.TabIndex = 0;
            this.RoomTabPage.Text = "Room Tab";
            this.RoomTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(282, 476);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Room";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(11, 17);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(69, 13);
            this.RoomNameLabel.TabIndex = 3;
            this.RoomNameLabel.Text = "Room Name:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.textBox1);
            this.DescriptionBox.Location = new System.Drawing.Point(6, 64);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(354, 109);
            this.DescriptionBox.TabIndex = 2;
            this.DescriptionBox.TabStop = false;
            this.DescriptionBox.Text = "Room Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 83);
            this.textBox1.TabIndex = 0;
            // 
            // RoomNameBox
            // 
            this.RoomNameBox.Location = new System.Drawing.Point(13, 33);
            this.RoomNameBox.Name = "RoomNameBox";
            this.RoomNameBox.Size = new System.Drawing.Size(347, 20);
            this.RoomNameBox.TabIndex = 1;
            this.RoomNameBox.TextChanged += new System.EventHandler(this.RoomNameBox_TextChanged);
            // 
            // NeighborsBox
            // 
            this.NeighborsBox.Controls.Add(this.neighborView4);
            this.NeighborsBox.Controls.Add(this.neighborView3);
            this.NeighborsBox.Controls.Add(this.neighborView2);
            this.NeighborsBox.Controls.Add(this.neighborView1);
            this.NeighborsBox.Location = new System.Drawing.Point(6, 179);
            this.NeighborsBox.Name = "NeighborsBox";
            this.NeighborsBox.Size = new System.Drawing.Size(354, 291);
            this.NeighborsBox.TabIndex = 0;
            this.NeighborsBox.TabStop = false;
            this.NeighborsBox.Text = "Neighbors";
            // 
            // UserInputPage
            // 
            this.UserInputPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserInputPage.Controls.Add(this.RoomTabPage);
            this.UserInputPage.Controls.Add(this.GameTabPage);
            this.UserInputPage.Location = new System.Drawing.Point(260, 22);
            this.UserInputPage.Name = "UserInputPage";
            this.UserInputPage.SelectedIndex = 0;
            this.UserInputPage.Size = new System.Drawing.Size(382, 531);
            this.UserInputPage.TabIndex = 2;
            // 
            // NewRoomButton
            // 
            this.NewRoomButton.Location = new System.Drawing.Point(45, 521);
            this.NewRoomButton.Name = "NewRoomButton";
            this.NewRoomButton.Size = new System.Drawing.Size(143, 23);
            this.NewRoomButton.TabIndex = 3;
            this.NewRoomButton.Text = "Add New";
            this.NewRoomButton.UseVisualStyleBackColor = true;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(2, 10);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(23, 13);
            this.FileLabel.TabIndex = 5;
            this.FileLabel.Text = "File";
            // 
            // ListOfRooms
            // 
            this.ListOfRooms.FormattingEnabled = true;
            this.ListOfRooms.Location = new System.Drawing.Point(12, 74);
            this.ListOfRooms.Name = "ListOfRooms";
            this.ListOfRooms.Size = new System.Drawing.Size(214, 433);
            this.ListOfRooms.TabIndex = 6;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(13, 48);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(213, 20);
            this.SearchBar.TabIndex = 7;
            // 
            // neighborView1
            // 
            this.neighborView1.Direction = Zork.Common.Directions.North;
            this.neighborView1.Location = new System.Drawing.Point(7, 19);
            this.neighborView1.Name = "neighborView1";
            this.neighborView1.Size = new System.Drawing.Size(347, 69);
            this.neighborView1.TabIndex = 8;
            // 
            // neighborView2
            // 
            this.neighborView2.Direction = Zork.Common.Directions.East;
            this.neighborView2.Location = new System.Drawing.Point(7, 85);
            this.neighborView2.Name = "neighborView2";
            this.neighborView2.Size = new System.Drawing.Size(347, 69);
            this.neighborView2.TabIndex = 9;
            // 
            // neighborView3
            // 
            this.neighborView3.Direction = Zork.Common.Directions.West;
            this.neighborView3.Location = new System.Drawing.Point(7, 215);
            this.neighborView3.Name = "neighborView3";
            this.neighborView3.Size = new System.Drawing.Size(347, 69);
            this.neighborView3.TabIndex = 10;
            // 
            // neighborView4
            // 
            this.neighborView4.Direction = Zork.Common.Directions.South;
            this.neighborView4.Location = new System.Drawing.Point(8, 151);
            this.neighborView4.Name = "neighborView4";
            this.neighborView4.Size = new System.Drawing.Size(347, 69);
            this.neighborView4.TabIndex = 11;
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 556);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ListOfRooms);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.NewRoomButton);
            this.Controls.Add(this.UserInputPage);
            this.Controls.Add(this.RoomList);
            this.Name = "ZorkBuilder";
            this.Text = "ZorkBuilder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RoomTabPage.ResumeLayout(false);
            this.RoomTabPage.PerformLayout();
            this.DescriptionBox.ResumeLayout(false);
            this.DescriptionBox.PerformLayout();
            this.NeighborsBox.ResumeLayout(false);
            this.UserInputPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.TabPage GameTabPage;
        private System.Windows.Forms.TabPage RoomTabPage;
        private System.Windows.Forms.TabControl UserInputPage;
        private System.Windows.Forms.TextBox RoomNameBox;
        private System.Windows.Forms.GroupBox NeighborsBox;
        private System.Windows.Forms.Button NewRoomButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.GroupBox DescriptionBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.ListBox ListOfRooms;
        private System.Windows.Forms.TextBox SearchBar;
        private NeighborView neighborView1;
        private NeighborView neighborView4;
        private NeighborView neighborView3;
        private NeighborView neighborView2;
    }
}

