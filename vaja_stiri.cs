using System;

class vaja_stiri{
	
	public static void Main(string[] args){
		int stranica = Convert.ToInt32(Console.ReadLine());
		double plo = ploscina(stranica);
		Console.WriteLine("Trikotnik s stranico a = {0} ima ploščino {1}." stranica,plo);
	}
	
	public static double ploscina(stranica){
		double plo= (stranica * Math.Sqrt(3))/2;
		return plo;
	}
}