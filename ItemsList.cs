using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace CarGame
{
    [Serializable]
    public class ItemsList
    {
        Player player;
        int score;
        protected Queue<Item> items;
		public ItemsList()
		{
			items = new Queue<Item>();
			score = 0;
			player = new Player();
		}
		public int NextIndex
		{
			get
			{
				return items.Count;
			}

		}
		public Player Player
		{
			get
			{
				return player;
			}
			set
			{
				player = value;
			}

		}
		public int Score
		{
			get
			{
				return score;
			}
			set
			{
				score = value;
			}
		}

		public Item Remove()
		{
			return items.Dequeue();
		}
		public Item showFirst()
        {
			return items.Peek();
        }
		public void Add(Item c)
        {
			
			
				items.Enqueue(c);

			
		}

	}
}
