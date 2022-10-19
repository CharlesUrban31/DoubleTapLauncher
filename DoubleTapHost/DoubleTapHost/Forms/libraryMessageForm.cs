using System;

namespace DoubleTapHost
{
    public partial class libraryMessageForm : Form
    {
        public libraryMessageForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selLibBtn_Click(object sender, EventArgs e)
        {
            if (gameLibFolderDialog.ShowDialog() == DialogResult.OK)
            {
                String gameLibraryPath = gameLibFolderDialog.SelectedPath;
                // Write gameLibaryPath to Config File
                this.Close();
            }
        }
    }
}
