using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto1 = new ContoCorrente("AA001", "Todeschini Tommaso", "UBI BANCA", 0);

            ContoCorrente conto2 = new ContoCorrente("AA002", "Bernini Diego", "Intesa San Paolo", 0);

            //try e catch in caso avessimo delle eccezioni registrate dal throw
            try
            {
                conto1.Deposita(100);
                conto1.Preleva(50);
                Console.WriteLine(conto1.getSaldo());

                conto2.Deposita(1000);
                conto2.Preleva(2000);
                Console.WriteLine(conto2.getSaldo());

                conto1.Sposta(conto2, 50);
            }

            //con exception intendiamo l'exception specificata nella classe ed "e" è il messaggio
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            Bancomat carta1 = new Bancomat("AA001B", "2451", conto1);

            Bancomat carta2 = new Bancomat("AA002B", "3693", conto2);

            try
            {
                carta1.Depositare(40, "2451");
                carta1.Prelevare(50, "3693");
            }

            catch (Exception a)
            {
                Console.WriteLine(a);
            }

            Sportello sportello = new Sportello("46684354", "via 20 settembre Bergamo", "UniCredit", true);
        }


    }
}

