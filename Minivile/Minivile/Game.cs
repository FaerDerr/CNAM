﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Game
    {
        public Player joueurHumain;
        public Player joueurMachine;

        public Die de;

        public Game()
        {
            joueurHumain = new Player("humain", 0);
            joueurMachine = new Player("ia", 0);
        }

        public void Run()
        {
            while (true) {
                //tour IA
                Lancer();
                joueurHumain.lanceur = true;
                joueurMachine.Regarder(de.face, "vert");
                joueurHumain.Regarder(de.face, "rouge");
                joueurHumain.Jouer();
                joueurHumain.lanceur = false;

                //tour IA
                Lancer();
                joueurMachine.lanceur = true;
                joueurHumain.Regarder(de.face, "vert");
                joueurMachine.Regarder(de.face, "rouge");
                joueurMachine.Jouer();
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
