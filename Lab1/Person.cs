using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person : InterfacePerson
    {
        public string CardName
        {
            get { return m_CardName; }
            set { m_CardName = value; }
        }
        string m_CardName;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        string m_Name;

        public DateTime Birthday
        {
            get { return m_Birthday; }
            set { m_Birthday = value; }
        }
        DateTime m_Birthday;

        public int calcAge(DateTime date)
        {
            if (date.DayOfYear >= Birthday.DayOfYear)
                return date.Year - Birthday.Year;
            else
                return date.Year - Birthday.Year - 1;
        }
    }
}
