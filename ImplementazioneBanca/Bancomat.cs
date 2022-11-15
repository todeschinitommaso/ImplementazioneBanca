using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Bancomat
    {
        private string _id;

        private string _pin;

        private ContoCorrente conto;

        public string PinInserito;

        public Bancomat(string id, string pin, ContoCorrente conto1)
        {
            Id = id;

            pin = pin;

            conto = conto1;


        }

        //properties (piu veloce)

        public string Id
        {

            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }

        }

        public void Depositare(float somma, string verifica)
        {

            if (verifica == PinInserito)
            {
                conto.Deposita(somma);
            }

            else
            {
                throw new Exception("pin errato, operazione annullata");
            }

        }

        public void Prelevare(float somma, string verifica)
        {

            if (verifica == PinInserito)
            {
                conto.Preleva(somma);
            }
            else
            {
                throw new Exception("Pin errato");
            }
        }

        public float getSaldo(string verifica)
        {
            if (verifica == PinInserito)
            {
                return conto.getSaldo();
            }
            else
            {
                throw new Exception("Pin errato");
            }
        }
        public string getId()
        {
            return _id;
        }
    }
}
