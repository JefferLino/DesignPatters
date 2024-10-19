using Flyweight.Jogos.Classes;

namespace Flyweight.Jogos.PadraoFlyweight
{
    public class FlyweightPadrao
    {
        private Dictionary<string, Tartaruga> lista_de_tartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor) 
        {
            Tartaruga tartaruga = null;

            if (!lista_de_tartarugas.ContainsKey(cor)) 
            {
                switch (cor)
                {
                    case "azul": tartaruga = new TartarugaAzul(); break;
                    case "verde": tartaruga = new TartarugaVerde(); break;
                    case "laranja": tartaruga = new TartarugaLaranja(); break;
                    case "vermelha": tartaruga = new TartarugaVermelha(); break;
                }

                lista_de_tartarugas.Add(cor, tartaruga);
            }

            return lista_de_tartarugas[cor];
        }
    }
}
