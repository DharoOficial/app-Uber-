namespace Uber
{
    public class Cartao
    {
        private int numero { get; set; }
        private int titular { get; set; }
        private int cvv { get; set; }
        private string bandeira { get; set; }
        public string cadastrar(){
            return "cartao cadastrado";
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