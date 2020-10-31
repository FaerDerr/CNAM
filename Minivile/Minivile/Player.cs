using System;
using System.Collections.Generic;
using System.Text;

namespace Miniville
{
    class Player
    {
        public string joueur; // humain ou Ia
        public bool lanceur; // Est-il le lanceur ?
        public int argent;
        

        public List<Card> main; // correspond aux cartes jouées par le joueur

        public Player(string type, int dollar)
        {
            joueur = type;
            lanceur = false;
            argent = dollar;
        }



        public void Jouer()
        {
            //regarder la pile de carte, entrer l'index de la carte qu'on veut jouer
            //Si on a la thune, elle est jouée (crée dans List Main)
            //sinon, recommencer à regarder, taper skip pour ne rien faire   
        }

        public void Regarder(int faceDe, string couleurInterdite)
        {
            //Regarde la main du joueur en cours.
            //Pour chaque carte, si la mauvaise couleur n'est pas présente et qu'il s'agit du bon dé, son effet s'applique.
            //if carte ID == 4 Game.joueurMachine.argent += 1 tatata Game.joueurHumain.argent -= 1;
        }

        

    }
}
