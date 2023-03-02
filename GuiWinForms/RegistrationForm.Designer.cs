
namespace GuiWinForms
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.UserPassBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.RegistrationButton);
            this.panel1.Controls.Add(this.ErrLable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.UserPassBox);
            this.panel1.Controls.Add(this.UserNameBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 172);
            this.panel1.TabIndex = 0;
            // 
            // ErrLable
            // 
            this.ErrLable.AutoSize = true;
            this.ErrLable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrLable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ErrLable.Location = new System.Drawing.Point(29, 29);
            this.ErrLable.Name = "ErrLable";
            this.ErrLable.Size = new System.Drawing.Size(85, 15);
            this.ErrLable.TabIndex = 4;
            this.ErrLable.Text = "Здравствуйте!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Здравствуйте!";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(32, 99);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(180, 23);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UserPassBox
            // 
            this.UserPassBox.ForeColor = System.Drawing.Color.Gray;
            this.UserPassBox.Location = new System.Drawing.Point(32, 73);
            this.UserPassBox.Name = "UserPassBox";
            this.UserPassBox.Size = new System.Drawing.Size(180, 20);
            this.UserPassBox.TabIndex = 1;
            this.UserPassBox.Text = "Пароль";
            this.UserPassBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserPassBox_MouseClick);
            // 
            // UserNameBox
            // 
            this.UserNameBox.ForeColor = System.Drawing.Color.Gray;
            this.UserNameBox.Location = new System.Drawing.Point(32, 47);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(180, 20);
            this.UserNameBox.TabIndex = 0;
            this.UserNameBox.Text = "Имя пользователя";
            this.UserNameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserName_MouseClick);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(32, 128);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(180, 23);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 172);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.Text = "Вход";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox UserPassBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrLable;
        private System.Windows.Forms.Button RegistrationButton;
    }
}