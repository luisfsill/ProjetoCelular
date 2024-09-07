namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } // Propriedade para o modelo do smartphone
        public string IMEI { get; set; }   // Propriedade para o número IMEI do smartphone
        public int Memoria { get; set; }   // Propriedade para a capacidade de memória do smartphone

        // Construtor que recebe todos os parâmetros e os atribui às propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber uma ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativos, deve ser implementado pelas classes derivadas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
