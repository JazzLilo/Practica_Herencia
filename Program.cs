using System;

namespace Herencia_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ProyConstruccion pc1 = new ProyConstruccion(3, "Cota Cota", 30000);
            ProyFinalMateria pf1 = new ProyFinalMateria("Informatica", 4);

            pc1.Mostrar();
            pf1.Mostrar();

            pf1.MayPersonas(pc1);
            pf1.PersonasMismoProy(pc1);

        }
    }
}
