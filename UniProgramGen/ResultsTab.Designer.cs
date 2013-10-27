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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTeachers = new System.Windows.Forms.GroupBox();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).BeginInit();
            this.splitResults.Panel1.SuspendLayout();
            this.splitResults.Panel2.SuspendLayout();
            this.splitResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Location = new System.Drawing.Point(0, 380);
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
            this.splitResults.Location = new System.Drawing.Point(0, 0);
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
            // groupBoxTeachers
            // 
            this.groupBoxTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTeachers.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTeachers.Name = "groupBoxTeachers";
            this.groupBoxTeachers.Size = new System.Drawing.Size(215, 381);
            this.groupBoxTeachers.TabIndex = 0;
            this.groupBoxTeachers.TabStop = false;
            this.groupBoxTeachers.Text = "Преподаватели";
            // 
            // groupBoxRooms
            // 
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
            this.groupBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGroups.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(213, 381);
            this.groupBoxGroups.TabIndex = 0;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Групи";
            // 
            // ResultsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.splitResults);
            this.Name = "ResultsTab";
            this.Size = new System.Drawing.Size(650, 450);
            this.splitResults.Panel1.ResumeLayout(false);
            this.splitResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitResults)).EndInit();
            this.splitResults.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.SplitContainer splitResults;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxTeachers;
        private System.Windows.Forms.GroupBox groupBoxRooms;
        private System.Windows.Forms.GroupBox groupBoxGroups;
    }
}
