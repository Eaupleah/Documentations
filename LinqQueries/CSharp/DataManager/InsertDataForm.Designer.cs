namespace CSharp.DataManager
{
    partial class InsertDataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbSavePerson = new GroupBox();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtMail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Location = new Point(23, 63);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Size = new Size(523, 364);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(138, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(379, 56);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(24, 205);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(24, 165);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 6;
            label3.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 125);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 5;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(24, 82);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(128, 205);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(379, 34);
            txtPhone.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 15F);
            txtMail.Location = new Point(128, 165);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(379, 34);
            txtMail.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(128, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(379, 34);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(128, 82);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(379, 34);
            txtFirstName.TabIndex = 0;
            // 
            // InsertDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(grbSavePerson);
            Name = "InsertDataForm";
            Text = "Data Insertion Form";
            FormClosed += InsertDataForm_FormClosed;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtMail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
