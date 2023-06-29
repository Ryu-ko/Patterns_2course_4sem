using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab0
{
    internal abstract class Planet
    {
        public string Name { get; set; }
        public int Precent { get; set; }

    }

    internal  class Ground : Planet
    {
        public override string ToString()  
        {
            return ($" {this.Name} занимает {this.Precent}% от всей планеты");
        }

        public string Name { get; set; }
        public int Precent { get; set; }
        public Ground(string name, int precent )
        {
            Name = name;
            Precent = precent;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Ground gr = new Ground("Что-то", 21);
            Console.WriteLine(gr.ToString());
           
        }
    }


}
