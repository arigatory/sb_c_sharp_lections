using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1451
{

    class Program
    {
        static void Main(string[] args)
        {
            TwitterUser donald = new TwitterUser("donald");
            donald.PublicMessage("Всем добра!");

            TwitterUser vladimir = new TwitterUser("vladimir");
            donald.Post += vladimir.Tape;

            donald.PublicMessage("Всем успехов!");

            TwitterUser ivan = new TwitterUser("ivan");
            donald.Post += ivan.Tape;

            donald.PublicMessage("Всем процветания!");

            TwitterUser denis = new TwitterUser("denis");
            donald.Post += denis.Tape;

            donald.PublicMessage("Всем C#!", new Image(), new Document(), new Audio());


            vladimir.Post += donald.Tape;
            vladimir.PublicMessage("Ку-ку");

        }
    }
}
