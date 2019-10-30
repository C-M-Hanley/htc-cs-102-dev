using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Frog : Animal
    {
        public Frog() { }

        public Frog(int height, string name, bool isPosion)
        {
            this.Height = height;
            this.Name = name;
        }

        public void Ribbit()
        {
            MessageBox.Show("Ribbit");
        }
    }
}
