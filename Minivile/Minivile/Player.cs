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



        public void Jouer(List<Card> pile)
        {
            //regarder la pile de carte, entrer l'index de la carte qu'on veut jouer
            string i;
            while (true)
            {
                //Si le joueur est humain, lui laisser le choix
                if (joueur == "humain")
                {
                    Console.Clear();
                    Console.WriteLine("--- Entrez l'index correspondant à la carte que vous voulez jouer ---");
                    Console.WriteLine("---             Ou entrez skip pour passer votre tour             ---\n");

                    foreach (Card c in pile)
                    {
                        Console.WriteLine("{0} || {1} : {2} ( {3} ).", c.id, c.name, c.effect, c.color);
                    }

                    Console.Write("\n> Entrez votre choix :");
                    i = Console.ReadLine();
                }
                else
                {
                    Random rand = new Random();
                    i = ((rand.Next(0, 8) + 1).ToString());
                    if (i == "9")
                    {
                        i = "skip";
                    }
                }

                //Si i est égal à skip, on passe le tour du joueur
                if (i == "skip")
                {
                    break;
                }

                //Si on a l'argent nécessaire, on sort de la boucle
                if (argent - pile[int.Parse(i)].cost > 0)
                {
                    //On ajoute la nouvelle carte à la main, en utilisant l'index de cette dernière
                    var carte = pile[int.Parse(i)];
                    main.Add(new Card(carte.id, carte.color, carte.cost, carte.name, carte.effect, carte.dice, carte.gain));
                    break;
                }
                
            }

            
        }

        public void Regarder(int faceDe, string couleurInterdite, Player ennemi )
        {
            //Regarde la main du joueur en cours.        
            foreach (Card c in main)
            {
                //Pour chaque carte, si la mauvaise couleur n'est pas présente et qu'il s'agit du bon dé, son effet s'applique.
                if (c.dice == faceDe && couleurInterdite != c.color)
                {
                    switch (c.id) //On applique les différents effets selon l'identifiant des cartes possédés
                    {
                        case 1:
                            argent += 1;
                            break;
                        case 2:
                            argent += 1;
                            break;
                        case 3:
                            argent += 2;
                            break;
                        case 4:
                            argent += 1;
                            ennemi.argent -= 1;
                            break;
                        case 5:
                            argent += 3;
                            break;
                        case 6:
                            argent += 1;
                            break;
                        case 7:
                            argent += 2;
                            ennemi.argent -= 2;
                            break;
                        case 8:
                            argent += 4;
                            break;
                    }
                }

            }

        }



    }
}
