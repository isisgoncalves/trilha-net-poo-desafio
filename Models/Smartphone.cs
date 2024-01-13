namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        protected string Marca { get; }
        protected string Modelo { get; }
    
        // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }
        
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //Nova instância
        public virtual void InstalarAplicativo(string nomeApp)
        {
        }
    }
}