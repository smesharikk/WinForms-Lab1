
namespace Lab1
{
    partial class FormLogin
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
            this.cAdmin = new System.Windows.Forms.ComboBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.lWrongPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cAdmin
            // 
            this.cAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAdmin.FormattingEnabled = true;
            this.cAdmin.Location = new System.Drawing.Point(130, 110);
            this.cAdmin.Name = "cAdmin";
            this.cAdmin.Size = new System.Drawing.Size(121, 24);
            this.cAdmin.TabIndex = 0;
            this.cAdmin.SelectedIndexChanged += new System.EventHandler(this.cAdmin_SelectedIndexChanged);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(60, 246);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(176, 246);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(130, 163);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(121, 22);
            this.tPassword.TabIndex = 3;
            // 
            // lWrongPassword
            // 
            this.lWrongPassword.AutoSize = true;
            this.lWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.lWrongPassword.Location = new System.Drawing.Point(276, 168);
            this.lWrongPassword.Name = "lWrongPassword";
            this.lWrongPassword.Size = new System.Drawing.Size(0, 17);
            this.lWrongPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(74, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Авторизация";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lWrongPassword);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cAdmin);
            this.Name = "FormLogin";
            this.Text = "Выбор логина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cAdmin;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label lWrongPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}