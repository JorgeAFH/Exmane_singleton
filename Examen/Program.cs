using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Examen.Instance.nota_recordatorio);
            Examen.Instance.nota_recordatorio = "hoy toca barrer";
            Console.WriteLine(Examen.Instance.nota_recordatorio);
            Examen.Instance.nota_recordatorio = "hoy toca limpiar los carros";
            Console.WriteLine(Examen.Instance.nota_recordatorio);
        }
    }
}