using Operatorok;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static  List<Kifejezes> Lista = new List<Kifejezes>();
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("kifejezesek.txt");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            var mezok = sr.ReadLine().Split(' ');

            Kifejezes uj = new Kifejezes(int.Parse(mezok[0]), mezok[1], int.Parse(mezok[2]));
        }
        sr.Close();


        Console.WriteLine("2.feladat: Kifejezések száma:" + Lista.Count());

        Console.WriteLine("3.feladat: Kifejezések maradékos osztással:" + Lista.Where(x => x.OPerator == "mod").Count());

        bool van = Lista.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0);

        Console.WriteLine($"{(van == true ? "Van ilyen kifejezés" : "Nincs ilyen kifejezés")}");

        Console.WriteLine("5.feladat: Statisztika:");
        Console.WriteLine($"\tmod -> {Lista.Count(a => a.OPerator == "mod")} db");
        Console.WriteLine($"\t  / -> {Lista.Count(a => a.OPerator == "/")} db");
        Console.WriteLine($"\tdiv -> {Lista.Count(a => a.OPerator == "div")} db");
        Console.WriteLine($"\t  - -> {Lista.Count(a => a.OPerator == "-")} db");
        Console.WriteLine($"\t  * -> {Lista.Count(a => a.OPerator == "*")} db");
        Console.WriteLine($"\t  + -> {Lista.Count(a => a.OPerator == "+")} db");




        using (StreamWriter fajl = new StreamWriter("eredmenyek.txt"))
        {
            Lista.ForEach(x => fajl.WriteLine(x.ToString()));
        }
        Console.WriteLine("8. feladat: eredmenyek.txt");
        Console.ReadKey();

    }
}