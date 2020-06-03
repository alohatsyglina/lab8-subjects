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
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        public IEnumerable<XElement> deleteElements(string subCode)
        {
            XDocument document = XDocument.Load("../../info.xml");
            IEnumerable<XElement> element = document.Element("info").Elements("subject").Where(el => el.Element("subCode").Value == subCode);
            while (element.Count() > 0)
            {
                element.ElementAt(0).Remove();
                document.Save("../../info.xml");
            }
            return document.Element("info").Elements("subject");
        }

        private void DeleteInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                deleteElements(deleteBox.Text);
                MessageBox.Show("Запись удалена");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
            Close();
        }

    }
}
