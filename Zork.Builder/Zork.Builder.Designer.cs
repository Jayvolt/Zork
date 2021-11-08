namespace Zork.Builder
{
    partial class Zork_Builder
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
            System.Windows.Forms.TabControl tabControl;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.GroupBox messagesGroup;
            System.Windows.Forms.Label quitMsgLabel;
            System.Windows.Forms.Label welcomeMsgLabel;
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.itemsGroup = new System.Windows.Forms.GroupBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.neighborsGroup = new System.Windows.Forms.GroupBox();
            this.westComboBox = new System.Windows.Forms.ComboBox();
            this.eastComboBox = new System.Windows.Forms.ComboBox();
            this.southComboBox = new System.Windows.Forms.ComboBox();
            this.northComboBox = new System.Windows.Forms.ComboBox();
            this.westCheckBox = new System.Windows.Forms.CheckBox();
            this.eastCheckBox = new System.Windows.Forms.CheckBox();
            this.southCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.roomsGroup = new System.Windows.Forms.GroupBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.roomList = new System.Windows.Forms.ListBox();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.quitMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.welcomeMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.FileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            tabControl = new System.Windows.Forms.TabControl();
            itemNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startingLocationLabel = new System.Windows.Forms.Label();
            messagesGroup = new System.Windows.Forms.GroupBox();
            quitMsgLabel = new System.Windows.Forms.Label();
            welcomeMsgLabel = new System.Windows.Forms.Label();
            tabControl.SuspendLayout();
            this.roomsTab.SuspendLayout();
            this.itemsGroup.SuspendLayout();
            this.neighborsGroup.SuspendLayout();
            this.detailsGroup.SuspendLayout();
            this.roomsGroup.SuspendLayout();
            this.generalTab.SuspendLayout();
            messagesGroup.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(this.roomsTab);
            tabControl.Controls.Add(this.generalTab);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(839, 449);
            tabControl.TabIndex = 5;
            // 
            // roomsTab
            // 
            this.roomsTab.BackColor = System.Drawing.Color.Transparent;
            this.roomsTab.Controls.Add(this.itemsGroup);
            this.roomsTab.Controls.Add(this.neighborsGroup);
            this.roomsTab.Controls.Add(this.detailsGroup);
            this.roomsTab.Controls.Add(this.roomsGroup);
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(831, 423);
            this.roomsTab.TabIndex = 0;
            this.roomsTab.Text = "Rooms";
            // 
            // itemsGroup
            // 
            this.itemsGroup.Controls.Add(this.itemNameTextBox);
            this.itemsGroup.Controls.Add(itemNameLabel);
            this.itemsGroup.Controls.Add(this.deleteItemButton);
            this.itemsGroup.Controls.Add(this.addItemButton);
            this.itemsGroup.Controls.Add(this.itemsList);
            this.itemsGroup.Location = new System.Drawing.Point(515, 6);
            this.itemsGroup.Name = "itemsGroup";
            this.itemsGroup.Size = new System.Drawing.Size(313, 413);
            this.itemsGroup.TabIndex = 6;
            this.itemsGroup.TabStop = false;
            this.itemsGroup.Text = "Items";
            this.itemsGroup.Enter += new System.EventHandler(this.itemsGroup_Enter);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(46, 44);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.itemNameTextBox.TabIndex = 6;
            this.itemNameTextBox.Text = "Enter an Item Name";
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.itemNameTextBox_TextChanged);
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(5, 46);
            itemNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(38, 13);
            itemNameLabel.TabIndex = 5;
            itemNameLabel.Text = "Name:";
            itemNameLabel.Click += new System.EventHandler(this.itemNameLabel_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(235, 19);
            this.deleteItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(73, 23);
            this.deleteItemButton.TabIndex = 4;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(161, 19);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(73, 23);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(161, 44);
            this.itemsList.Margin = new System.Windows.Forms.Padding(2);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(149, 277);
            this.itemsList.TabIndex = 1;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // neighborsGroup
            // 
            this.neighborsGroup.Controls.Add(this.westComboBox);
            this.neighborsGroup.Controls.Add(this.eastComboBox);
            this.neighborsGroup.Controls.Add(this.southComboBox);
            this.neighborsGroup.Controls.Add(this.northComboBox);
            this.neighborsGroup.Controls.Add(this.westCheckBox);
            this.neighborsGroup.Controls.Add(this.eastCheckBox);
            this.neighborsGroup.Controls.Add(this.southCheckBox);
            this.neighborsGroup.Controls.Add(this.checkBox7);
            this.neighborsGroup.Location = new System.Drawing.Point(192, 199);
            this.neighborsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.neighborsGroup.Name = "neighborsGroup";
            this.neighborsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.neighborsGroup.Size = new System.Drawing.Size(320, 220);
            this.neighborsGroup.TabIndex = 5;
            this.neighborsGroup.TabStop = false;
            this.neighborsGroup.Text = "Neighbors";
            // 
            // westComboBox
            // 
            this.westComboBox.Enabled = false;
            this.westComboBox.FormattingEnabled = true;
            this.westComboBox.Location = new System.Drawing.Point(72, 168);
            this.westComboBox.Name = "westComboBox";
            this.westComboBox.Size = new System.Drawing.Size(238, 21);
            this.westComboBox.TabIndex = 11;
            this.westComboBox.Text = "Select a Room";
            // 
            // eastComboBox
            // 
            this.eastComboBox.Enabled = false;
            this.eastComboBox.FormattingEnabled = true;
            this.eastComboBox.Location = new System.Drawing.Point(73, 118);
            this.eastComboBox.Name = "eastComboBox";
            this.eastComboBox.Size = new System.Drawing.Size(238, 21);
            this.eastComboBox.TabIndex = 10;
            this.eastComboBox.Text = "Select a Room";
            // 
            // southComboBox
            // 
            this.southComboBox.Enabled = false;
            this.southComboBox.FormattingEnabled = true;
            this.southComboBox.Location = new System.Drawing.Point(73, 68);
            this.southComboBox.Name = "southComboBox";
            this.southComboBox.Size = new System.Drawing.Size(238, 21);
            this.southComboBox.TabIndex = 9;
            this.southComboBox.Text = "Select a Room";
            // 
            // northComboBox
            // 
            this.northComboBox.Enabled = false;
            this.northComboBox.FormattingEnabled = true;
            this.northComboBox.Location = new System.Drawing.Point(73, 18);
            this.northComboBox.Name = "northComboBox";
            this.northComboBox.Size = new System.Drawing.Size(238, 21);
            this.northComboBox.TabIndex = 8;
            this.northComboBox.Text = "Select a Room";
            // 
            // westCheckBox
            // 
            this.westCheckBox.AutoSize = true;
            this.westCheckBox.Location = new System.Drawing.Point(12, 168);
            this.westCheckBox.Name = "westCheckBox";
            this.westCheckBox.Size = new System.Drawing.Size(54, 17);
            this.westCheckBox.TabIndex = 7;
            this.westCheckBox.Text = "West:";
            this.westCheckBox.UseVisualStyleBackColor = true;
            // 
            // eastCheckBox
            // 
            this.eastCheckBox.AutoSize = true;
            this.eastCheckBox.Location = new System.Drawing.Point(12, 118);
            this.eastCheckBox.Name = "eastCheckBox";
            this.eastCheckBox.Size = new System.Drawing.Size(50, 17);
            this.eastCheckBox.TabIndex = 6;
            this.eastCheckBox.Text = "East:";
            this.eastCheckBox.UseVisualStyleBackColor = true;
            // 
            // southCheckBox
            // 
            this.southCheckBox.AutoSize = true;
            this.southCheckBox.Location = new System.Drawing.Point(12, 68);
            this.southCheckBox.Name = "southCheckBox";
            this.southCheckBox.Size = new System.Drawing.Size(57, 17);
            this.southCheckBox.TabIndex = 5;
            this.southCheckBox.Text = "South:";
            this.southCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(12, 18);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(55, 17);
            this.checkBox7.TabIndex = 4;
            this.checkBox7.Text = "North:";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.descriptionTextBox);
            this.detailsGroup.Controls.Add(this.nameTextBox);
            this.detailsGroup.Controls.Add(descriptionLabel);
            this.detailsGroup.Controls.Add(nameLabel);
            this.detailsGroup.Location = new System.Drawing.Point(192, 6);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(320, 193);
            this.detailsGroup.TabIndex = 4;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Details";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(77, 53);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(237, 116);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "Enter a Room Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(77, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(237, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Enter a Room Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // roomsGroup
            // 
            this.roomsGroup.Controls.Add(startingLocationLabel);
            this.roomsGroup.Controls.Add(this.deleteRoomButton);
            this.roomsGroup.Controls.Add(this.addRoomButton);
            this.roomsGroup.Controls.Add(this.roomCombo);
            this.roomsGroup.Controls.Add(this.roomList);
            this.roomsGroup.Location = new System.Drawing.Point(17, 6);
            this.roomsGroup.Name = "roomsGroup";
            this.roomsGroup.Size = new System.Drawing.Size(169, 413);
            this.roomsGroup.TabIndex = 1;
            this.roomsGroup.TabStop = false;
            this.roomsGroup.Text = "Rooms";
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(3, 328);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(87, 13);
            startingLocationLabel.TabIndex = 3;
            startingLocationLabel.Text = "Starting Location";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(81, 19);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(6, 19);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // roomCombo
            // 
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(6, 351);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(150, 21);
            this.roomCombo.TabIndex = 4;
            this.roomCombo.Text = "Select a Room";
            // 
            // roomList
            // 
            this.roomList.FormattingEnabled = true;
            this.roomList.Items.AddRange(new object[] {
            "Bathroom",
            "Kitchen",
            "Living Room",
            "Bedroom"});
            this.roomList.Location = new System.Drawing.Point(6, 44);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(150, 264);
            this.roomList.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.Transparent;
            this.generalTab.Controls.Add(messagesGroup);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(831, 423);
            this.generalTab.TabIndex = 1;
            this.generalTab.Text = "General";
            // 
            // messagesGroup
            // 
            messagesGroup.Controls.Add(this.quitMsgTextBox);
            messagesGroup.Controls.Add(quitMsgLabel);
            messagesGroup.Controls.Add(this.welcomeMsgTextBox);
            messagesGroup.Controls.Add(welcomeMsgLabel);
            messagesGroup.Location = new System.Drawing.Point(9, 7);
            messagesGroup.Name = "messagesGroup";
            messagesGroup.Size = new System.Drawing.Size(240, 183);
            messagesGroup.TabIndex = 2;
            messagesGroup.TabStop = false;
            messagesGroup.Text = "Messages";
            // 
            // quitMsgTextBox
            // 
            this.quitMsgTextBox.Location = new System.Drawing.Point(9, 113);
            this.quitMsgTextBox.Name = "quitMsgTextBox";
            this.quitMsgTextBox.Size = new System.Drawing.Size(223, 59);
            this.quitMsgTextBox.TabIndex = 5;
            this.quitMsgTextBox.Text = "";
            // 
            // quitMsgLabel
            // 
            quitMsgLabel.AutoSize = true;
            quitMsgLabel.Location = new System.Drawing.Point(6, 94);
            quitMsgLabel.Name = "quitMsgLabel";
            quitMsgLabel.Size = new System.Drawing.Size(113, 13);
            quitMsgLabel.TabIndex = 4;
            quitMsgLabel.Text = "Game\'s Quit Message:";
            // 
            // welcomeMsgTextBox
            // 
            this.welcomeMsgTextBox.Location = new System.Drawing.Point(9, 32);
            this.welcomeMsgTextBox.Name = "welcomeMsgTextBox";
            this.welcomeMsgTextBox.Size = new System.Drawing.Size(223, 59);
            this.welcomeMsgTextBox.TabIndex = 3;
            this.welcomeMsgTextBox.Text = "";
            // 
            // welcomeMsgLabel
            // 
            welcomeMsgLabel.AutoSize = true;
            welcomeMsgLabel.Location = new System.Drawing.Point(6, 16);
            welcomeMsgLabel.Name = "welcomeMsgLabel";
            welcomeMsgLabel.Size = new System.Drawing.Size(139, 13);
            welcomeMsgLabel.TabIndex = 2;
            welcomeMsgLabel.Text = "Game\'s Welcome Message:";
            // 
            // FileTab
            // 
            this.FileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(37, 20);
            this.FileTab.Text = "File";
            this.FileTab.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTab,
            this.editToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(839, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON Files | *.json";
            // 
            // Zork_Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 473);
            this.Controls.Add(tabControl);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Zork_Builder";
            this.Text = "Zork Editor";
            tabControl.ResumeLayout(false);
            this.roomsTab.ResumeLayout(false);
            this.itemsGroup.ResumeLayout(false);
            this.itemsGroup.PerformLayout();
            this.neighborsGroup.ResumeLayout(false);
            this.neighborsGroup.PerformLayout();
            this.detailsGroup.ResumeLayout(false);
            this.detailsGroup.PerformLayout();
            this.roomsGroup.ResumeLayout(false);
            this.roomsGroup.PerformLayout();
            this.generalTab.ResumeLayout(false);
            messagesGroup.ResumeLayout(false);
            messagesGroup.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.GroupBox neighborsGroup;
        private System.Windows.Forms.ComboBox westComboBox;
        private System.Windows.Forms.ComboBox eastComboBox;
        private System.Windows.Forms.ComboBox southComboBox;
        private System.Windows.Forms.ComboBox northComboBox;
        private System.Windows.Forms.CheckBox westCheckBox;
        private System.Windows.Forms.CheckBox eastCheckBox;
        private System.Windows.Forms.CheckBox southCheckBox;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox roomsGroup;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.ListBox roomList;
        private System.Windows.Forms.GroupBox itemsGroup;
        private System.Windows.Forms.ToolStripMenuItem FileTab;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.RichTextBox quitMsgTextBox;
        private System.Windows.Forms.RichTextBox welcomeMsgTextBox;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

