﻿﻿using System;
  using System.ComponentModel;
  using System.Windows.Forms;
  using GameMonsterWinForm;
  using TPjeu.Accessoire;
using TPjeu.Armes;

using TPjeu.Protections;

namespace TPjeu.Personnages
{
    public class Joueur
    {
        private De de;
        public  decimal pointVie;
        
        private Armure corps;
        private Epee arme;
        private string nom;
       
       
        

        public bool estVivant
        {
            get {return pointVie > 0;}
            
        }

        public  decimal PointVie
        {
            get => pointVie;
            private set => pointVie = value;
        }

       
       
        public Joueur(string nomDuHero,decimal vieHero, decimal armureDuHero, decimal degatsHero)
        {
            de = new De();
            pointVie = vieHero;
            nom = nomDuHero;
            corps = new Armure(armureDuHero);
            arme = new Epee(degatsHero);
        }


        public int lancerDe(int valeur )
        {
            return De.lancerDe(valeur);
        }
        

      

        public void attaque(Boss boss)
        {
            decimal degats = lancerDe(26) + arme.degatsCAC;

            Form1.combat.AppendText(Narration.espace());
            Form1.combat.AppendText("Il vous reste " + PointVie + " PV, ");

            Form1.combat.AppendText(DialogueJoueur.effetDegatsJoueur(degats));
            Form1.combat.AppendText("vous infigez au boss " + degats + " dégats d'épée\n"); 
            boss.subitDegats(degats);
                
            
        }


        public  decimal subitDegats(decimal degats)
        {
            if (bouclier(degats) == true)
            {
                Form1.combat.AppendText(DialogueJoueur.esquive());
                return pointVie;
            } 
            if(Armure.estEntiere == true )
            {
                corps.encaisserDegats(degats, corps); 
                return pointVie;
            }
            else
            {
                return pointVie -= degats;
            }
        }

       

        public  bool bouclier(decimal degats)
        {
            int score = lancerDe(6);

            if (score <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
       
      
    }
}