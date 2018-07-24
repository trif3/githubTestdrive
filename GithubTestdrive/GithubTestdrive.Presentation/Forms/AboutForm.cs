namespace GithubTestdrive.Presentation.Forms
{
    #region Usings
    using System.Windows.Forms;
    using System;
    #endregion

    public partial class AboutForm : Form
    {
        #region Properties
        public string AboutText;
        #endregion

        #region Constructor
        public AboutForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            CenterToScreen();
        }
        #endregion

        #region Event Methods
        protected void FormLoad(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AboutText))
                SetAboutText(AboutText);
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            Button btnSender = (sender as Button);
            if (btnSender != null)
            {
                switch (btnSender.Name)
                {
                    case ("closeBtn"):
                        CloseOperation();
                        break;
                    default:
                        MessageBox.Show("Error", "Not a valid event.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        #endregion

        #region Custom Methods
        private void CloseOperation()
        {
            Dispose();
            Close();
        }

        private void SetAboutText(string aboutTxt)
        {
            txtLabel.Text = aboutTxt;
        }
        #endregion
    }
}
