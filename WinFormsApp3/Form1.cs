using WinFormsApp3.Data;
using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        BI_ITI db = new BI_ITI();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> list = db.Student.ToList();
            dgvStudents.DataSource = list;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStdForm addStdForm = new AddStdForm();
            addStdForm.ShowDialog();
            List<Student> students = db.Student.ToList();
            dgvStudents.DataSource = students;
            dgvStudents.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateStdForm updateStdForm = new updateStdForm();
            updateStdForm.ShowDialog();
            List<Student> students = db.Student.ToList();
            dgvStudents.DataSource = students;
            dgvStudents.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStdForm deleteStdForm = new DeleteStdForm();
            deleteStdForm.ShowDialog();
            List<Student> students = db.Student.ToList();
            dgvStudents.DataSource = students;
            dgvStudents.Refresh();
        }
    }
}