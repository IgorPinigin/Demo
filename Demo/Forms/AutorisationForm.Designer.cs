
namespace Demo.Forms
{
    partial class AutorisationForm
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
            this.CAPTCHA = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCapcha = new System.Windows.Forms.TextBox();
            this.btAutorisation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CAPTCHA
            // 
            this.CAPTCHA.AutoSize = true;
            this.CAPTCHA.Location = new System.Drawing.Point(164, 162);
            this.CAPTCHA.Name = "CAPTCHA";
            this.CAPTCHA.Size = new System.Drawing.Size(35, 13);
            this.CAPTCHA.TabIndex = 0;
            this.CAPTCHA.Text = "label1";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(134, 97);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(134, 139);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbCapcha
            // 
            this.tbCapcha.Location = new System.Drawing.Point(136, 178);
            this.tbCapcha.Name = "tbCapcha";
            this.tbCapcha.Size = new System.Drawing.Size(100, 20);
            this.tbCapcha.TabIndex = 3;
            // 
            // btAutorisation
            // 
            this.btAutorisation.Location = new System.Drawing.Point(147, 224);
            this.btAutorisation.Name = "btAutorisation";
            this.btAutorisation.Size = new System.Drawing.Size(75, 23);
            this.btAutorisation.TabIndex = 4;
            this.btAutorisation.Text = "Войти";
            this.btAutorisation.UseVisualStyleBackColor = true;
            this.btAutorisation.Click += new System.EventHandler(this.btAutorisation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите 4х значный код выше";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите свой ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите свой пароль";
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAutorisation);
            this.Controls.Add(this.tbCapcha);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.CAPTCHA);
            this.Name = "AutorisationForm";
            this.Text = "AutorisationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CAPTCHA;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCapcha;
        private System.Windows.Forms.Button btAutorisation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}