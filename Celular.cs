namespace CelularMetodo
{
    public class Celular
    {

        public string modelo;

        public string cor;

        public double tamanho;

        public string os;
        
        public string processador;

        public string ram;

        public string rom;

        public bool Ligar()
        {
            bool ligado = true;

            return ligado;
        }


        public bool Desligar()
        {
            bool desligar = false;

            return desligar;
        }
        

        public string Ligacao()
        {
            string ligacaoCelular = "Ligando...";

            return ligacaoCelular;
        }


        public string Mensagem()
        {
            string mensagemCelular = "Mensagem enviada!";

            return mensagemCelular;
        }

    }
}