
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
            //Ac4yIdentificationBaseEntityMethods ac4YIdentificationBaseEntityMethods = new Ac4yIdentificationBaseEntityMethods("Ac4yDb2");
            Ac4yEntityMethods ac4YEntityMethods = new Ac4yEntityMethods("Ac4yDb2");

            Ac4y ac4Y = new Ac4y()
            {
                HumanId = "ac4yobject",
                serialization = "<?xml version='1.0' encoding=\"UTF - 8\"?>< Ac4yClass xmlns:xsd = \"http://www.w3.org/2001/XMLSchema\" xmlns: xsi = \"http://www.w3.org/2001/XMLSchema-instance\" >< Name > Ac4y </ Name >< Ancestor > Ac4yIdentification </ Ancestor >< Namespace > CSAc4y.Class </ Namespace >< GUID />< PropertyList >< Ac4yProperty >< Name > serialization </ Name >< Type > String </ Type ></ Ac4yProperty >< Ac4yProperty >< Name > template </ Name >< Type > Ac4yIdentificationBase </ Type ></ Ac4yProperty >< Ac4yProperty >< Name > GUID </ Name >< Type > String </ Type ></ Ac4yProperty >< Ac4yProperty >< Name > HumanId </ Name >< Type > String </ Type ></ Ac4yProperty >< Ac4yProperty >< Name > PublicHumanId </ Name >< Type > String </ Type ></ Ac4yProperty >< Ac4yProperty >< Name > id </ Name >< Type > Int32 </ Type ></ Ac4yProperty ></ PropertyList ></ Ac4yClass > ",
                template = new Ac4yIdentificationBase()
                {
                    HumanId = "ac4ytemplate",
                }
            };

            ac4YEntityMethods.addNew(ac4Y);


            Ac4y uj = ac4YEntityMethods.findFirstById(1);
            Console.WriteLine(uj.GUID);
        }
    }
}
