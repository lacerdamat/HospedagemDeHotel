using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto { 
            get=>  Nome+ " "+Sobrenome; 
        }


    }
}