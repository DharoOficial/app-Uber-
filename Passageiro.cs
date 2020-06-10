namespace Uber
{
    public class Passageiro : Usuario
    {
        public string local { get; set; }
        public string ProcurarMotorista(){
            return "Procurando motoristas disponíveis...";
            
        }

        public string Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }

            return "Pagamento pendente pois a corrida não foi finalizada";
        }
        public string EscolherLocal(){
            local = System.Console.ReadLine();
            return local;
            
        }
        // public string cancelar(){
        //    return "corrida cancelada";
        // }

    }

}