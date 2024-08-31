
namespace Lab1
{
    partial class FormCreateChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tCardName = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tBirthday = new System.Windows.Forms.DateTimePicker();
            this.lNoName = new System.Windows.Forms.Label();
            this.lNoCardName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер карты";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(195, 93);
            this.tName.Margin = new System.Windows.Forms.Padding(4);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(200, 22);
            this.tName.TabIndex = 3;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // tCardName
            // 
            this.tCardName.Location = new System.Drawing.Point(195, 206);
            this.tCardName.Margin = new System.Windows.Forms.Padding(4);
            this.tCardName.MaxLength = 5;
            this.tCardName.Name = "tCardName";
            this.tCardName.Size = new System.Drawing.Size(200, 22);
            this.tCardName.TabIndex = 5;
            this.tCardName.TextChanged += new System.EventHandler(this.tCardName_TextChanged);
            this.tCardName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCardName_KeyPress);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(50, 304);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(92, 33);
            this.bAccept.TabIndex = 6;
            this.bAccept.Text = "Принять";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            this.bAccept.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bAccept_MouseMove);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(195, 304);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(92, 33);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tBirthday
            // 
            this.tBirthday.Location = new System.Drawing.Point(195, 151);
            this.tBirthday.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.tBirthday.Name = "tBirthday";
            this.tBirthday.Size = new System.Drawing.Size(200, 22);
            this.tBirthday.TabIndex = 8;
            this.tBirthday.Value = new System.DateTime(2021, 11, 26, 0, 0, 0, 0);
            // 
            // lNoName
            // 
            this.lNoName.AutoSize = true;
            this.lNoName.ForeColor = System.Drawing.Color.Red;
            this.lNoName.Location = new System.Drawing.Point(437, 96);
            this.lNoName.Name = "lNoName";
            this.lNoName.Size = new System.Drawing.Size(0, 17);
            this.lNoName.TabIndex = 9;
            // 
            // lNoCardName
            // 
            this.lNoCardName.AutoSize = true;
            this.lNoCardName.ForeColor = System.Drawing.Color.Red;
            this.lNoCardName.Location = new System.Drawing.Point(437, 211);
            this.lNoCardName.Name = "lNoCardName";
            this.lNoCardName.Size = new System.Drawing.Size(0, 17);
            this.lNoCardName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(324, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Создание записи";
            // 
            // FormCreateChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lNoCardName);
            this.Controls.Add(this.lNoName);
            this.Controls.Add(this.tBirthday);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tCardName);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateChange";
            this.Text = "Создание/изменение записей";
            this.Activated += new System.EventHandler(this.FormCreateChange_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCreateChange_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tCardName;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DateTimePicker tBirthday;
        private System.Windows.Forms.Label lNoName;
        private System.Windows.Forms.Label lNoCardName;
        private System.Windows.Forms.Label label4;
    }
}