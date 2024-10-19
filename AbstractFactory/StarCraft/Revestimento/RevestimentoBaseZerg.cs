﻿using AbstractFactory.StarCraft.Interfaces.Base;

namespace AbstractFactory.StarCraft.Revestimento
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}
