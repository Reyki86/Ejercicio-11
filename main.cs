using System;
using System.Collections.Generic;
using System.Linq;


class MainClass {

  static bool repeat=true;
  static int monto=0;
  static int op=0;
  static List<string> productosComprados = new List<string>();

  static Producto producto1 = new Producto("Coca Cola",25,15);
  static Producto producto2 = new Producto("Milky Way",30,16);
  static Producto producto3 = new Producto("Papita Lays",15,20);
  static Producto producto4 = new Producto("Doritos",30,14);
  static Producto producto5 = new Producto("M&M'S",45,15);
  static Producto producto6 = new Producto("Cola Real Rojo",25,17);
  static Producto producto7 = new Producto("Pepsi",25,14);
  static Producto producto8 = new Producto("Chocolate Rocky",15,18);
  static Producto nuevoProducto = new Producto();

  public static void Main (string[] args) {
  
    CargarMonto();

    ComprarProductos();

    MostrarProductosComprados();

  }

  public class Producto{

    public string nombre;
    public int precio;
    public int existencia;

    public Producto(string nombre, int precio, int existencia){
      this.nombre=nombre;
      this.precio=precio;
      this.existencia=existencia;
    }

    public Producto(){}
  }

  static void ComprarProductos(){

    repeat=true;

    while (repeat){
      
      Console.WriteLine("Monto Actual: "+monto);
      op=0;

      Console.WriteLine("1."+producto1.nombre + "  Precio: "+ producto1.precio + "$");
      Console.WriteLine("2."+producto2.nombre + "  Precio: "+ producto2.precio + "$");
      Console.WriteLine("3."+producto3.nombre + "  Precio: "+ producto3.precio + "$");
      Console.WriteLine("4."+producto4.nombre + "  Precio: "+ producto4.precio + "$");
      Console.WriteLine("5."+producto5.nombre + "  Precio: "+ producto5.precio + "$");
      Console.WriteLine("6."+producto6.nombre + "  Precio: "+ producto6.precio + "$");
      Console.WriteLine("7."+producto7.nombre + "  Precio: "+ producto7.precio + "$");
      Console.WriteLine("8."+producto8.nombre + "  Precio: "+ producto8.precio + "$");
      Console.WriteLine("9.Salir");
      op=Int32.Parse(Console.ReadLine());

      switch(op){
        case(1):
          nuevoProducto=producto1;
          break;
        case(2):
          nuevoProducto=producto2;
          break;
        case(3):
          nuevoProducto=producto3;
          break;
        case(4):
          nuevoProducto=producto4;
          break;
        case(5):
          nuevoProducto=producto5;
          break;
        case(6):
          nuevoProducto=producto6;
          break;
        case(7):
          nuevoProducto=producto7;
          break;
        case(8):
          nuevoProducto=producto8;
          break;
        case(9):
          repeat=false;
          break;

      }
      if(monto-nuevoProducto.precio<0){
        Console.WriteLine("Monto insuficiente");
        continue;
      }
      monto-=nuevoProducto.precio;
      nuevoProducto.existencia-=1;
      productosComprados.Add(nuevoProducto.nombre);      
      
    }  

  }

  static void MostrarProductosComprados(){

    Console.WriteLine("Productos comprados: ");
    for(int i=0;i<productosComprados.Count;i++)

    Console.WriteLine(productosComprados[i]);
    Console.WriteLine();

    Console.WriteLine("Productos restantes:");
    Console.WriteLine(producto1.nombre + ": " + producto1.existencia + "\n" + producto2.nombre + ": " + producto2.existencia + "\n" + producto3.nombre + ": " + producto3.existencia + "\n" + producto4.nombre + ": " + producto4.existencia + "\n" + producto5.nombre + ": " + producto5.existencia + "\n" + producto6.nombre + ": " + producto6.existencia + "\n" + producto7.nombre + ": " + producto7.existencia + "\n" + producto8.nombre + ": " + producto8.existencia);

  }

  static void CargarMonto(){

     while(repeat){
      
      Console.WriteLine("Monto Actual: " + monto + "\nIntroducir monto:\n1.5$\n2.10$\n3.25$\n4.50$\n5.100$\n6.200$\n7.Continuar");

      op=Int32.Parse(Console.ReadLine());
      switch(op){
        case(1):
          monto+=5;
          break;
        case(2):        
          monto+=10;
          break;  
        case(3):          
          monto+=25;
          break;
        case(4):
          monto+=50;
          break;
        case(5):
          monto+=100;
          break;
        case(6):        
          monto+=200;
          break;  
        case(7):
          repeat=false;
          break;      

        }
      }
  }


}
