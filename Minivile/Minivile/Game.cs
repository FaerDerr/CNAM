using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Game
    {
        public Player joueurHumain;
        public Player joueurMachine;

        public Die de = new Die();
        public Pile pile = new Pile();

        public Game()
        {
            joueurHumain = new Player("humain", 0);
            joueurMachine = new Player("ia", 0);
            
        }

        public void Run()
        {
            while (joueurHumain.argent < 20 || joueurMachine.argent < 20) {
                //tour Joueur
                Lancer();
                joueurHumain.lanceur = true;
                joueurMachine.Regarder(de.face, "vert", joueurHumain);
                joueurHumain.Regarder(de.face, "rouge", joueurMachine);
                joueurHumain.Jouer(pile.pileCards);
                joueurHumain.lanceur = false;

                //tour IA
                Lancer();
                joueurMachine.lanceur = true;
                joueurHumain.Regarder(de.face, "vert", joueurMachine);
                joueurMachine.Regarder(de.face, "rouge",joueurHumain);
                joueurMachine.Jouer(pile.pileCards);
                joueurMachine.lanceur = false;

                //IDEM, MAIS AVEC HUMAIN -> MACHINE
            }

        }

        public int Lancer()
        {
            de.Lancer();
            return de.face;
        }
    }
}
