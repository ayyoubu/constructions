using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public  class article_model 
    {

        public static string reff;
        public static string desc;
        public static double qte;
        public static double pu;
        public static double _total_mont = 0;

        public double total_mont
        {
          
            set
            {
                this.total_mont= value;
                
            }
        }
        [Category("Action")]
        [Description("Fires when the value is changed")]
        public event EventHandler ValueChanged;

        public virtual void OnValueChanged(EventArgs e)
        {
            // (2)
            // Raise the event
            if (ValueChanged != null)
                ValueChanged(this, e);
        }





    }
}
