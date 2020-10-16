﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            lesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            return lesCaves[unNomDeCave].Count;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int nb=0;
            foreach (Bouteille b in lesCaves[unNomDeCave])
            {
                if (b.LeVin.LaCouleur.NomCouleur.CompareTo("Rouge") == 0)
                {
                    nb++;
                } 
            }
            return nb;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double prixTt = 0;
            foreach (Bouteille b in lesCaves[unNomDeCave])
            {
                prixTt = b.LeVin.PrixDuVin + prixTt;
            }
            return prixTt;
        }
    }
}
