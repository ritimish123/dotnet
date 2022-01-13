using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
     public class BankLibrary
    {
        public static void Main(String[] args)
        {
            ScreenDescription sd = new ScreenDescription();
            do
            {
                sd.showBankScreen();
            } while (true);
        }
    }

}

