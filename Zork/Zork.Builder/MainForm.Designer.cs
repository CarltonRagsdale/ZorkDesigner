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
            this.NewRoomButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.ListOfRooms = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.RoomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoomNameBox = new System.Windows.Forms.TextBox();
            this.NeighborsBox = new System.Windows.Forms.GroupBox();
            this.neighborViewSouth = new Zork.Builder.NeighborView();
            this.neighborViewWest = new Zork.Builder.NeighborView();
            this.neighborViewEast = new Zork.Builder.NeighborView();
            this.neighborViewNorth = new Zork.Builder.NeighborView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomInfoGroupBox.SuspendLayout();
            this.DescriptionBox.SuspendLayout();
            this.NeighborsBox.SuspendLayout();
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
            this.FileLabel.Location = new System.Drawing.Point(3, 7);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(26, 13);
            this.FileLabel.TabIndex = 5;
            this.FileLabel.Text = "&File:";
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
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(35, 3);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(572, 20);
            this.FileNameTextBox.TabIndex = 8;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(613, 2);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(30, 23);
            this.fileSelectButton.TabIndex = 9;
            this.fileSelectButton.Text = "...";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // RoomInfoGroupBox
            // 
            this.RoomInfoGroupBox.Controls.Add(this.DeleteButton);
            this.RoomInfoGroupBox.Controls.Add(this.RoomNameLabel);
            this.RoomInfoGroupBox.Controls.Add(this.DescriptionBox);
            this.RoomInfoGroupBox.Controls.Add(this.RoomNameBox);
            this.RoomInfoGroupBox.Controls.Add(this.NeighborsBox);
            this.RoomInfoGroupBox.Location = new System.Drawing.Point(246, 29);
            this.RoomInfoGroupBox.Name = "RoomInfoGroupBox";
            this.RoomInfoGroupBox.Size = new System.Drawing.Size(397, 524);
            this.RoomInfoGroupBox.TabIndex = 10;
            this.RoomInfoGroupBox.TabStop = false;
            this.RoomInfoGroupBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(302, 485);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Room";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(31, 26);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(69, 13);
            this.RoomNameLabel.TabIndex = 8;
            this.RoomNameLabel.Text = "Room Name:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.textBox1);
            this.DescriptionBox.Location = new System.Drawing.Point(26, 73);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(354, 109);
            this.DescriptionBox.TabIndex = 7;
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
            this.RoomNameBox.Location = new System.Drawing.Point(30, 42);
            this.RoomNameBox.Name = "RoomNameBox";
            this.RoomNameBox.ReadOnly = true;
            this.RoomNameBox.Size = new System.Drawing.Size(347, 20);
            this.RoomNameBox.TabIndex = 6;
            // 
            // NeighborsBox
            // 
            this.NeighborsBox.Controls.Add(this.neighborViewSouth);
            this.NeighborsBox.Controls.Add(this.neighborViewWest);
            this.NeighborsBox.Controls.Add(this.neighborViewEast);
            this.NeighborsBox.Controls.Add(this.neighborViewNorth);
            this.NeighborsBox.Location = new System.Drawing.Point(26, 188);
            this.NeighborsBox.Name = "NeighborsBox";
            this.NeighborsBox.Size = new System.Drawing.Size(354, 291);
            this.NeighborsBox.TabIndex = 5;
            this.NeighborsBox.TabStop = false;
            this.NeighborsBox.Text = "Neighbors";
            // 
            // neighborViewSouth
            // 
            this.neighborViewSouth.Direction = Zork.Common.Directions.South;
            this.neighborViewSouth.Location = new System.Drawing.Point(6, 151);
            this.neighborViewSouth.Name = "neighborViewSouth";
            this.neighborViewSouth.Size = new System.Drawing.Size(340, 69);
            this.neighborViewSouth.TabIndex = 11;
            // 
            // neighborViewWest
            // 
            this.neighborViewWest.Direction = Zork.Common.Directions.West;
            this.neighborViewWest.Location = new System.Drawing.Point(6, 215);
            this.neighborViewWest.Name = "neighborViewWest";
            this.neighborViewWest.Size = new System.Drawing.Size(340, 69);
            this.neighborViewWest.TabIndex = 10;
            // 
            // neighborViewEast
            // 
            this.neighborViewEast.Direction = Zork.Common.Directions.East;
            this.neighborViewEast.Location = new System.Drawing.Point(6, 85);
            this.neighborViewEast.Name = "neighborViewEast";
            this.neighborViewEast.Size = new System.Drawing.Size(340, 69);
            this.neighborViewEast.TabIndex = 9;
            // 
            // neighborViewNorth
            // 
            this.neighborViewNorth.Direction = Zork.Common.Directions.North;
            this.neighborViewNorth.Location = new System.Drawing.Point(6, 19);
            this.neighborViewNorth.Name = "neighborViewNorth";
            this.neighborViewNorth.Size = new System.Drawing.Size(340, 69);
            this.neighborViewNorth.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Zork World(*json)|*.json";
            this.openFileDialog.Title = "Select Zork World";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 556);
            this.Controls.Add(this.RoomInfoGroupBox);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ListOfRooms);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.NewRoomButton);
            this.Controls.Add(this.RoomList);
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "ZorkBuilder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RoomInfoGroupBox.ResumeLayout(false);
            this.RoomInfoGroupBox.PerformLayout();
            this.DescriptionBox.ResumeLayout(false);
            this.DescriptionBox.PerformLayout();
            this.NeighborsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.Button NewRoomButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.ListBox ListOfRooms;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.GroupBox RoomInfoGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.GroupBox DescriptionBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RoomNameBox;
        private System.Windows.Forms.GroupBox NeighborsBox;
        private NeighborView neighborViewSouth;
        private NeighborView neighborViewWest;
        private NeighborView neighborViewEast;
        private NeighborView neighborViewNorth;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

