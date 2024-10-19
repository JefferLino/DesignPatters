namespace Flyweight.Jogos.Classes
{
    public class TartarugaVermelha : Tartaruga
    {
        public TartarugaVermelha()
        {
            condicao = " tartaruga dentro do casco, ";
            acao = "rodando no chão - ";
        }

        public override void Mostra(string cor)
        {
            this.cor = cor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
