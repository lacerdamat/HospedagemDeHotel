using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hospedagem
    {
        int DiasReservados;
        Suite suite = new Suite();
        List<Pessoa> Hospedes = new List<Pessoa>();
        public void CadastrarUsuário(){
            
            Pessoa hospede = new Pessoa();
            Console.WriteLine("Escreva nome, sobrenome e quantos dias o senhor quer ficar");
            hospede.Nome = Console.ReadLine();
            hospede.Sobrenome =  Console.ReadLine();
            DiasReservados = Convert.ToInt32(Console.ReadLine());
            Hospedes.Add(hospede);
            Console.WriteLine("Seja bem vindo, senhor " + hospede.NomeCompleto + ", se sinta bem nesses " 
            + DiasReservados+ " dias.");
            CadastrarSuite();
        }

        public void CadastrarSuite(){
            Console.WriteLine("\r\nAgora, escreva o preço da suíte, quantas pessaos ela suporta e o seu nome: ");
            suite.PrecoDiaria = Convert.ToDecimal(Console.ReadLine());
            suite.Capacidade = Convert.ToInt32(Console.ReadLine());
            suite.Nome = (Console.ReadLine());
            Console.WriteLine("Preço da suíte: " + suite.PrecoDiaria + " reais, a capacidade da suíte: " + suite.Capacidade +
             (suite.Capacidade > 1? " pessoas " :" pessoa ") + "e o nome da suíte " + suite.Nome);
             ContarHospedes();
        }
        
        public void ContarHospedes(){
            Console.WriteLine("\r\nPessoas hospedadas: " + Hospedes.Count());
            PrecoFinal();
        }
        public void PrecoFinal(){
            decimal desconto = 0.1M;
            bool temDesconto = DiasReservados >= 10;
            decimal PrecoFinal = temDesconto? DiasReservados*desconto*suite.PrecoDiaria : DiasReservados*suite.PrecoDiaria;
            Console.WriteLine("\r\nO preço total foi " + PrecoFinal + (temDesconto? " Teve desconto de 10%!" : null));

        }









































































    }
}