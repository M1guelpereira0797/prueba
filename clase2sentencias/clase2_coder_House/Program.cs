// See https://aka.ms/new-console-template for more information
int cantidadvendidos;
int cantidaddeposito= 1000;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
cantidadvendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadvendidos - cantidaddeposito;

Console.WriteLine("Producto sobrante en stock " + stock);

if (stock == 0) 
{

    Console.WriteLine("Reponer stock de dicho producto");
   // cantidaddeposito += 10;
    Console.WriteLine("Porductos cargados al almacen");
    
}
