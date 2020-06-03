using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab8
{
    public partial class mainForm : Form
    {
        public static double exTime, crTime;
        public mainForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addForm AF = new addForm();
            AF.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deleteForm DF = new deleteForm();
            DF.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchForm SF = new searchForm();
            SF.Show();
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            TextBox.Text = " ";
            XDocument document = XDocument.Load("../../info.xml");
            var subjects = document.Element("info");
            exTime = double.Parse(subjects.Element("exTime").Value);
            crTime = double.Parse(subjects.Element("crTime").Value);

            foreach (XElement el in subjects.Elements("subject"))
            {
                TextBox.Text += GetInfo(el);
            }
        }

        public static string GetInfo(XElement element)
        {
            string info;
            XElement subCode = element.Element("subCode");
            XElement subName = element.Element("subName");
            XElement teacherName = element.Element("teacherName");
            XElement groupCode = element.Element("groupCode");
            XElement studentsNum = element.Element("stuentsNum");
            XElement lectionHours = element.Element("lectionHours");
            XElement practiceHours = element.Element("practiceHours");
            XElement courseWork = element.Element("courseWork");
            XElement controlType = element.Element("controlType");

            info = "\nКод дисциплины: " + subCode.Value + "\nНазвание дисциплины: " + subName.Value +
               "\nФамилия преподавателя: " + teacherName.Value + "\nКод группы: " + groupCode.Value + "\nКоличество студентов в группе: " + studentsNum +
               "\nКоличество часов лекций: " + lectionHours.Value + "\nКоличество часов практики: " + practiceHours.Value +
               "\nКурсовая работа: " + courseWork.Value + "\nТип итогового контроля: " + controlType.Value + "\nВремя на студента: ";
            if (controlType.Value.ToLower() == "зачет")
            {
                info += crTime + " ч.\n";
            }
            else if(controlType.Value.ToLower() =="экзамен")
            {
                info += exTime + " ч.\n";
            }          
            return info;
        }

        public string text
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }

        }
    }
}
