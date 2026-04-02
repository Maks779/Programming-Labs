namespace FileBrowser;

public partial class FileBrowserForm : Form
{
    private FilePreviewer? _filePreviewer;

    public FileBrowserForm()
    {
        InitializeComponent();
        nextButton.Enabled = false;
        closeButton.Enabled = false;
    }

    private void openButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _filePreviewer = new FilePreviewer(openFileDialog.FileName);
            resultTextBox.Text = _filePreviewer.GetNextLine();
            openButton.Enabled = false;
            nextButton.Enabled = true;
            closeButton.Enabled = true;
        }
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
        resultTextBox.Text = _filePreviewer.GetNextLine();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        _filePreviewer.Dispose();
        openButton.Enabled = true;
        nextButton.Enabled = false;
        closeButton.Enabled = false;
        resultTextBox.Clear();
    }
}