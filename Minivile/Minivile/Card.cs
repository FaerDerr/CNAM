using System;
using System.Reflection.Metadata.Ecma335;

namespace Miniville
{
	public struct Card
	{
		public int id { get; set; }
		public string color { get; set; }
		public int cost { get; set; }
		public string name { get; set; }
		public string effect { get; set; }
		public int dice { get; set; }
		public int gain { get; set; }


		public Card(int idC, string colorC, int costC, string nameC, string effectC, int diceC, int gainC)
        {
			this.id = idC;
			this.color = colorC;
			this.cost = costC;
			this.name = nameC;
			this.effect = effectC;
			this.dice = diceC;
			this.gain = gainC;
        }

		/*
		public int AppliquerEffet(Player p)
        {
			if (id == 1 || id == 2 || id == 6)
				p.gain += 1;

			else if (id == 3)
				p.gain += 2;

			else if (id == 5)
				p.gain += 3;

			else if (id == 8)
				p.gain += 4;
        }

		public void AppliquerCaféOuResto(Player a, Player b)
        {
			foreach(Card c in a.main)
            {
				if(c.id == 4)
                {
					if (!a.lanceur)
                    {
						a.gain += 1;
						b.gain -= 1;
                    }
                }

				if(c.id == 6)
                {
                    if (!a.lanceur)
                    {
						a.gain += 2;
						b.gain -= 2;
					}
                }
            }

			foreach(Card c in b.main)
            {
				if (c.id == 4)
				{
					if (!b.lanceur)
					{
						a.gain -= 1;
						b.gain += 1;
					}
				}

				if (c.id == 6)
				{
					if (!b.lanceur)
					{
						a.gain -= 2;
						b.gain += 2;
					}
				}
			}
        }
		*/
	}



}