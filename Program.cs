using Lil.Forms;
using TextFileEditor.src.Toolkit;
using TextScrappy.Forms;

namespace TextFileEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //AppContext_Generic appContext_ = new(new FormEditor_txt(), new FormEditor_txt());
            //S_RTime.I.AppContext = appContext_;


            new Clipboard_Info().Show();
            new Form_CharInspector().Show();
            new Form_DemoRichText1().Show();


            Application.Run(S_RTime.I.NewEditor);
        }
    }
}