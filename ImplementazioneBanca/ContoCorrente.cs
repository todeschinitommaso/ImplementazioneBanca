using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMPLEMENTAZIONE_VERIFICA
{
    class ContoCorrente
    {
        private string id;

        private string cliente;

        private string banca;

        public float saldo;

        private void setId(string id)
        {
            this.id = id;
        }

        private void setCliente(string cliente)
        {
            this.cliente = cliente;
        }

        private void setBanca(string banca)
        {
            this.banca = banca;
        }

        private void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public ContoCorrente(string id, string cliente, string banca, float saldo)
        {

            setId(id);

            setBanca(banca);

            setCliente(cliente);

            setSaldo(saldo);

        }

        public float getSaldo()
        {
            return saldo;
        }

        public void Deposita(float somma)
        {

            if (somma <= 0)
            {
                throw new Exception("Impossibile depositare un saldo negativo, eventualmente prelevi");
            }

            else
            {
                setSaldo(getSaldo() + somma);
            }

        }

        public void Preleva(float prelievo)
        {

            if (prelievo <= 0)
            {
                throw new Exception("Impossibile prelevare un numero negativo, eventualmente depositi");
            }

            else if (getSaldo() < prelievo)
            {
                throw new Exception("Saldo insufficente sul conto corrente");

            }

            else
            {
                setSaldo(getSaldo() - prelievo);
            }
        }

        public void Sposta(ContoCorrente destinazione, float somma)
        {

            Preleva(somma);

            destinazione.Deposita(somma);
        }
    }
}

