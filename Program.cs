using System;
using System.Collections.Generic;
namespace Combat
{
	public class Fighter
	{
		public string Name;
		public int Health, DamagePerAttack;
		public Fighter(string name, int health, int damagePerAttack)
		{
			this.Name = name;
			this.Health = health;
			this.DamagePerAttack = damagePerAttack;
		}


	}

	public class Kata
	{
		public static void Main()
		{ 
			Fighter fighter1 = new Fighter("fighter1", 100, 10);
			Fighter fighter2 = new Fighter("fighter2", 100, 10);

			declareWinner(fighter1,fighter2, "");

		}
		public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
		{

			string Winner = "";
			Random rng = new Random();
			int pick = rng.Next(0,2);
			if (pick == 0)
			{
				firstAttacker = "fighter1";
				Console.WriteLine("Fighter1 is attacking first!");
				while (fighter1.Health > 0 && fighter2.Health > 0)
				{
					fighter2.Health -= fighter1.DamagePerAttack;
					Console.WriteLine("Fighter1 has done {0} damage!, Fighter2 has {1} health left.", fighter2.DamagePerAttack, fighter1.Health);
					fighter1.Health -= fighter2.DamagePerAttack;
					Console.WriteLine("Fighter2 has done {0} damage!, Fighter1 has {1} health left.", fighter1.DamagePerAttack, fighter2.Health);
				}
				if (fighter1.Health > fighter2.Health)
				{
					return Winner = "Fighter1 is the winner!!! Rest in peace fighter2..";
				}
			}
			else 
			{
				firstAttacker = "fighter2";
				Console.WriteLine("Fighter2 is attacking first!");
				while (fighter1.Health > 0 && fighter2.Health > 0)
				{
					fighter1.Health -= fighter2.DamagePerAttack;
					Console.WriteLine("Fighter2 has done {0} damage!, Fighter1 has {1} health left.", fighter1.DamagePerAttack, fighter2.Health);
					fighter2.Health -= fighter1.DamagePerAttack;
					Console.WriteLine("Fighter1 has done {0} damage!, Fighter2 has {1} health left.", fighter2.DamagePerAttack, fighter1.Health);
				}
				if (fighter2.Health > fighter1.Health)
				{
					return Winner = "Fighter2 is the winner!!! Rest in peace fighter1..";
				}

			}
			return Winner;

		}

	}
}