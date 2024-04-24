using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseMySQL
{
    public partial class Form3 : Form
    {
        Form2 _parent;

        public Form3(Form2 parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _parent.labeloffon.Text = "Online";
            _parent.labeloffon.ForeColor = Color.Green;
            _parent.senderEmail = textcredmail.Text;
            _parent.senderPassword = textcredpass.Text;
            this.Close();

        }
    }
}
