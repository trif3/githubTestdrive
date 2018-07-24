namespace GithubTestdrive.Presentation.Forms
{
    #region Usings
    using System.Windows.Forms;
    using System;
    #endregion

    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Methods
        protected void ButtonClicked(object sender, EventArgs e)
        {
            Button btnSender = (sender as Button);
            if (btnSender != null)
            {
                switch (btnSender.Name)
                {
                    case (""):
                        break;
                    default:
                        MessageBox.Show("Error", "Not a valid event.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        #endregion
    }
}
