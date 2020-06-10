namespace Uber
{
    public class Motorista
    {
        private string carro { get; set; }
        private string placa { get; set; }
        public string AceitarPassageiro(string nome){
                return "passageiro aceito";
        }
        public string ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizado"){ 
            return "pagamento recebido";
            }
            return "Pagamento pendente pois a corrida não foi finalizada";
        }
    }
}