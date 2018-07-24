namespace GithubTestdrive.Presentation
{
    #region Usings
    using GithubTestdrive.Presentation.Forms;
    using System.Windows.Forms;
    #endregion

    static class Program
    {
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
