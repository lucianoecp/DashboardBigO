using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Models
{
   

    public class SerieLinearTempo
    {
        public string name { get; set; }
        public double[] data { get; set; }

        public SerieLinearTempo()
        {

        }

        public SerieLinearTempo(string name, double[] data)
        {
            this.name = name;
            this.data = data;
        }

        public List<SerieLinearTempo> GetDataDummy()
        {
            List<SerieLinearTempo> lista = new List<SerieLinearTempo>();
            double[] data1 = { 7.0, 6.9, 9.5, 14.5, 18.4, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };
            double[] data2 = { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };


            lista.Add(new SerieLinearTempo("Busca linear", data1));
            lista.Add(new SerieLinearTempo("O(n)", data2));

            return lista;
        }

    }
}
