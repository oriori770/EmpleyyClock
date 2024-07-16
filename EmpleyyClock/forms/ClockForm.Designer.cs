namespace EmpleyyClock.forms
{
    partial class ClockForm
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
            buttonEntrance = new Button();
            buttonExit = new Button();
            labelForLastExitDate = new Label();
            linkLabelCancel = new LinkLabel();
            label99 = new Label();
            labelLastEntryDate = new Label();
            labeForLastEntryDate = new Label();
            labelLastExitDate = new Label();
            EmployeeNat = new Label();
            SuspendLayout();
            // 
            // buttonEntrance
            // 
            buttonEntrance.Location = new Point(612, 566);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(272, 232);
            buttonEntrance.TabIndex = 1;
            buttonEntrance.Text = "כניסה";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += buttonEntrance_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(138, 566);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(272, 232);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "יְצִיאָה";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelForLastExitDate
            // 
            labelForLastExitDate.AutoSize = true;
            labelForLastExitDate.Location = new Point(382, 354);
            labelForLastExitDate.Name = "labelForLastExitDate";
            labelForLastExitDate.Size = new Size(262, 41);
            labelForLastExitDate.TabIndex = 4;
            labelForLastExitDate.Text = "תאריך יציאה אחרון";
            // 
            // linkLabelCancel
            // 
            linkLabelCancel.AutoSize = true;
            linkLabelCancel.Location = new Point(438, 474);
            linkLabelCancel.Name = "linkLabelCancel";
            linkLabelCancel.Size = new Size(88, 41);
            linkLabelCancel.TabIndex = 5;
            linkLabelCancel.TabStop = true;
            linkLabelCancel.Text = "ביטול";
            linkLabelCancel.LinkClicked += linkLabelCancel_LinkClicked;
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Location = new Point(598, 85);
            label99.Name = "label99";
            label99.Size = new Size(143, 41);
            label99.TabIndex = 7;
            label99.Text = "זהות עובד";
            // 
            // labelLastEntryDate
            // 
            labelLastEntryDate.AutoSize = true;
            labelLastEntryDate.Location = new Point(459, 268);
            labelLastEntryDate.Name = "labelLastEntryDate";
            labelLastEntryDate.Size = new Size(138, 41);
            labelLastEntryDate.TabIndex = 8;
            labelLastEntryDate.Text = "01/01/01";
            // 
            // labeForLastEntryDate
            // 
            labeForLastEntryDate.AutoSize = true;
            labeForLastEntryDate.Location = new Point(382, 195);
            labeForLastEntryDate.Name = "labeForLastEntryDate";
            labeForLastEntryDate.Size = new Size(265, 41);
            labeForLastEntryDate.TabIndex = 9;
            labeForLastEntryDate.Text = "תאריך כניסה אחרון";
            // 
            // labelLastExitDate
            // 
            labelLastExitDate.AutoSize = true;
            labelLastExitDate.Location = new Point(450, 414);
            labelLastExitDate.Name = "labelLastExitDate";
            labelLastExitDate.Size = new Size(138, 41);
            labelLastExitDate.TabIndex = 10;
            labelLastExitDate.Text = "01/01/01";
            // 
            // EmployeeNat
            // 
            EmployeeNat.AutoSize = true;
            EmployeeNat.Location = new Point(205, 85);
            EmployeeNat.Name = "EmployeeNat";
            EmployeeNat.Size = new Size(143, 41);
            EmployeeNat.TabIndex = 11;
            EmployeeNat.Text = "זהות עובד";
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 905);
            Controls.Add(EmployeeNat);
            Controls.Add(labelLastExitDate);
            Controls.Add(labeForLastEntryDate);
            Controls.Add(labelLastEntryDate);
            Controls.Add(label99);
            Controls.Add(linkLabelCancel);
            Controls.Add(labelForLastExitDate);
            Controls.Add(buttonExit);
            Controls.Add(buttonEntrance);
            Name = "ClockForm";
            Text = "ClockForm";
            FormClosing += ClockForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrance;
        private Button buttonExit;
        private Label labelForLastExitDate;
        private LinkLabel linkLabelCancel;
        private Label label99;
        private Label labelLastEntryDate;
        private Label labeForLastEntryDate;
        private Label labelLastExitDate;
        private Label EmployeeNat;
    }
}