namespace FileBrowser;

public partial class FileBrowserForm : Form
{
    public FileBrowserForm()
    {
        InitializeComponent();
    }

    private void openButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {

        }
    }

    private void nextButton_Click(object sender, EventArgs e)
    {

    }

    private void closeButton_Click(object sender, EventArgs e)
    {

    }
}