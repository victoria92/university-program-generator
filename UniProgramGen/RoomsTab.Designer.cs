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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.groupBoxRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomName.BackColor = System.Drawing.SystemColors.Window;
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roomName.Location = new System.Drawing.Point(190, 16);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(457, 29);
            this.roomName.TabIndex = 27;
            this.roomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCapacity.Location = new System.Drawing.Point(364, 396);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownCapacity.TabIndex = 26;
            // 
            // Capacity
            // 
            this.Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(361, 380);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(60, 13);
            this.Capacity.TabIndex = 25;
            this.Capacity.Text = "Капацитет";
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRoom.Location = new System.Drawing.Point(566, 418);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(81, 26);
            this.buttonAddRoom.TabIndex = 24;
            this.buttonAddRoom.Text = "Добави";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // checkedListRoomTypes
            // 
            this.checkedListRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListRoomTypes.CheckOnClick = true;
            this.checkedListRoomTypes.FormattingEnabled = true;
            this.checkedListRoomTypes.Items.AddRange(new object[] {
            "Лекционна зала",
            "Компютърен кабинет",
            "Проектор",
            "Мрежова лаборатория"});
            this.checkedListRoomTypes.Location = new System.Drawing.Point(193, 364);
            this.checkedListRoomTypes.Name = "checkedListRoomTypes";
            this.checkedListRoomTypes.Size = new System.Drawing.Size(141, 64);
            this.checkedListRoomTypes.TabIndex = 23;
            // 
            // listBoxRoomSaturday
            // 
            this.listBoxRoomSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomSaturday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomSaturday.Location = new System.Drawing.Point(572, 74);
            this.listBoxRoomSaturday.Name = "listBoxRoomSaturday";
            this.listBoxRoomSaturday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomSaturday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomSaturday.TabIndex = 22;
            this.listBoxRoomSaturday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRoomFriday
            // 
            this.listBoxRoomFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomFriday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomFriday.Location = new System.Drawing.Point(496, 74);
            this.listBoxRoomFriday.Name = "listBoxRoomFriday";
            this.listBoxRoomFriday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomFriday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomFriday.TabIndex = 21;
            this.listBoxRoomFriday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRoomThursday
            // 
            this.listBoxRoomThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomThursday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomThursday.Location = new System.Drawing.Point(420, 74);
            this.listBoxRoomThursday.Name = "listBoxRoomThursday";
            this.listBoxRoomThursday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomThursday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomThursday.TabIndex = 20;
            this.listBoxRoomThursday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRoomWednesday
            // 
            this.listBoxRoomWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomWednesday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomWednesday.Location = new System.Drawing.Point(344, 74);
            this.listBoxRoomWednesday.Name = "listBoxRoomWednesday";
            this.listBoxRoomWednesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomWednesday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomWednesday.TabIndex = 19;
            this.listBoxRoomWednesday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRoomTuesday
            // 
            this.listBoxRoomTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomTuesday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomTuesday.Location = new System.Drawing.Point(268, 74);
            this.listBoxRoomTuesday.Name = "listBoxRoomTuesday";
            this.listBoxRoomTuesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomTuesday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomTuesday.TabIndex = 18;
            this.listBoxRoomTuesday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRoomMonday
            // 
            this.listBoxRoomMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRoomMonday.BackColor = System.Drawing.SystemColors.Window;
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
            this.listBoxRoomMonday.Location = new System.Drawing.Point(192, 74);
            this.listBoxRoomMonday.Name = "listBoxRoomMonday";
            this.listBoxRoomMonday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRoomMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRoomMonday.Size = new System.Drawing.Size(70, 274);
            this.listBoxRoomMonday.TabIndex = 17;
            this.listBoxRoomMonday.SelectedIndexChanged += new System.EventHandler(this.listBoxRoom_SelectedIndexChanged);
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(3, 16);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxRooms.Size = new System.Drawing.Size(177, 428);
            this.listBoxRooms.TabIndex = 28;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Понеделник";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Вторник";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Сряда";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Четвъртък";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Петък";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Събота";
            // 
            // groupBoxRooms
            // 
            this.groupBoxRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRooms.Controls.Add(this.listBoxRooms);
            this.groupBoxRooms.Location = new System.Drawing.Point(4, 0);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(183, 447);
            this.groupBoxRooms.TabIndex = 35;
            this.groupBoxRooms.TabStop = false;
            this.groupBoxRooms.Text = "Стаи";
            // 
            // RoomsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.groupBoxRooms.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxRooms;
    }
}
