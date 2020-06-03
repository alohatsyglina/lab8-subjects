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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void AddInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (codeSubBox.Text == "" || nameSubBox.Text == "" || teacherNameBox.Text == "" ||
                    groupCodeBox.Text == "" || studentsNum.Value == 0 || practiceHoursNum.Value == 0 || lectionHoursNum.Value == 0 ||
                    finalPaperList.SelectedItem.ToString() == "" || controlList.SelectedItem.ToString() == "")
                    throw new Exception();
                else
                {


                    var add = AddElement(codeSubBox.Text, nameSubBox.Text, teacherNameBox.Text,
                        groupCodeBox.Text, Convert.ToString(studentsNum.Value),
                        lectionHoursNum.Value.ToString(), practiceHoursNum.Value.ToString(),
                        finalPaperList.SelectedItem.ToString(),controlList.SelectedItem.ToString());
                    MessageBox.Show("Запись добавлена");
                    Close();
                }
                        
            }

            catch (Exception)
            {
                MessageBox.Show("Ошибка! Одно или несколько полей незаполнены");
            }

        }

        public IEnumerable<XElement> AddElement(string subCode, string subName, string teacherName, string groupCode, string studentsNum, string lectionHours, string practiceHours, string courseWork, string controlType)
        {
            XDocument document = XDocument.Load("../../info.xml");
            document.Element("info").Add(new XElement("subject",
                new XElement("subCode", subCode), new XElement("subName", subName),
                new XElement("teacherName", teacherName), new XElement("groupCode", groupCode),
                new XElement("studentsNum", studentsNum), new XElement("lectionHours", lectionHours),
                new XElement("practiceHours", practiceHours), new XElement("courseWork", courseWork),
                new XElement("controlType", controlType)));
            document.Save("../../info.xml");
            return document.Element("info").Elements("subject");
        }
    }
}
