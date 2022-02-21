using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EisenhowerMatrix
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Event ReturnEvent()
        {
            string Name;
            if (!String.IsNullOrEmpty(textBox1.Text))
                Name = textBox1.Text;
            else Name = "";
            var importance = radioButton1.Checked ? true : radioButton2.Checked ? false : false;
            var urgency = radioButton3.Checked ? true : radioButton4.Checked ? false : false;
            Event eve = new Event(Name, importance, urgency);
            return eve;
        }
    }
}
