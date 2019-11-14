using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    public interface ISpeaker
    {
        string Name { get; }
        int Height { get; }
        int Weight { get; }
        void Speak();
        void SayName();
    }
}
