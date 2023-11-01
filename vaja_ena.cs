using System;



class vaja_ena
{
     public static int pozST(int a)
    {
        if (a > 0)
        {
            return a;
        }
        else {
            throw new InvalidDataException("Napačen vnos");
             }
    }



     public static int [] razcepST(int a)
    {
        int najST = 0;
        int skupnoST = 0;
        while (a != 0)
        {

            int b = a % 10;
             najST = Math.Max(b, najST);
             skupnoST = skupnoST + b;
             a = a / 10;

         }
         return new int[] {najST, skupnoST};
     }

    static void Main(string[] args)
    {
       int a = Convert.ToInt32(Console.ReadLine());
       pozST(a);
       int[] spremenlivke = razcepST(a);
        Console.WriteLine("{0} {1}", spremenlivke[0], spremenlivke[1]);
        Console.ReadLine();
    }

}
