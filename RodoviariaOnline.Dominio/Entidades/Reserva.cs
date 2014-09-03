namespace RodoviariaOnline.Dominio.Entidades
{
    public class Reserva
    {
        public int Id { get; protected internal set; }

        public string NumeroDoDocumento { get; protected internal set; }

        public int NumeroDaPoltrona { get; protected internal set; }

        private bool validaCpf(string numero)
        {
            return true;
        }

        private bool validaRG(string numero)
        {
            return true;
        }

        internal Reserva(string tipoDoDocumento, string numeroDoDocumento, int numeroDaPoltrona)
        {
            if (tipoDoDocumento == "CPF")
            {
                
            } else if (tipoDoDocumento == "RG")
            {
                
            }

            
        }

    }
}
