using System;

namespace p3_sentencias
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Sentencias sentencias = new Sentencias();
            sentencias.ejemploIF();
            Console.WriteLine( "" );
            sentencias.ejemploWHILE();
            Console.WriteLine( "" );
            sentencias.ejemploDOWHILE();
            Console.WriteLine( "" );
            sentencias.ejemploFOR();
            Console.WriteLine( "" );
            sentencias.ejemploSWITCH();
            Console.WriteLine( "" );
            sentencias.ejemploFOREACH();
            Console.WriteLine( "" );
            sentencias.ejemploBREAK();
            Console.WriteLine( "" );
            sentencias.ejemploCONTINUE();
            Console.WriteLine( "" );
            sentencias.ejemploGOTO();
            Console.WriteLine( "" );
		}
	}
}
