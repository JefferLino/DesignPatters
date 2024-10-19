using FactoryMethod.Jogos.MK.Enumerados;

namespace FactoryMethod.Jogos.MK.Classes.Golpes
{
    public class GolpePadrao
    {
        public double Dano { get; set; }

        public LocalGolpe LocalGolpe { get; set; }

        public bool InimigoBloqueiou { get; set; }

        public GolpePadrao(double dano, LocalGolpe localGolpe, bool inimigoBloqueiou)
        {
            Dano = dano;
            LocalGolpe = localGolpe;
            InimigoBloqueiou = inimigoBloqueiou;
        }

        public void ExcutarGolpe()
        {
            switch (LocalGolpe)
            {
                case LocalGolpe.CABECA:
                    Dano = InimigoBloqueiou ? Dano - 5 : Dano;
                    break;
                case LocalGolpe.TRONCO:
                    Dano = InimigoBloqueiou ? Dano - 7 : Dano;
                    break;
                case LocalGolpe.BRACOS:
                    Dano = InimigoBloqueiou ? Dano - 9 : Dano;
                    break;
                case LocalGolpe.PERNAS:
                    Dano = InimigoBloqueiou ? Dano - 10 : Dano;
                    break;
                default:
                    break;
            }

            Console.Write($"Dano do golpe: {Dano}. Local:{LocalGolpe}");
        }
    }
}
