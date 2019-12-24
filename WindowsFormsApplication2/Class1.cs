using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class DataContainer
    {
        public event EventHandler AcceptedChanges;
        protected virtual void OnAcceptedChanges()
        {
            if ((this.AcceptedChanges != null))
            {
                this.AcceptedChanges(this, EventArgs.Empty);
            }
        }

        public void AcceptChanges()
        {
            this.OnAcceptedChanges();
        }

        public string id { get; set; }
        public string itulité { get; set; }
    }
}
