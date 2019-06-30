using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>

    /// The 'ProductA2' class

    /// </summary>

    class Bison : Herbivore

    {
    }

    /// <summary>

    /// The 'ProductB2' class

    /// </summary>

    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
