using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileEditor.src.Toolkit
{
    public partial class FormTracker : Component
    {
        public FormTracker()
        {
            InitializeComponent();
        }

        public FormTracker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void AddForm(Form form)
        {
            S_RTime.I.AppContext.RegisterForm(form);
        }
    }


    public class AppContext_Generic : ApplicationContext
    {
        public List<Form> forms = new List<Form>();
        public Form DefaultForm { get; set; }
        public AppContext_Generic(Form mainForm, Form defaultForm) : base(mainForm)
        {
            forms.Add(mainForm);
            DefaultForm = defaultForm;
        }

        public void SafeCloseForm(Form form, bool actuallyQuit = true)
        {

        }

        public void ShowForm(Form form)
        {
            RegisterForm(form);
            form.Show();
        }

        public void RegisterForm(Form form)
        {
            if (!forms.Contains(form))
            {
                forms.Add(form);
                form.FormClosing += OnFormClosed;
            }
        }

        void OnFormClosed(object? sender, FormClosingEventArgs e)
        {
            if (sender != null)
            {
                if (forms.Contains(sender as Form))
                    forms.Remove(sender as Form);
            }
        }

        public void CloseForm(Form form)
        {
            if (forms.Contains(form))
                forms.Remove(form);
            form.Close();
        }

        protected override void OnMainFormClosed(object? sender, EventArgs e)
        {
            if (sender == base.MainForm && forms.Any())
            {
                base.MainForm = forms[0];
            }
            base.OnMainFormClosed(sender, e);
        }
    }


}
