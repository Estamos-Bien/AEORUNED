using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEROUNED_CLIENT_
{
    [Serializable]
    internal class Boleto
    {
        private int numero;
        private int vuelo;
        private DateTime fecha;
        private string cliente;
        private int asientos;

        public Boleto(int numero, int vuelo, DateTime fecha, string cliente, int asientos)
        {
            this.Numero = numero;
            this.Vuelo = vuelo;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Asientos = asientos;
        }

        public int Numero { get => numero; set => numero = value; }
        public int Vuelo { get => vuelo; set => vuelo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int Asientos { get => asientos; set => asientos = value; }
    }
}
