namespace Uber
{
    public class Corrida
    {
        private string localInicio { get; set; }
        private string  localChegada { get; set; }
        private int distancia = 55;
        private int status { get; set; }
        private string motorista { get; set; }
        private string passageiro { get; set; }
        private int valor { get; set; }
        private string cancelar(){ 
            return "corrida cancelada";
        }
        public int calcularValor(){
            return distancia * 15;
        }
    }
}