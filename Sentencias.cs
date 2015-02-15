using System;

namespace p3_sentencias
{
	public class Sentencias
	{
		public Sentencias ()
		{
		}

		public void ejemploIF(){
			bool bandera = true;
			if ( bandera == true )
			{
				Console.WriteLine( "La bandera es verdadera." );
			}
			else
			{
				Console.WriteLine( "La bandera es falsa." );
			}
		}

		public void ejemploSWITCH(){
			int caseSwitch = 2;
			switch (caseSwitch)
			{
				case 1:
					Console.WriteLine("Caso 1");
					break;
				case 2:
					Console.WriteLine("Caso 2");
					break;
				default:
					Console.WriteLine("Caso por default");
					break;
			}
		}

		public void ejemploWHILE(){
			int n = 1;
			while (n < 6)
			{
				Console.WriteLine( "El número actual es " + n );
				n++;
			}
		}

		public void ejemploDOWHILE(){
			int x = 0;
			do
			{
				Console.WriteLine( "El número actual es " + x );
				x++;
			} while (x < 6);
		}

		public void ejemploFOR(){
			for ( int i = 1; i <= 5; i++ )
			{
				Console.WriteLine( "El número actual es " + i );
			}
		}

		 public void ejemploFOREACH(){
			int[] numeros = new int[] { 0, 1, 2, 3, 5, 8, 13 };
			foreach (int numero in numeros)
			{
				System.Console.WriteLine( "El número actual es " + numero );
			}
		}

		public void ejemploBREAK(){
			for (int i = 1; i <= 100; i++)
			{
				if (i == 5)
				{
					break;
				}
				Console.WriteLine( "El número actual es " + i );
			}
		}

		public void ejemploCONTINUE(){
			for (int i = 1; i <= 10; i++)
			{
				if (i < 9)
				{
					continue;
				}
				Console.WriteLine( "El número actual es " + i );
			}
		}

		public void ejemploGOTO(){
			Console.WriteLine( "Tamaños del cafe: 1=Pequeño 2=Mediano 3=Grande" );
			Console.Write( "Por favor indique su selección: " );
			string s = Console.ReadLine();
			int n = int.Parse(s);
			int cost = 0;
			switch (n)
			{
				case 1:
					cost += 25;
					break;
				case 2:
					cost += 25;
					goto case 1;
				case 3:
					cost += 50;
					goto case 1;
				default:
					Console.WriteLine( "Selección invalida." );
					break;
			}

			if (cost != 0)
			{
				Console.WriteLine( "Por favor pague " + cost );
			}

			Console.WriteLine( "Muchas gracias" );
		}
	}
}

