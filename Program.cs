using System;

namespace Uber
{
    class Program
    {
        static void Main(string[] args)
        {
         Usuario user = new Usuario();
         Passageiro Erick = new Passageiro();

            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){

                Console.WriteLine("Acesso liberado! Usuário logado");
                System.Console.WriteLine(user.TokenLogin);
                Erick.ProcurarMotorista();
                System.Console.WriteLine("digite o local escolhido");
                Erick.EscolherLocal();
                System.Console.WriteLine(user.valor);
                Erick.cancelar();
                System.Console.WriteLine("a corrida foi finalizada? se sim digite finalizada para autorizar o pagamento");
                Erick.Pagar( Console.ReadLine());


                

            }else{
                Console.WriteLine("Usuario deslogado");

            }
        }
    }
}
