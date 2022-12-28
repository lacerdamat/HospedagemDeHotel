using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite
    {
        private string _nome;
        private int _capacidade;
        private decimal _precodiaria;
        public string Nome{ 
            get => _nome;  
            set {
                if (value == null){
                    Console.WriteLine("Insira um nome válido!");
                }
                else{
                    _nome = value;
                }
            } 
        }
        public int Capacidade{ 
            get => _capacidade;
            set{
                if (value <=0){
                    Console.WriteLine("Insira um valor válido!");
                }
                else{
                _capacidade = value;
                }
            }
        }
        public decimal PrecoDiaria{ 
            get => _precodiaria;
            set{
                if (value <= 0){
                    Console.WriteLine("Insira um valor válido!");
                }
                else{
                    _precodiaria = value;
                }
            }
        }
    }
}
