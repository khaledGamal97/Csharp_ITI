namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtUserName.Text + ":" + txtPassword.Text, "Info", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            
        }
    }
}