﻿namespace Prototype.Jogos.SMW.Classes
{
    public class GerenciadorNuvens
    {
        private Dictionary<string, NuvemMolde> nuvens = new Dictionary<string, NuvemMolde>();

        public NuvemMolde this[string key]
        {
            get { return nuvens[key]; }
            set { nuvens.Add(key, value); }
        }
    }
}
