namespace GithubTestdrive.Presentation
{
    #region Usings
    using System.Windows.Forms;
    using System;
    using Forms;
    #endregion

    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Event Methods
        protected void MenuItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem btnSender = (sender as ToolStripMenuItem);
            if (btnSender != null)
            {
                switch (btnSender.Name)
                {
                    case ("openMenuItem"):
                        break;
                    case ("saveMenuItem"):
                        break;
                    case ("saveAsMenuItem"):
                        break;
                    case ("exitMenuItem"):
                        ExitOperation();
                        break;
                    case ("preferencesMenuItem"):
                        break;
                    case ("styleMenuItem"):
                        break;
                    case ("aboutMenuItem"):
                        AboutOperation();
                        break;
                    default:
                        MessageBox.Show("Error", "Not a valid event.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        #endregion

        #region Custom Methods
        private void ExitOperation()
        {
            DestroyHandle();
            Dispose();
            Close();
        }

        private void AboutOperation()
        {
            AboutForm aboutFrm = new AboutForm()
            {
                AboutText = @"Version -0.1"
            };
            aboutFrm.ShowDialog();
        }
        #endregion
    }
}
