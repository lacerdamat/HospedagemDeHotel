using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hospedagem
    {
        
        List<Suite> Suites = new List<Suite>();
        List<Pessoa> Hospedes = new List<Pessoa>();
        Dictionary<Pessoa, Suite> Reservagem = new Dictionary<Pessoa, Suite>();
        
        public void IniciarSistem(){
            Console.WriteLine("O que deseja fazer? \r\n1 - Check-in. \r\n2 - Cadastrar uma suíte."+
            "\r\n3 - Listar os hóspedes. \r\n4 - Listar as suítes cadastradas. \r\n5 - Reservar uma suíte"+
            "\r\n6 - Check-out. \r\n7 - Encerrar sistema");
            string escolha = Console.ReadLine();
            switch(escolha){
                case "1": CadastrarUsuario(); break;
                case  "2": CadastrarSuite(); break;
                case "3": ContarHospedesFunc(); break;
                case "4": ContarSuitesFunc(); break;
                case "5": AlocarNaSuite(); break;
                case "6": CheckOUT(); break;
                case "7": Console.WriteLine("Sistema encerrado com sucesso!"); Environment.Exit(0); break;
                default: Console.WriteLine("Insira uma opção válida!"); ReiniciarSistema(); break;
            }
        }
        public void ReiniciarSistema(){
            Console.WriteLine("Pressione qualquer tecla para continuar");
            if (Console.ReadLine() != null){
                Console.Clear();
                IniciarSistem();
            }
        }
        public void CadastrarUsuario(){
            Console.WriteLine("Você escolheu a opção 'Cadastrar Usuário' \r\n Digite seu nome e após, o seu sobremome");
            Pessoa hospede = new Pessoa();
            hospede.Nome = Console.ReadLine();
            hospede.Sobrenome = Console.ReadLine();
            Console.WriteLine("Agora me diga, quantos dias deseja ficar");
            hospede.DiasReservados = Convert.ToInt32(Console.ReadLine());
            Hospedes.Add(hospede);
            Console.WriteLine("Seja bem vindo, senhor " + hospede.NomeCompleto + ", se sinta bem nesses " 
            + hospede.DiasReservados+ " dias.");
            ReiniciarSistema();
        }

        public void CadastrarSuite(){
            Console.WriteLine("\r\nAgora, escreva o preço da suíte, quantas pessaos ela suporta e o seu nome: ");
            Suite suite = new Suite();
            suite.PrecoDiaria = Convert.ToDecimal(Console.ReadLine());
            suite.Capacidade = Convert.ToInt32(Console.ReadLine());
            suite.Nome = (Console.ReadLine());
            Suites.Add(suite);
            Console.WriteLine("Preço da suíte: " + suite.PrecoDiaria + " reais, a capacidade da suíte: " + suite.Capacidade +
             (suite.Capacidade > 1? " pessoas " :" pessoa ") + "e o nome da suíte " + suite.Nome);
             ReiniciarSistema();
        }
        
        public void ContarHospedesFunc(){
            Console.WriteLine("\r\nPessoas hospedadas: " + Hospedes.Count());
            ExibirHospedes();
             ReiniciarSistema();
        }
        public void ExibirHospedes(){
        int count = 0;
        foreach(Pessoa s in Hospedes){
            Console.WriteLine(count+1 + "° - Hóspede: "+s.NomeCompleto+". Dias Reservados: "+s.DiasReservados);
            count++;
            }
        }
        public void ContarSuitesFunc(){
            Console.WriteLine("\r\nSuítes cadastradas: " + Suites.Count());
            ExibirSuites();
            ReiniciarSistema();
        }
        public void ExibirSuites(){
        int count = 0;
        foreach(Suite s in Suites){
            Console.WriteLine(count+1 + "° - Suíte "+s.Nome+". Capacidade: "+s.Capacidade + ". Preço da Diária: " + s.PrecoDiaria);
        }
        }
        public void AlocarNaSuite(){ 
            Console.WriteLine("Qual hóspede irá alocar?");
            ExibirHospedes();
            int countH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E em qual suíte irá residir?");
            ExibirSuites();
            int countS = Convert.ToInt32(Console.ReadLine());
            if (Suites[countS-1].Capacidade !=0){
                Reservagem.Add(Hospedes[countH-1],Suites[countS-1]);
                Suites[countS-1].Capacidade--;
                ReiniciarSistema();
            }
            else{
                Console.WriteLine("A alocagem não foi feita pois a suíte está lotada!");
                ReiniciarSistema();
            }
        }
        
        public void CheckOUT(){
            decimal desconto = 0.1M;
            Console.WriteLine("Quem deseja fazer Check-out?");
            ExibirHospedes();
            int countH = Convert.ToInt32(Console.ReadLine());
            bool temDesconto = Hospedes[countH-1].DiasReservados >= 10;
            decimal PrecoFinal = temDesconto? Hospedes[countH-1].DiasReservados*desconto*Reservagem[Hospedes[countH-1]].PrecoDiaria : Hospedes[countH-1].DiasReservados*Reservagem[Hospedes[countH-1]].PrecoDiaria;
            Console.WriteLine("\r\nO preço total foi " + PrecoFinal + (temDesconto? " Teve desconto de 10%!" : null));
            Reservagem[Hospedes[countH-1]].Capacidade++;
            Reservagem.Remove(Hospedes[countH-1]);
            ReiniciarSistema();
        }
    }
}
