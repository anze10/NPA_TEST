using System;

class vaja_tri
{
    public static void Main(string[] args)
    {
        float[] seznam = new float[20];
        napolni_seznam(seznam);
    }
    public static void napolni_seznam(float[] seznam)
    {
        Random rnd = new Random();
        for (int i = 0; i < seznam.Length; i++)
        {
            seznam[i] = rnd.Next(20,101); 
        }       
    }
}