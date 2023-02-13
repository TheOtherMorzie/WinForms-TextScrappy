using Lil.Forms;
using TextFileEditor.src.Toolkit;
using TextScrappy.Forms;
using WFFT_Lib.Forms;

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

            Form? mainForm = null;
            List<Form> forms = new List<Form>();

            //new Form_CharInspector().Show();
            //new Form_DemoRichText1().Show();

            //forms.Add(new Form_ViewerSimpleHTML());
            //forms.Add(new Clipboard_Info());
            //forms.Add(new Form_CharInspector());

            //forms.Add(new DemoForm_clipboard1());
            forms.Add(new Form_LilsCMDparty());
            //forms.Add(new DemoForm_HighlightText());

            mainForm = new WinFormHostForm_Simple();

            if (mainForm == null)
            {
                mainForm = forms.First();
                forms.Remove(mainForm);
            }


            forms.ForEach(f => f.Show());

            if (mainForm == null) mainForm = S_RTime.I.NewEditor;

            Application.Run(mainForm);
        }

        List<Form> GetLaunchSet_Dev()
        {
            List<Form> forms = new List<Form>()
            {
                new Form_LilsCMDparty()
            };
            return forms;
        }

    }
}