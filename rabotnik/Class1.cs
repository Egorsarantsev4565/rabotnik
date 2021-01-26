using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rabotnik
{
    class Sotrudnik : IComparable<Sotrudnik>
    {
        private string fn;
        private string sn;
        private double wk;
        private double hr;
        

        public Sotrudnik(string sn, string fn, double wk, double hr )
        {
            this.fn = fn;
            this.sn = sn;
            this.wk = wk;
            this.hr = hr;
            
            

        }
        public string Info()
        {
            string s = sn + " " + fn + " " + wk + " " + hr ;
            return s;
        }

        public string getLastName()
        {
            return sn;
        }
        public int CompareTo(Sotrudnik obj)
        {
            int result = this.sn.CompareTo(obj.sn);
            if (result == 0)
                result = this.fn.CompareTo(obj.fn);
            return result;
        }

    }
    }
