namespace Prototype.Carros
{
    public class Carro : CarroPrototype
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public override CarroPrototype Clone()
        {
            return (CarroPrototype)this.MemberwiseClone();
        }
    }
}
