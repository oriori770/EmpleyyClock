namespace EmpleyyClock.forms
{
    partial class PasswordChangeForm
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
            label3 = new Label();
            linkLabelCancelation = new LinkLabel();
            buttonConfirm = new Button();
            textBoxID = new TextBox();
            textBoxNewPasswordAgain = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxOldPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            labelNewPasswordAgain = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 177);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(192, 41);
            label3.TabIndex = 2;
            label3.Text = "סיסמה חדשה";
            // 
            // linkLabelCancelation
            // 
            linkLabelCancelation.AutoSize = true;
            linkLabelCancelation.Location = new Point(595, 316);
            linkLabelCancelation.Name = "linkLabelCancelation";
            linkLabelCancelation.Size = new Size(88, 41);
            linkLabelCancelation.TabIndex = 5;
            linkLabelCancelation.TabStop = true;
            linkLabelCancelation.Text = "ביטול";
            linkLabelCancelation.LinkClicked += linkLabelCancelation_LinkClicked;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(112, 316);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(320, 58);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "ביצוע החלפת סיסמה";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(112, 20);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(320, 47);
            textBoxID.TabIndex = 0;
            // 
            // textBoxNewPasswordAgain
            // 
            textBoxNewPasswordAgain.Location = new Point(112, 249);
            textBoxNewPasswordAgain.Name = "textBoxNewPasswordAgain";
            textBoxNewPasswordAgain.Size = new Size(320, 47);
            textBoxNewPasswordAgain.TabIndex = 3;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(112, 177);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(320, 47);
            textBoxNewPassword.TabIndex = 2;
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Location = new Point(112, 98);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.Size = new Size(320, 47);
            textBoxOldPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 46);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(169, 41);
            label4.TabIndex = 11;
            label4.Text = "תעודת זהות";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(567, 98);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(178, 41);
            label5.TabIndex = 12;
            label5.Text = "סיסמה ישנה";
            // 
            // labelNewPasswordAgain
            // 
            labelNewPasswordAgain.AutoSize = true;
            labelNewPasswordAgain.Location = new Point(469, 249);
            labelNewPasswordAgain.Name = "labelNewPasswordAgain";
            labelNewPasswordAgain.RightToLeft = RightToLeft.Yes;
            labelNewPasswordAgain.Size = new Size(276, 41);
            labelNewPasswordAgain.TabIndex = 13;
            labelNewPasswordAgain.Text = "אישור סיסמה חדשה";
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNewPasswordAgain);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxOldPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxNewPasswordAgain);
            Controls.Add(textBoxID);
            Controls.Add(buttonConfirm);
            Controls.Add(linkLabelCancelation);
            Controls.Add(label3);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            FormClosing += PasswordChangeForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Label label2;
        private Label label3;
        private LinkLabel linkLabelCancelation;
        private Button buttonConfirm;
        private TextBox textBoxID;
        private TextBox textBoxNewPasswordAgain;
        private TextBox textBoxNewPassword;
        private TextBox textBoxOldPassword;
        private Label label4;
        private Label label5;
        private Label labelNewPasswordAgain;
    }
}