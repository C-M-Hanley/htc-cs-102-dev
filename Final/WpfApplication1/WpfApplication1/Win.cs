using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    public class Win
    {

        public string Hard
        {
            get;
            set;
        }

        public string Curve
        {
            get;
            set;
        }

        public virtual void YouWin()
        
        {
            MessageBox.Show("You did it!");
        }

        public virtual void Tryagain()

        {
            MessageBox.Show("Keep trying!");
        }
    }
}
