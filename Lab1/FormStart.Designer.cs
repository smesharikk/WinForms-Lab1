
namespace Lab1
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listNote = new System.Windows.Forms.ListBox();
            this.bCreateNewNote = new System.Windows.Forms.Button();
            this.bСhangeNote = new System.Windows.Forms.Button();
            this.bDeleteNote = new System.Windows.Forms.Button();
            this.lnotchoose = new System.Windows.Forms.Label();
            this.lnotchoose1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listNote
            // 
            this.listNote.FormattingEnabled = true;
            this.listNote.ItemHeight = 16;
            this.listNote.Location = new System.Drawing.Point(47, 56);
            this.listNote.Margin = new System.Windows.Forms.Padding(4);
            this.listNote.Name = "listNote";
            this.listNote.Size = new System.Drawing.Size(352, 420);
            this.listNote.TabIndex = 0;
            this.listNote.Click += new System.EventHandler(this.listNote_Click);
            // 
            // bCreateNewNote
            // 
            this.bCreateNewNote.Location = new System.Drawing.Point(485, 196);
            this.bCreateNewNote.Margin = new System.Windows.Forms.Padding(4);
            this.bCreateNewNote.Name = "bCreateNewNote";
            this.bCreateNewNote.Size = new System.Drawing.Size(237, 28);
            this.bCreateNewNote.TabIndex = 1;
            this.bCreateNewNote.Text = "Создать новую запись";
            this.bCreateNewNote.UseVisualStyleBackColor = true;
            this.bCreateNewNote.Click += new System.EventHandler(this.bCreateNewNote_Click);
            // 
            // bСhangeNote
            // 
            this.bСhangeNote.Location = new System.Drawing.Point(485, 265);
            this.bСhangeNote.Margin = new System.Windows.Forms.Padding(4);
            this.bСhangeNote.Name = "bСhangeNote";
            this.bСhangeNote.Size = new System.Drawing.Size(237, 28);
            this.bСhangeNote.TabIndex = 2;
            this.bСhangeNote.Text = "Изменить выбранную запись";
            this.bСhangeNote.UseVisualStyleBackColor = true;
            this.bСhangeNote.Click += new System.EventHandler(this.bСhangeNote_Click);
            // 
            // bDeleteNote
            // 
            this.bDeleteNote.Location = new System.Drawing.Point(485, 338);
            this.bDeleteNote.Margin = new System.Windows.Forms.Padding(4);
            this.bDeleteNote.Name = "bDeleteNote";
            this.bDeleteNote.Size = new System.Drawing.Size(237, 28);
            this.bDeleteNote.TabIndex = 3;
            this.bDeleteNote.Text = "Удалить выбранную запись";
            this.bDeleteNote.UseVisualStyleBackColor = true;
            this.bDeleteNote.Click += new System.EventHandler(this.bDeleteNote_Click);
            // 
            // lnotchoose
            // 
            this.lnotchoose.AutoSize = true;
            this.lnotchoose.ForeColor = System.Drawing.Color.Red;
            this.lnotchoose.Location = new System.Drawing.Point(482, 297);
            this.lnotchoose.Name = "lnotchoose";
            this.lnotchoose.Size = new System.Drawing.Size(0, 17);
            this.lnotchoose.TabIndex = 4;
            // 
            // lnotchoose1
            // 
            this.lnotchoose1.AutoSize = true;
            this.lnotchoose1.ForeColor = System.Drawing.Color.Red;
            this.lnotchoose1.Location = new System.Drawing.Point(482, 375);
            this.lnotchoose1.Name = "lnotchoose1";
            this.lnotchoose1.Size = new System.Drawing.Size(0, 17);
            this.lnotchoose1.TabIndex = 5;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 554);
            this.Controls.Add(this.lnotchoose1);
            this.Controls.Add(this.lnotchoose);
            this.Controls.Add(this.bDeleteNote);
            this.Controls.Add(this.bСhangeNote);
            this.Controls.Add(this.bCreateNewNote);
            this.Controls.Add(this.listNote);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStart";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNote;
        private System.Windows.Forms.Button bCreateNewNote;
        private System.Windows.Forms.Button bСhangeNote;
        private System.Windows.Forms.Button bDeleteNote;
        private System.Windows.Forms.Label lnotchoose;
        private System.Windows.Forms.Label lnotchoose1;
    }
}

