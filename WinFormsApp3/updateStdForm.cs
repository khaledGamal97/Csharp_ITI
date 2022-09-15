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
    public partial class updateStdForm : Form
    {
        BI_ITI db = new BI_ITI();
        public updateStdForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = db.Student.FirstOrDefault(s => s.Id == int.Parse(txtStdID.Text));
            string choice = "";
            choice = comboBox1.Text;
            if (choice == "Update Name")
                student.Name = txtNewValue.Text;
            else if (choice == "Update Age")
                student.Age = int.Parse(txtNewValue.Text);
            else
                student.Email = txtNewValue.Text;
            db.Student.Update(student);
            db.SaveChanges();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
