using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Data;
using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class DeleteStdForm : Form
    {
        BI_ITI db = new BI_ITI();
        public DeleteStdForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = db.Student.FirstOrDefault(s => s.Id == int.Parse(txtStdID.Text));
            db.Student.Remove(student);
            db.SaveChanges();
            this.Close();

        }
    }
}
