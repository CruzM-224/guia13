using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

struct cancion {
  public string artista;
  public string titulo;
  public Double duracion;
  public Double size;
}

class MainClass {
  static StreamWriter escribir;
  public static void Main (string[] args) {
    cancion cancion1 = new cancion();

    Console.WriteLine("Ingrese los datos de la cancion");
    
    Console.Write("Artista: ");
    cancion1.artista = Console.ReadLine();

    Console.Write("Titulo: ");
    cancion1.titulo = Console.ReadLine();

    Console.Write("Duracion en segundos: ");
    cancion1.duracion = Double.Parse(Console.ReadLine());

    Console.Write("Tamaño en KB: ");
    cancion1.size = Double.Parse(Console.ReadLine());

    Console.Clear();

    escribir = new StreamWriter("cancion.txt", true);

    Console.WriteLine("Artista: " + cancion1.artista);

    Console.WriteLine("Titulo: " + cancion1.titulo);

    Console.WriteLine("Duracion en segundos: " + cancion1.duracion + " seg");

    Console.WriteLine("Tamaño: " + cancion1.size + " KB");

    escribir.WriteLine("Artista: " + cancion1.artista);

    escribir.WriteLine("Titulo: " + cancion1.titulo);

    escribir.WriteLine("Duracion en segundos: " + cancion1.duracion + " seg");

    escribir.WriteLine("Tamaño: " + cancion1.size + " KB");
    escribir.Close();
    Process.Start("cancion.txt");
  }
}