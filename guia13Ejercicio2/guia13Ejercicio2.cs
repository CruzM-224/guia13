using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

struct vehiculoDatos{
  public string placa;
  public string color;
  public int fecha;
  public string marca;
  public string modelo;
  public string propietario;
}

class MainClass {
  static StreamWriter escribir;
  public static void Main (string[] args) {
    int num;

    Console.WriteLine ("Numero de vehiculos de los cuales quiere almacenar datos");
    num = int.Parse(Console.ReadLine());
    
    vehiculoDatos[] vehiculos = new vehiculoDatos[num];

    for(int cont = 0; cont < num; cont++){
      Console.WriteLine("Vehiculo " + (cont + 1));

      Console.Write("Placa: ");
      vehiculos[cont].placa = Console.ReadLine();

      Console.Write("Color: ");
      vehiculos[cont].color = Console.ReadLine();

      Console.Write("Año: ");
      vehiculos[cont].fecha = int.Parse(Console.ReadLine());

      Console.Write("Marca: ");
      vehiculos[cont].marca = Console.ReadLine();
      
      Console.Write("Modelo: ");
      vehiculos[cont].modelo = Console.ReadLine();

      Console.Write("Propietario: ");
      vehiculos[cont].propietario = Console.ReadLine();

      Console.Clear();
    }

    mostrar(num, vehiculos);
  }

  static void mostrar(int num, vehiculoDatos[] vehiculos){
  
    escribir = new StreamWriter("vehiculos.txt", true);

    for(int cont = 0; cont < num; cont++){
      Console.WriteLine("Vehiculo " + (cont + 1));

      Console.WriteLine("Placa: " + vehiculos[cont].placa);

      Console.WriteLine("Color: " + vehiculos[cont].color);

      Console.WriteLine("Año: " + vehiculos[cont].fecha);

      Console.WriteLine("Marca: " + vehiculos[cont].marca);
      
      Console.WriteLine("Modelo: " + vehiculos[cont].modelo);

      Console.WriteLine("Propietario: " + vehiculos[cont].propietario);
      
      Console.WriteLine();

      escribir.WriteLine("Vehiculo " + (cont + 1));

      escribir.WriteLine("Placa: " + vehiculos[cont].placa);

      escribir.WriteLine("Color: " + vehiculos[cont].color);

      escribir.WriteLine("Año: " + vehiculos[cont].fecha);

      escribir.WriteLine("Marca: " + vehiculos[cont].marca);
      
      escribir.WriteLine("Modelo: " + vehiculos[cont].modelo);

      escribir.WriteLine("Propietario: " + vehiculos[cont].propietario);
      
      escribir.WriteLine();
    }
    escribir.Close();
    Process.Start("vehiculos.txt");
  }
}

