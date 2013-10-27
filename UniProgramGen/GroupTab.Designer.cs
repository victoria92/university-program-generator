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
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.labelSubjectsOfGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).BeginInit();
            this.groupBoxGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddGroup
            // 
            this.AddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGroup.Location = new System.Drawing.Point(566, 418);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(81, 26);
            this.AddGroup.TabIndex = 24;
            this.AddGroup.Text = "Добави";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // numericUpDownStudents
            // 
            this.numericUpDownStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownStudents.Location = new System.Drawing.Point(193, 84);
            this.numericUpDownStudents.Name = "numericUpDownStudents";
            this.numericUpDownStudents.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownStudents.TabIndex = 23;
            // 
            // groupName
            // 
            this.groupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupName.Location = new System.Drawing.Point(190, 16);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(457, 29);
            this.groupName.TabIndex = 22;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(3, 16);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxGroups.Size = new System.Drawing.Size(177, 428);
            this.listBoxGroups.TabIndex = 25;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // size
            // 
            this.size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(190, 68);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(80, 13);
            this.size.TabIndex = 26;
            this.size.Text = "Брой студенти";
            // 
            // listBoxSubjectsOfGroups
            // 
            this.listBoxSubjectsOfGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSubjectsOfGroups.FormattingEnabled = true;
            this.listBoxSubjectsOfGroups.Location = new System.Drawing.Point(322, 84);
            this.listBoxSubjectsOfGroups.Name = "listBoxSubjectsOfGroups";
            this.listBoxSubjectsOfGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSubjectsOfGroups.Size = new System.Drawing.Size(325, 316);
            this.listBoxSubjectsOfGroups.TabIndex = 27;
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGroups.Controls.Add(this.listBoxGroups);
            this.groupBoxGroups.Location = new System.Drawing.Point(4, 0);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(183, 447);
            this.groupBoxGroups.TabIndex = 28;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Групи";
            // 
            // labelSubjectsOfGroups
            // 
            this.labelSubjectsOfGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubjectsOfGroups.AutoSize = true;
            this.labelSubjectsOfGroups.Location = new System.Drawing.Point(319, 68);
            this.labelSubjectsOfGroups.Name = "labelSubjectsOfGroups";
            this.labelSubjectsOfGroups.Size = new System.Drawing.Size(57, 13);
            this.labelSubjectsOfGroups.TabIndex = 29;
            this.labelSubjectsOfGroups.Text = "Хорариум";
            // 
            // GroupTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSubjectsOfGroups);
            this.Controls.Add(this.groupBoxGroups);
            this.Controls.Add(this.listBoxSubjectsOfGroups);
            this.Controls.Add(this.size);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.numericUpDownStudents);
            this.Controls.Add(this.groupName);
            this.Name = "GroupTab";
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).EndInit();
            this.groupBoxGroups.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.Label labelSubjectsOfGroups;
    }
}
