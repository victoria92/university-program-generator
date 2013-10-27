namespace UniProgramGen
{
    partial class ResultsTab
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
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.splitResults = new System.Windows.Forms.SplitContainer();
            this.groupBoxTeachers = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).BeginInit();
            this.splitResults.Panel1.SuspendLayout();
            this.splitResults.Panel2.SuspendLayout();
            this.splitResults.SuspendLayout();
            this.groupBoxTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxRooms.SuspendLayout();
            this.groupBoxGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.buttonGenerate);
            this.groupBoxActions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(650, 70);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // splitResults
            // 
            this.splitResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitResults.Location = new System.Drawing.Point(0, 70);
            this.splitResults.Name = "splitResults";
            // 
            // splitResults.Panel1
            // 
            this.splitResults.Panel1.Controls.Add(this.groupBoxTeachers);
            // 
            // splitResults.Panel2
            // 
            this.splitResults.Panel2.Controls.Add(this.splitContainer1);
            this.splitResults.Size = new System.Drawing.Size(650, 381);
            this.splitResults.SplitterDistance = 215;
            this.splitResults.TabIndex = 2;
            // 
            // groupBoxTeachers
            // 
            this.groupBoxTeachers.Controls.Add(this.listBoxTeachers);
            this.groupBoxTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTeachers.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTeachers.Name = "groupBoxTeachers";
            this.groupBoxTeachers.Size = new System.Drawing.Size(215, 381);
            this.groupBoxTeachers.TabIndex = 0;
            this.groupBoxTeachers.TabStop = false;
            this.groupBoxTeachers.Text = "Преподаватели";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxRooms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxGroups);
            this.splitContainer1.Size = new System.Drawing.Size(431, 381);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxRooms
            // 
            this.groupBoxRooms.Controls.Add(this.listBoxRooms);
            this.groupBoxRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRooms.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(214, 381);
            this.groupBoxRooms.TabIndex = 0;
            this.groupBoxRooms.TabStop = false;
            this.groupBoxRooms.Text = "Стаи";
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.listBoxGroups);
            this.groupBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGroups.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(213, 381);
            this.groupBoxGroups.TabIndex = 0;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Групи";
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(3, 16);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(209, 362);
            this.listBoxTeachers.TabIndex = 0;
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(3, 16);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(208, 362);
            this.listBoxRooms.TabIndex = 0;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(3, 16);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(207, 362);
            this.listBoxGroups.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(440, 19);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(204, 45);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Генерирай Програма";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // ResultsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.splitResults);
            this.Name = "ResultsTab";
            this.Size = new System.Drawing.Size(650, 450);
            this.groupBoxActions.ResumeLayout(false);
            this.splitResults.Panel1.ResumeLayout(false);
            this.splitResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).EndInit();
            this.splitResults.ResumeLayout(false);
            this.groupBoxTeachers.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxRooms.ResumeLayout(false);
            this.groupBoxGroups.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.SplitContainer splitResults;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxTeachers;
        private System.Windows.Forms.GroupBox groupBoxRooms;
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonGenerate;
    }
}
