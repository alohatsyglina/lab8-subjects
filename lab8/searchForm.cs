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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }


        public List<XElement> search(string condition, string value)
        {
            List<XElement> resultList = new List<XElement>();
            try
            {
                var element = XDocument.Load("../../info.xml").Element("info").
                    Elements("subject").Where(el => el.Element(condition).Value.ToLower().Contains(value.ToLower()));
                foreach(XElement el in element)
                {
                    resultList.Add(el);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка!");
            }
            return resultList;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            List<XElement> result = new List<XElement>();
            if (teacherNameRadio.Checked)
                result = search("teacherName", teacherNameSearch.Text);
            else if (subCodeRadio.Checked)
                result = search("subCode", subCodeSearch.Text);
            else if (finalPaperRadio.Checked)
                result = search("courseWork", finalPaperSearch.SelectedItem.ToString());
            else
                result = search("controlType", controlSearch.SelectedItem.ToString());
            if (result.Count()!=0)
                print(result);
            else
                MessageBox.Show("Поиск не дал результатов");
            
        }

       public static void print(IEnumerable<XElement> listOfElements)
        {
            mainForm mf = new mainForm();
            foreach(XElement el in listOfElements)
            {
                mf.text += mainForm.GetInfo(el);
            }

            mf.ShowDialog();
        }
    }
}
