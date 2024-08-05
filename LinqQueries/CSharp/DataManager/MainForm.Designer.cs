namespace CSharp.DataManager
{
    partial class MainForm
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
            btnSave = new Button();
            btnSearch = new Button();
            btnList = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(90, 99, 156);
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(23, 69);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 353);
            btnSave.TabIndex = 0;
            btnSave.Text = "Insert Record";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(55, 183, 195);
            btnSearch.Font = new Font("Segoe UI", 20F);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(253, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(224, 174);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(255, 64, 125);
            btnList.Font = new Font("Segoe UI", 20F);
            btnList.ForeColor = SystemColors.ControlLightLight;
            btnList.Location = new Point(253, 248);
            btnList.Name = "btnList";
            btnList.Size = new Size(224, 174);
            btnList.TabIndex = 2;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(btnList);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Name = "MainForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnSearch;
        private Button btnList;
    }
}