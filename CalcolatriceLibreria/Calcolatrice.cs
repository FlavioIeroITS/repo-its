namespace CalcolatriceLibreria
{
    public class Calcolatrice
    {
        public Calcolatrice() { }

        public double Somma(double x, double y)
        {

            return x + y;
            throw new NotImplementedException();
        }

        public double Sottrazione(double x, double y)
        {
            return x - y;
        }

        public double Moltiplicazione(double x, double y)
        {
            return x * y;
        }

        public double Divisione(double x, double y)
        {
            if(y != 0) return x / y;
            return 0;
        }
    }
}
