using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeavd1.Model
{
    public class Cliente

    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

        public Carro carro { get; set; }

        public Cliente(int id, string nome, int idade, Carro carro)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.carro = carro;
        }
    }
}
