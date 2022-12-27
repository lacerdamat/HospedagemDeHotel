using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobremome)
        {
            Nome = nome;
            Sobrenome = sobremome;
        }
        private string _nome;
        private string _sobrenome;
        private int _diasreservados;
        public string Nome { 
            get => _nome; 
            set{
                if (value == null){
                    Console.WriteLine("Insira um nome válido!");
                }
                else{
                    _nome = value;
                }
            } 
        }
        public string Sobrenome { 
            get => _sobrenome; 
            set{
                if (value == null){
                    Console.WriteLine("Insira um sobrenome válido!");
                }
                else{
                    _sobrenome = value;
                }
            } 
        }
        public int DiasReservados {
            get => _diasreservados; 
            set{
                if (value <=0){
                    Console.WriteLine("Insira um valor válido!");
                }
                else{
                    _diasreservados = value;
                }
            }
        }
        public string NomeCompleto { 
            get=>  Nome+ " "+Sobrenome; 
        }


    }
}