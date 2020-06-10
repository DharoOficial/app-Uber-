namespace Uber
{
    public class conta
    {
        private string agencia { get; set; }

        private string contaAgencia { get; set; }
        public string cadastrar(){
            return "cadastrado";
        } 
        public void excluir(string excluir){
            System.Console.WriteLine("Digite (excluir) se você deseja excluir o cartao");
            excluir = System.Console.ReadLine();
            if( excluir == "exclui" ){
                System.Console.WriteLine("cartao excluido");
            }
        }
    }
}