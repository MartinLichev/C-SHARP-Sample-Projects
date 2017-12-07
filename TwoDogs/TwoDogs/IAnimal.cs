using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDogs
{
    public interface IAnimal
    {

        string Name { get; set; }

        string Breed { get; set; }

        int Age { get; set; }

        void Greet(string name, string breed, int age);
        void Sleep(string name, int hours);
    }
}
