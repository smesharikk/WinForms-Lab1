using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        //Person p = new Person(); 
        List<InterfacePerson> People = new List<InterfacePerson>();

        private void bCreateNewNote_Click(object sender, EventArgs e) // Откытие формы для создания новой записи
        {
            FormCreateChange Fcreate = new FormCreateChange(null);
            if (Fcreate.ShowDialog()== DialogResult.OK)
            {
                this.People.Add(Fcreate.getPerson());
            }
            UpdateListNote();
            
        }

        void UpdateListNote() //Функция для обновления списка клиентов
        {
            listNote.Items.Clear();
            for(int i=0; i < People.Count; i++)
            {
                listNote.Items.Add(People[i].Name + " " + People[i].calcAge(DateTime.Now).ToString());
            }
        }

        
        private void bСhangeNote_Click(object sender, EventArgs e) //Открытие формы для изменения выбранной записи
        {
            if (listNote.SelectedIndex == -1)
            {
                lnotchoose.Text = "Выберите запись, которую хотите изменить.";
            }
            else
            {
                FormCreateChange FChange = new FormCreateChange(People[listNote.SelectedIndex]);
                FChange.ShowDialog();
                UpdateListNote();
            }
        }


        private void bDeleteNote_Click(object sender, EventArgs e) // Удаление выбранной записи
        {
            if (listNote.SelectedIndex == -1)
            {
                lnotchoose1.Text = "Выберите запись, которую хотите удалить.";
            }
            else
            {
                if(MessageBox.Show("Удалить запись " + People[listNote.SelectedIndex].Name + " " + People[listNote.SelectedIndex].calcAge(DateTime.Now)+"?",
                                    "Удаление",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    People.RemoveAt(listNote.SelectedIndex);
                    UpdateListNote();
                }
            }
        }
        private void listNote_Click(object sender, EventArgs e)
        {
            if (listNote.SelectedIndex != -1)
            {
                lnotchoose.Text = "";
                lnotchoose1.Text = "";
            }
        }
        
    }
}
