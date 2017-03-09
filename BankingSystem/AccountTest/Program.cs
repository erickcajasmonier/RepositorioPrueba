using BankingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Control + . antes del Account y seleccionar que viene del BakingModel
            Account myAccount;
            myAccount = new Account();

            myAccount.Name = "Erick Cajas Monier";
            Console.WriteLine("myAccount.Name={0}", myAccount.Name);
        }
         
    }
}
