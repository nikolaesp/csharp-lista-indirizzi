// See https://aka.ms/new-console-template for more information
using csharp_lista_indirizzi;
using System.IO;
using System.Runtime.CompilerServices;

List<Addresses> listaddress = new List<Addresses>();


try
{
    StreamReader file = File.OpenText("D:\\ProgGeneration\\csharp-lista-indirizzi\\File\\addresses.csv");

    while (!file.EndOfStream)
    {
        string line = file.ReadLine();

       
        //Console.WriteLine(line);
        string[] addresses = line.Split(',');
        if (addresses.Length >= 6) {
            string nome = addresses[0];

            string cognome = addresses[1];

            string via = addresses[2];

            string cita = addresses[3];

            string provincia = addresses[4];

            string zip = addresses[5];


            Addresses indirizi = new Addresses(nome, cognome, via, cita, provincia, zip);
            listaddress.Add(indirizi);
        }
        else { Console.WriteLine("Adressa non e scritta benne !!!"); }
    }

    file.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//Console.WriteLine("---------------------------------------------EOF-!");
foreach (Addresses indirizzo in listaddress)
{
    Console.WriteLine(indirizzo);
}