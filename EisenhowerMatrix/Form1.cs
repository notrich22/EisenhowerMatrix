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
    public partial class EisenhowerMatrix : Form
    {
        public Matrix matrix { get; set; }
        public EisenhowerMatrix()
        {
            matrix = new Matrix();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
            addform.ShowDialog();
            if (addform.DialogResult == DialogResult.OK)
            {
                Event eve = addform.ReturnEvent();
                matrix.Add_Event(eve);
                refresh_boxes();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
        
        private void refresh_boxes()
        {
            try
            {
                foreach (Event e in matrix.ToDo)
                {
                    ToDoBox.Items.Add(e.Name);
                }
                foreach (Event e in matrix.ToDecide)
                {
                    ToDecideBox.Items.Add(e.Name);
                }
                foreach (Event e in matrix.ToDelegate)
                {
                    ToDelegateBox.Items.Add(e.Name);
                }
                foreach (Event e in matrix.ToEliminate)
                {
                    ToEliminateBox.Items.Add(e.Name);
                }
            }
            catch (Exception) { return; }
        }
    }
}
