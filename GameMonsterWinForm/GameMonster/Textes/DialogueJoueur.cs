
namespace TPjeu
{
    public class DialogueJoueur
    {
        public static string esquive()
        {
            return " Joueur -> Et hop! esquive!";
        }
        public static string tueBoss()
        {
            return " Joueur -> Meurs donc !! Créature infame. \n";
        }
        public static string mortMonstre()
        {
            return" Joueur -> Il sont trop nombreux.\n Oh mais non je vais mourir tuer par des zombies puant!\n la honte.";
        }

        public static string deuxiemeMort()
        {
            return " Joueur -> AH NON MAIS C'EST PAS VRAI JE VAIS ENCORE MOURRIR !! \n ";
        }
        
         public static string effetDegatsJoueur(decimal degats)
        {
            switch (degats)
            {
                case 1:
                {
                    return" Joueur -> Ca piquotte un peu mais ca va!\n"; 
                    
                }
                case 2:
                {
                    return" Joueur -> Ah! tu l'as pas volé celle la.\n"; 
                    
                } case 3:
                {
                    return" Joueur -> tiens, un petit coup de hache pour la route .\n"; 
                    
                } case 4:
                {
                    return" Joueur -> Ah tu l'as senti passé celle la.\n"; 
                    
                }
                case 5:
                {
                    return" Joueur -> Et BIM dans les dents.\n"; 
                    
                } case 6:
                {
                    return" Joueur -> Celui la il va faire mal. \n"; 
                    
                } 
                case 7:
                {
                    return" Joueur -> Ca piquotte un peu mais ca va!\n"; 
                    
                }
                case 8:
                {
                    return" Joueur -> Tiens! un coup de pied bien placé.\n"; 
                    
                } case 9:
                {
                    return" Joueur -> Arrete ou tu vas prendre une torgnolle. \n"; 
                    
                } case 10:
                {
                    return" Joueur -> Ah tu l'as pas vu venir.\n"; 
                    
                }
                case 11:
                {
                    return" Joueur -> Temps mort! Je fatigue la ....et tiens, t'es trop naîf^^.\n"; 
                    
                } case 12:
                {
                    return" Joueur -> ... \n"; 
                    
                } case 13:
                {
                    return" Joueur -> Tu vas souffrir!\n"; 
                    
                }  case 14:
                {
                    return" Joueur -> Un coup d'épée tu m'en diras des nouvelles.\n"; 
                    
                }  case 15:
                {
                    return" Joueur -> tiens, un petit coup de hache pour la route .\n"; 
                    
                } case 16:
                {
                    return" Joueur -> Ah tu l'as senti passé celle la.\n"; 
                    
                }
                case 17:
                {
                    return" Joueur -> Et BIM dans les dents.\n"; 
                    
                } case 18:
                {
                    return" Joueur -> Celui la il va faire mal .\n"; 
                    
                } 
                case 19:
                {
                    return" Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang.!\n"; 
                    
                }
                case 20:
                {
                    return" Joueur -> Tiens! un coup de pied bien placé.\n"; 
                    
                } case 21:
                {
                    return" Joueur -> Arrete ou tu vas prendre une torgnolle. \n"; 
                    
                } case 22:
                {
                    return" Joueur -> Ah tu l'as pas vu venir.\n"; 
                    
                }
                case 23:
                {
                    return" Joueur -> Ah ! mais c'est dégeulasse tu pisse le sang.\n"; 
                    
                } case 24:
                {
                    return" Joueur -> ... \n"; 
                    
                } case 25:
                {
                    return" Joueur -> Tu vas souffrir!\n"; 
                    
                }  case 26:
                {
                    return" Joueur -> Un coup d'épée tu m'en diras des nouvelles.\n"; 
                    
                }
            }

            return "";
        }
        
    }
}