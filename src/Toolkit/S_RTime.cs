using Lil.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WFFT_Lib.Scripts;

namespace TextFileEditor.src.Toolkit
{

    public abstract class Runtime_Lazy<T> : SingletonBase<T> where T : class
    {
        List<Form> forms = new();
        protected Runtime_Lazy()
        {
            HasInit = false;
        }

        public virtual void Setup()
        {
            HasInit = true;
        }

        public bool HasInit { get; private set; }

        public abstract bool Log(String logName, String msg);


        public virtual Form AddForm(Form form)
        {
            if (!forms.Contains(form))
                forms.Add(form);
            return form;
        }

        public virtual Form ShowForm(Form form)
        {
            AddForm(form);
            form.Show();
            return form;
        }

    }


    internal class S_RTime : Runtime_Lazy<S_RTime>
    {
        public Form? DefaultForm { get; set; }
        public AppContext_Generic? AppContext { get; set; }
        public List<String> debugOut = new List<string>();
        void Log(String msg) => debugOut.Add(msg);

        public override bool Log(string logName, string msg)
        {
            throw new NotImplementedException();
        }

        public override void Setup()
        {
            base.Setup();
        }

        public bool IsLoaded => (AppContext != null);

        // notebook related

        public Form NewEditor => new FormEditor_txt();
        

    }
}
