using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AnaliseDeComplexidade1.Models
{
    public class SerieComplexidade
    {
        // name: 'NVDA',
        // data: [34.8, 43.0, 51.2, 41.4, 64.9, 72.4]

        public string name{get; set;}
        public double[] data {get; set;}

        public SerieComplexidade()
        {

        }

        public SerieComplexidade(string name, double[] data)
        {
            this.name = name;
            this.data = data;

        }


        public List<SerieComplexidade> GetDataDummy()
        {
            /*
                    series: [
            {
                name: 'Laços aninhados',
                data: [34.8, 43.0, 51.2, 41.4, 64.9, 72.4],
                color: colors[2],
                accessibility: {
                    description: 'analise do comportamento de uma busca com laços aninhados'
                }
            }, {
                name: 'O(2n)',
                data: [69.6, 63.7, 63.9, 43.7, 66.0, 61.7],
                dashStyle: 'ShortDashDot',
                color: colors[0]
                */
            List<SerieComplexidade> lista = new List<SerieComplexidade>();

            double[] data1 = { 34.8, 43.0, 51.2, 41.4, 64.9, 72.4 };
            double[] data2 = { 69.6, 63.7, 63.9, 43.7, 66.0, 61.7 };
            lista.Add(new SerieComplexidade("Laços aninhados", data1));
            lista.Add(new SerieComplexidade("O(n)", data2));
            
            return lista;
        }

    }
}