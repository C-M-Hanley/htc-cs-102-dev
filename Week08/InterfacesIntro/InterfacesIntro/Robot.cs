using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Robot : ISpeaker
    {
        public int Height

        {
            get { return 5; }
        }

        public int Weight

        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int SerialNum
        {
            get; set;
        }

        public Robot(string name, int serialNum, int weight)
        {
            Name = name;
            SerialNum = serialNum;
            Weight = weight;
        }

        public void SayName()
        {
            MessageBox.Show("Hi I am a robot. My name is " + Name + " and my serial number is " + SerialNum);
        }

        public void Speak()
        {
            MessageBox.Show("Beep! Boop!");
        }
    }
}
