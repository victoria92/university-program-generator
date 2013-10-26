namespace UniProgramGen
{
    partial class GroupTab
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
            this.AddGroup = new System.Windows.Forms.Button();
            this.numericUpDownStudents = new System.Windows.Forms.NumericUpDown();
            this.groupName = new System.Windows.Forms.TextBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.size = new System.Windows.Forms.Label();
            this.listBoxSubjectsOfGroups = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // AddGroup
            // 
            this.AddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroup.Location = new System.Drawing.Point(508, 361);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(81, 26);
            this.AddGroup.TabIndex = 24;
            this.AddGroup.Text = "Добави";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // numericUpDownStudents
            // 
            this.numericUpDownStudents.Location = new System.Drawing.Point(265, 152);
            this.numericUpDownStudents.Name = "numericUpDownStudents";
            this.numericUpDownStudents.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownStudents.TabIndex = 23;
            this.numericUpDownStudents.ValueChanged += new System.EventHandler(this.numericUpDownStudents_ValueChanged);
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(15, 36);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(206, 20);
            this.groupName.TabIndex = 22;
            this.groupName.TextChanged += new System.EventHandler(this.groupName_TextChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(440, 27);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(149, 303);
            this.listBoxGroups.TabIndex = 25;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(262, 119);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(80, 13);
            this.size.TabIndex = 26;
            this.size.Text = "Брой студенти";
            // 
            // listBoxSubjectsOfGroups
            // 
            this.listBoxSubjectsOfGroups.FormattingEnabled = true;
            this.listBoxSubjectsOfGroups.Location = new System.Drawing.Point(15, 71);
            this.listBoxSubjectsOfGroups.Name = "listBoxSubjectsOfGroups";
            this.listBoxSubjectsOfGroups.Size = new System.Drawing.Size(210, 316);
            this.listBoxSubjectsOfGroups.TabIndex = 27;
            this.listBoxSubjectsOfGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjectsOfGroups_SelectedIndexChanged);
            // 
            // GroupTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxSubjectsOfGroups);
            this.Controls.Add(this.size);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.numericUpDownStudents);
            this.Controls.Add(this.groupName);
            this.Name = "GroupTab";
            this.Size = new System.Drawing.Size(605, 402);
            this.Load += new System.EventHandler(this.GroupTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.NumericUpDown numericUpDownStudents;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.ListBox listBoxSubjectsOfGroups;
    }
}
