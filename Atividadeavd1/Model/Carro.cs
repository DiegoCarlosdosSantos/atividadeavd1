using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeavd1.Model
{

    public class Carro
    {
        public static int totalCarros = 0;

        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anoFabricacao { get; set; }

        public Carro()
        {
            totalCarros++;
        }

        public Carro(int id, string marca, string modelo, int anoFabricacao)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            totalCarros++;
        }
    }
}