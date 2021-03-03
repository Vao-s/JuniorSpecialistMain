using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Blue", 10, 20);
            square.PrintInfo();

            Cube cube = new Cube("Red", 1, 2, 3);
            cube.PrintInfo();

            Triangle triangle = new Triangle("Black");
            triangle.PrintInfo();
        }
    }
}
