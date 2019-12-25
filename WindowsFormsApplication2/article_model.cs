using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public static class article_model 
    {

        public static string reff;
        public static string desc;
        public static double qte;
        public static double pu;
        public static double total_mont=0;
        public static double totam_mont()
        {
         
            return total_mont;
        }
        public static event EventHandler OnDataAvailable;




    }
}
