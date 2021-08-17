using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1443
{

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cat($"Барсик", $"Шотландский вислоухий", 3);
            People robert = new People("Роберт", c);

            c.ToMew();

            c.Ownew = robert;

            robert.FeedTheCat();

        }
    }
}
