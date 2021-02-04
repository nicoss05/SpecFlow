using System;

namespace Matematica
{
    public class Calculadora
    {
        public double PrimerNumero { get; set; }
        public int SegundoNumero { get; set; }
        public double Resultado { get; set; }

        public void Sumar()
        {
            Resultado = PrimerNumero + SegundoNumero;
        }

        public void Restar()
        {
            Resultado = PrimerNumero - SegundoNumero;
        }

        public void Escalonada()
        {
            var parteEntera = Math.Truncate(PrimerNumero);
            if (PrimerNumero - parteEntera > 0)
            {
                Resultado = Math.Truncate(PrimerNumero);
            }
            else
            {
                Resultado = PrimerNumero - 1;
            } 

        }
    }
}