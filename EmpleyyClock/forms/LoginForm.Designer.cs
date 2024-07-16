namespace EmployeeClock.forms
{
    partial class LoginForm
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
            buttonChangePassword = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxID = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonEntrance
            // 
            buttonEntrance.Location = new Point(243, 258);
            buttonEntrance.Name = "buttonEntrance";
            buttonEntrance.Size = new Size(299, 59);
            buttonEntrance.TabIndex = 2;
            buttonEntrance.Text = "כניסה";
            buttonEntrance.UseVisualStyleBackColor = true;
            buttonEntrance.Click += ButtonEntrance_Click;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Location = new Point(243, 323);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(299, 59);
            buttonChangePassword.TabIndex = 3;
            buttonChangePassword.Text = "החלפת סיסמה";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 47);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 2;
            label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 150);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 3;
            label2.Text = "סיסמה";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(219, 95);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(348, 47);
            textBoxID.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(219, 194);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(348, 47);
            textBoxPassword.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChangePassword);
            Controls.Add(buttonEntrance);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrance;
        private Button buttonChangePassword;
        private Label label1;
        private Label label2;
        private TextBox textBoxID;
        private TextBox textBoxPassword;
    }
}