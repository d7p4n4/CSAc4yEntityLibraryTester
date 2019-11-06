
using d7p4n4.EFMethods.Class;
using d7p4n4.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4yEntityLibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Ac4yIdentificationBaseEntityMethods ac4YIdentificationBaseEntityMethods = new Ac4yIdentificationBaseEntityMethods("Ac4yDb2");
            Ac4yEntityMethods ac4YEntityMethods = new Ac4yEntityMethods("Ac4yDb2");
            Ac4yIdentificationBase ac4YIdentificationBase = new Ac4yIdentificationBase();
            Ac4y ac4Y = new Ac4y();

            ac4YIdentificationBase.CreatedAt = DateTime.Now;

            ac4YEntityMethods.addNew(ac4Y);

            //ac4YIdentificationBaseEntityMethods.addNew(ac4YIdentificationBase);

            //Ac4yIdentificationBase uj = ac4YIdentificationBaseEntityMethods.findFirstById(1);
            //Console.WriteLine(uj.CreatedAt);
        }
    }
}
