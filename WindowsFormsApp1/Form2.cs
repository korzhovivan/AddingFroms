using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        private Info info = null;
        public string NName {
            get
            {
                return textBox_Name.Text;
            }
        }
        public string CCountry
        {
            get
            {
                return textBox_Country.Text;
            }
        }
        public string PPrice
        {
            get
            {
                return textBox_Price.Text;
            }
        }

        internal Info Info { get => info; set => info = value; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Info = new Info() { Name = NName, Country = CCountry, Price = PPrice};
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
