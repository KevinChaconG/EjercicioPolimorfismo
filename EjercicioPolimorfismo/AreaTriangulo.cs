

namespace EjercicioPolimorfismo
{
    public class AreaTriangulo
    {
        public double b {  get; set; }
        public double h { get; set; }

        public double ImprimirArea()
        {
            return (b * h) / 2;
        }
    }
}
