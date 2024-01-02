namespace DesafioPOO.Models

{
       // Implementado 
    public class Iphone : Smartphone
    {
        public Iphone(string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {

        }
        // Implementado 
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("O aplicativo " + nomeApp + " foi instalado no Iphone.");
        }
    }
}