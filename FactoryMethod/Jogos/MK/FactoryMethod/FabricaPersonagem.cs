using FactoryMethod.Jogos.MK.Classes.Personagens;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.Interface.Personagens;

namespace FactoryMethod.Jogos.MK.FactoryMethod
{
    public class FabricaPersonagem
    {
        public IPersonagem EscolherPersonagem(PersonagemSelecionado personagemSelecionado) 
        {
            return personagemSelecionado switch
            {
                PersonagemSelecionado.KUNG_LAO => new KungLao(),
                PersonagemSelecionado.SUB_ZERO => new SubZero(),
                PersonagemSelecionado.SCORPION => new Scorpion(),
                PersonagemSelecionado.LIU_KANG => new LiuKang(),
                _ => new LiuKang(),
            };
        }
    }
}
