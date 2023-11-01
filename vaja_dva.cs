using System;

class vaja_dva{
	
	public static void Main(){
		int stevec = 0;
		Random rnd = new Random();
		while (stevec != 3){
			int a = rnd.Next(0, 2);
			switch(a){
				case 0:
					Console.WriteLine("padla je cifra");
					stevec ++;
					break;
				case 1:
					Console.WriteLine("Padel je grb");
					stevec = 0;
					break;
			}
			
		}
		
	}
}