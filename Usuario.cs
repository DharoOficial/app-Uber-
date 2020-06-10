namespace Uber
{
     public class Usuario
    {
        public string nome { get; set; }
        public string Nome { get; set; }        
        private string login = "paulo@gmail.com";
        private string senha = "123456789";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public string localInicio { get; set; }
        public string  localChegada { get; set; }
        public int distancia = 55;
        public int status { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }
        public int valor { get; set; }
        public bool Login(string login, string senha){
            
            if(this.login == login && this.senha == senha){
                TokenLogin = "qweqweqweqweqwewqe1231231231231232";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
        public string cancelar(){ 
            return "corrida cancelada";
        }
        public int calcularValor(){
            valor = distancia * 15;
            return valor;
            
        }

    }
}