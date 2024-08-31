using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormCreateChange : Form
    {
        string StartCardName = "";
        Person p = new Person();
        Boolean IsChange = false;
        public FormCreateChange(InterfacePerson person)
        {
            InitializeComponent();

            tBirthday.MaxDate = DateTime.Today;
            tBirthday.Value = DateTime.Today;
            if (person != null) //Заполнение полей, если была нажата кнопка изменения записи
            {
                tName.Text = person.Name;
                tBirthday.Value = person.Birthday;
                tCardName.Text = person.CardName;
                StartCardName = person.CardName;
                tBirthday.Enabled = false;
                tCardName.Enabled = false;
                p = (Person)person;
                IsChange = true;
                label4.Text = "Изменение записи";
            }
        }

        private void tCardName_KeyPress(object sender, KeyPressEventArgs e) //пользователь может вводить только цифры в textbox номера карты
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void bAccept_Click(object sender, EventArgs e) //Если нажата кнопка принять
        {
                lNoName.Text = "";
                lNoCardName.Text = "";
       
                if ((string.IsNullOrEmpty(tName.Text) == false) && (string.IsNullOrEmpty(tCardName.Text) == false) && (Regex.IsMatch(tCardName.Text, "[0-9]{5}")))
                {
                    p.Name = tName.Text;
                    p.Birthday = tBirthday.Value;
                    p.CardName = tCardName.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(tName.Text) == true)
                    {
                        lNoName.Text = "Не введено имя";
                    }
                    if (string.IsNullOrEmpty(tCardName.Text) == true)
                    {
                        lNoCardName.Text = "Не введен номер карты";
                    }
                    else if (Regex.IsMatch(tCardName.Text, "[0-9]{5}")==false)
                    {
                        lNoCardName.Text = "Номер карты должен содержать 5 цифр";
                    }
                }
        }
        public InterfacePerson getPerson()
        {
            return p;
        }

        private void bCancel_Click(object sender, EventArgs e)//Нажата кнопка отменить
        {
            this.Close();
        }

        private void tCardName_TextChanged(object sender, EventArgs e)//Отображение корректности ввода номера карты
        {
            if (Regex.IsMatch(tCardName.Text, "[0-9]{5}")==false)
            {
                tCardName.ForeColor = Color.Red;
            }
            else tCardName.ForeColor = Color.Green;
            lNoCardName.Text = "";
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            lNoName.Text = "";
        }
        public Boolean flagRightPassword=false;
        private void FormCreateChange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.L && IsChange==true)//При нажатии спец. клавиш открываеться окно авторизации
            {
                FormLogin fLogin = new FormLogin(this);
                fLogin.Show();
            }
        }
        private void FormCreateChange_Activated(object sender, EventArgs e)
        {
            if (flagRightPassword)
            {

                tCardName.Enabled = true;
                tBirthday.Enabled = true;
                this.BackColor = Color.Aqua;
                tName.BackColor = Color.Yellow;
                tCardName.BackColor = Color.Yellow;
                bAccept.BackColor = Color.GreenYellow;
                bCancel.BackColor = Color.OrangeRed;
            }

        }
        private void bAccept_MouseMove(object sender, MouseEventArgs e) //Если пользователь авторизован как админ и изменил номер карты, то кнопка принять начинает убегать
        {
            if ((this.BackColor != Color.Aqua) || (tCardName.Text == StartCardName)) return;

            int cY = Cursor.Position.Y - this.Top - 30;
            int cX=Cursor.Position.X-this.Left-4;

            if ((cX <= bAccept.Location.X + bAccept.Size.Width / 2) && (cY <= bAccept.Location.Y + bAccept.Size.Height / 2))
            {
                if ((bAccept.Location.X == this.Size.Width-bAccept.Size.Width-17) && (bAccept.Location.Y== this.Size.Height - bAccept.Size.Height-42)) 
                    bAccept.Location = new Point(0, 0);
                else if (bAccept.Location.X == this.Size.Width - bAccept.Size.Width - 17)
                    bAccept.Location = new Point(bAccept.Location.X, bAccept.Location.Y + 1);
                else if (bAccept.Location.Y == this.Size.Height - bAccept.Size.Height - 42)
                    bAccept.Location = new Point(bAccept.Location.X + 1, bAccept.Location.Y);
                else bAccept.Location= new Point(bAccept.Location.X+1,bAccept.Location.Y+1);
            }
            else if ((cX <= bAccept.Location.X + bAccept.Size.Width / 2) && (cY > bAccept.Location.Y + bAccept.Size.Height/2))
            {
                if ((bAccept.Location.X == this.Size.Width - bAccept.Size.Width-17) && (bAccept.Location.Y == 0))
                    bAccept.Location = new Point(0, this.Size.Height - bAccept.Size.Height - 42);
                else if (bAccept.Location.X == this.Size.Width - bAccept.Size.Width - 17)
                    bAccept.Location = new Point(bAccept.Location.X, bAccept.Location.Y - 1);
                else if (bAccept.Location.Y == 0)
                    bAccept.Location = new Point(bAccept.Location.X + 1, 0);
                else bAccept.Location = new Point(bAccept.Location.X + 1, bAccept.Location.Y - 1);
            }
            else if ((cX > bAccept.Location.X + bAccept.Size.Width / 2) && (cY <= bAccept.Location.Y + bAccept.Size.Height / 2))
            {
                if ((bAccept.Location.X == 0) && (bAccept.Location.Y == this.Size.Height - bAccept.Size.Height - 42))
                    bAccept.Location = new Point(this.Size.Width - bAccept.Size.Width - 17, 0);
                else if (bAccept.Location.X == 0)
                    bAccept.Location = new Point(0, bAccept.Location.Y + 1);
                else if (bAccept.Location.Y == this.Size.Height - bAccept.Size.Height - 42)
                    bAccept.Location = new Point(bAccept.Location.X - 1, bAccept.Location.Y);
                else bAccept.Location = new Point(bAccept.Location.X - 1, bAccept.Location.Y + 1);
            }
            else if ((cX > bAccept.Location.X + bAccept.Size.Width / 2) && (cY > bAccept.Location.Y + bAccept.Size.Height / 2))
            {
                if ((bAccept.Location.X == 0) && (bAccept.Location.Y == 0))
                    bAccept.Location = new Point(this.Size.Width - bAccept.Size.Width - 17, this.Size.Height - bAccept.Size.Height - 42);
                else if (bAccept.Location.X == 0)
                    bAccept.Location = new Point(0, bAccept.Location.Y - 1);
                else if (bAccept.Location.Y == 0)
                    bAccept.Location = new Point(bAccept.Location.X - 1, 0);
                else bAccept.Location = new Point(bAccept.Location.X - 1, bAccept.Location.Y - 1);
            }
        }
    }
}
