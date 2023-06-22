using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBased_RTS
{
    internal class Resource
    {
        private string typeName;
        private int income = 0; //Zero income by default

        public Resource(string type)
        {
            setType(type);

        }

        private void setType(string myType)
        {
            try
            {
                switch (myType)
                {
                    case "Oxygen":
                        typeName = "Oxygen";
                        break;
                    case "Water":
                        typeName = "Water";
                        break;
                    case "Metal":
                        typeName = "Metal";
                        break;
                    case "Helium3":
                        typeName = "Helium3";
                        break;
                    default:
                        throw new Exception("Invalid Resource Type");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string getType() { return typeName; }

        public void addIncome(int num)
        {
            income += num;
        }

        public int getIncome() { return income;}

    }
}
