using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public class Core
    {

        public IDataManager Datamanager { get; set; }

        public int ZähleKäse()
        {
 
            return Datamanager.GetAllKäse().Count();
        }
    }

    public class DataManager : IDataManager
    {
        public IEnumerable<Käse> GetAllKäse()
        {
            Thread.Sleep(3000);
            yield return new Käse() { Name = "Butterkäse" };
            yield return new Käse() { Name = "Tilsitter" };
            yield return new Käse() { Name = "Gauda" };

        }
    }
}

