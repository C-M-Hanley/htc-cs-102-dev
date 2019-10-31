using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{ 
    public class Lion : Animal
    {


        public Lion() { }

        public Lion(int height, string name)
        {
            this.Height = height;
            this.Name = name;

        }

        public void Roar()
        {
            MessageBox.Show("Roar");
        }



    }
}

