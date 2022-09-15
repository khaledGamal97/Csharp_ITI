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
    public partial class AddStdForm : Form
    {
        BI_ITI db = new BI_ITI();
        public AddStdForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Name = txtName.Text;
            std.Age = int.Parse(txtAge.Text);
            std.Email = txtEmail.Text;

            db.Student.Add(std);
            db.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
