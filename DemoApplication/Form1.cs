namespace DemoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String address = textBox2.Text;
            String city = lstCity.GetItemText(lstCity.SelectedItem);
            String gender = "";
            if (rdMale.Checked)
            {
                gender = rdMale.Text;
            }
            if (rdMale.Checked)
            {
                gender = rdFemale.Text;
            }
            String application = "";
            if (chkC.Checked)
            {
                application = chkC.Text;
            }
            if (chkASP.Checked)
            {
                application = chkASP.Text;
            }
            if (chkC.Checked && chkASP.Checked)
            {
                application = chkC.Text + " and " + chkASP.Text;
            }

            MessageBox.Show("Name: " + name + "\nAddress: " + address + ", " + city + "\nGender: " + gender + "\nApplication: " + application);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}