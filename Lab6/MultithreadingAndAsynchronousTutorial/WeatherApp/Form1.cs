namespace TutorialAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dummyButton1_Click(object sender, EventArgs e)
        {
            dummyTextBox.Text = "Some dummy text...";
        }

        private void dummyButton2_Click(object sender, EventArgs e)
        {
            dummyTextBox.Text = "Even more dummy text...";
        }
    }
}
