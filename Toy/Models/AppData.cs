using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy.Models;

namespace Toy.Models
{
    static public class AppData
    {
        static public ToyEntities db = new ToyEntities();
        static public int CurrentAccessLevel = 0;
    }
}
