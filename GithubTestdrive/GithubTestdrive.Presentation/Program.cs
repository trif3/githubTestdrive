namespace GithubTestdrive.Presentation
{
    #region Usings
    using System.Windows.Forms;
    #endregion

    static class Program
    {
        #region Main Method
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
        #endregion
    }
}
