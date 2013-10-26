namespace UniProgramGen
{
    partial class RoomsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomName = new System.Windows.Forms.TextBox();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.Capacity = new System.Windows.Forms.Label();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.checkedListRoomTypes = new System.Windows.Forms.CheckedListBox();
            this.listBoxRoomSaturday = new System.Windows.Forms.ListBox();
            this.listBoxRoomFriday = new System.Windows.Forms.ListBox();
            this.listBoxRoomThursday = new System.Windows.Forms.ListBox();
            this.listBoxRoomWednesday = new System.Windows.Forms.ListBox();
            this.listBoxRoomTuesday = new System.Windows.Forms.ListBox();
            this.listBoxRoomMonday = new System.Windows.Forms.ListBox();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.Location = new System.Drawing.Point(0, 28);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(180, 20);
            this.roomName.TabIndex = 27;
            this.roomName.TextChanged += new System.EventHandler(this.roomName_TextChanged);
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(380, 41);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownCapacity.TabIndex = 26;
            this.numericUpDownCapacity.ValueChanged += new System.EventHandler(this.numericUpDownCapacity_ValueChanged);
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(377, 18);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(60, 13);
            this.Capacity.TabIndex = 25;
            this.Capacity.Text = "Капацитет";
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRoom.Location = new System.Drawing.Point(516, 330);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(81, 26);
            this.buttonAddRoom.TabIndex = 24;
            this.buttonAddRoom.Text = "Добави";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // checkedListRoomTypes
            // 
            this.checkedListRoomTypes.FormattingEnabled = true;
            this.checkedListRoomTypes.Items.AddRange(new object[] {
            "Лекционна зала",
            "Компютърен кабинет",
            "Проектор",
            "Мрежова лаборатория"});
            this.checkedListRoomTypes.Location = new System.Drawing.Point(211, 13);
            this.checkedListRoomTypes.Name = "checkedListRoomTypes";
            this.checkedListRoomTypes.Size = new System.Drawing.Size(141, 64);
            this.checkedListRoomTypes.TabIndex = 23;
            this.checkedListRoomTypes.SelectedIndexChanged += new System.EventHandler(this.checkedListRoomTypes_SelectedIndexChanged);
            // 
            // listBoxRoomSaturday
            // 
            this.listBoxRoomSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomSaturday.FormattingEnabled = true;
            this.listBoxRoomSaturday.ItemHeight = 18;
            this.listBoxRoomSaturday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomSaturday.Location = new System.Drawing.Point(380, 83);
            this.listBoxRoomSaturday.Name = "listBoxRoomSaturday";
            this.listBoxRoomSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomSaturday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomSaturday.TabIndex = 22;
            this.listBoxRoomSaturday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomSaturday_SelectedIndexChanged);
            // 
            // listBoxRoomFriday
            // 
            this.listBoxRoomFriday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomFriday.FormattingEnabled = true;
            this.listBoxRoomFriday.ItemHeight = 18;
            this.listBoxRoomFriday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomFriday.Location = new System.Drawing.Point(304, 83);
            this.listBoxRoomFriday.Name = "listBoxRoomFriday";
            this.listBoxRoomFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomFriday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomFriday.TabIndex = 21;
            this.listBoxRoomFriday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomFriday_SelectedIndexChanged);
            // 
            // listBoxRoomThursday
            // 
            this.listBoxRoomThursday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomThursday.FormattingEnabled = true;
            this.listBoxRoomThursday.ItemHeight = 18;
            this.listBoxRoomThursday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomThursday.Location = new System.Drawing.Point(228, 83);
            this.listBoxRoomThursday.Name = "listBoxRoomThursday";
            this.listBoxRoomThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomThursday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomThursday.TabIndex = 20;
            this.listBoxRoomThursday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomThursday_SelectedIndexChanged);
            // 
            // listBoxRoomWednesday
            // 
            this.listBoxRoomWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomWednesday.FormattingEnabled = true;
            this.listBoxRoomWednesday.ItemHeight = 18;
            this.listBoxRoomWednesday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomWednesday.Location = new System.Drawing.Point(152, 83);
            this.listBoxRoomWednesday.Name = "listBoxRoomWednesday";
            this.listBoxRoomWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomWednesday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomWednesday.TabIndex = 19;
            this.listBoxRoomWednesday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomWednesday_SelectedIndexChanged);
            // 
            // listBoxRoomTuesday
            // 
            this.listBoxRoomTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomTuesday.FormattingEnabled = true;
            this.listBoxRoomTuesday.ItemHeight = 18;
            this.listBoxRoomTuesday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomTuesday.Location = new System.Drawing.Point(76, 83);
            this.listBoxRoomTuesday.Name = "listBoxRoomTuesday";
            this.listBoxRoomTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomTuesday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomTuesday.TabIndex = 18;
            this.listBoxRoomTuesday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomTuesday_SelectedIndexChanged);
            // 
            // listBoxRoomMonday
            // 
            this.listBoxRoomMonday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoomMonday.FormattingEnabled = true;
            this.listBoxRoomMonday.ItemHeight = 18;
            this.listBoxRoomMonday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxRoomMonday.Location = new System.Drawing.Point(0, 83);
            this.listBoxRoomMonday.Name = "listBoxRoomMonday";
            this.listBoxRoomMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRoomMonday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomMonday.TabIndex = 17;
            this.listBoxRoomMonday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoomMonday_SelectedIndexChanged);
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Items.AddRange(new object[] {
            "200",
            "325",
            "326",
            "500"});
            this.listBoxRooms.Location = new System.Drawing.Point(516, 83);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxRooms.Size = new System.Drawing.Size(51, 238);
            this.listBoxRooms.TabIndex = 28;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // RoomsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.checkedListRoomTypes);
            this.Controls.Add(this.listBoxRoomSaturday);
            this.Controls.Add(this.listBoxRoomFriday);
            this.Controls.Add(this.listBoxRoomThursday);
            this.Controls.Add(this.listBoxRoomWednesday);
            this.Controls.Add(this.listBoxRoomTuesday);
            this.Controls.Add(this.listBoxRoomMonday);
            this.Name = "RoomsTab";
            this.Size = new System.Drawing.Size(601, 385);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.CheckedListBox checkedListRoomTypes;
        private System.Windows.Forms.ListBox listBoxRoomSaturday;
        private System.Windows.Forms.ListBox listBoxRoomFriday;
        private System.Windows.Forms.ListBox listBoxRoomThursday;
        private System.Windows.Forms.ListBox listBoxRoomWednesday;
        private System.Windows.Forms.ListBox listBoxRoomTuesday;
        private System.Windows.Forms.ListBox listBoxRoomMonday;
        private System.Windows.Forms.ListBox listBoxRooms;
    }
}
