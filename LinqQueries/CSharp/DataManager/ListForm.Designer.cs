namespace CSharp.DataManager
{
    partial class ListForm
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
            components = new System.ComponentModel.Container();
            lstPeople = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmsEdit = new ToolStripMenuItem();
            cmsDelete = new ToolStripMenuItem();
            cmsRefresh = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstPeople
            // 
            lstPeople.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstPeople.ContextMenuStrip = contextMenuStrip1;
            lstPeople.FullRowSelect = true;
            lstPeople.GridLines = true;
            lstPeople.Location = new Point(23, 63);
            lstPeople.Name = "lstPeople";
            lstPeople.Size = new Size(783, 364);
            lstPeople.TabIndex = 0;
            lstPeople.UseCompatibleStateImageBehavior = false;
            lstPeople.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FirstName";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "LastName";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mail";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone";
            columnHeader5.Width = 200;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmsEdit, cmsDelete, cmsRefresh });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 92);
            // 
            // cmsEdit
            // 
            cmsEdit.Image = Properties.Resources.edit;
            cmsEdit.Name = "cmsEdit";
            cmsEdit.Size = new Size(180, 22);
            cmsEdit.Text = "Edit";
            cmsEdit.Click += cmsEdit_Click;
            // 
            // cmsDelete
            // 
            cmsDelete.Image = Properties.Resources.delete;
            cmsDelete.Name = "cmsDelete";
            cmsDelete.Size = new Size(180, 22);
            cmsDelete.Text = "Delete";
            cmsDelete.Click += cmsDelete_Click;
            // 
            // cmsRefresh
            // 
            cmsRefresh.Image = Properties.Resources.refresh_page_option;
            cmsRefresh.Name = "cmsRefresh";
            cmsRefresh.Size = new Size(180, 22);
            cmsRefresh.Text = "Refresh";
            cmsRefresh.Click += cmsRefresh_Click;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 450);
            Controls.Add(lstPeople);
            Name = "ListForm";
            Text = "ListForm";
            FormClosing += ListForm_FormClosing;
            Load += ListForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lstPeople;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cmsEdit;
        private ToolStripMenuItem cmsDelete;
        private ToolStripMenuItem cmsRefresh;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}