using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Examen
    {
        private static Examen instance = null;
        public string nota_recordatorio = "";

        protected Examen()
        {
            nota_recordatorio = "hoy toca lavar los platos";
        }

        public static Examen Instance
        {
            get
            {
                if (instance == null)
                    instance = new Examen();

                return instance;
            }
        }

    }
}
