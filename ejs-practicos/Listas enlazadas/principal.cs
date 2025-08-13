// using System;
// using System.Collections.Generic; // Para List y LinkedList
// using nodoss; // Para Nodo
// // No hace falta importar ListaNodo si está en el mismo namespace o carpeta

// namespace Curso_de_net_core
// {
//     class Program
//     {
//         static void Main()
//         {
//             // Ejemplo usando List<Object>
//             List<object> lista = new List<object>();
//             lista.Add("Hola");
//             lista.Add(123);
//             lista.Add(45.6);

//             Console.WriteLine("Contenido de List<object>:");
//             foreach (var item in lista)
//             {
//                 Console.WriteLine(item);
//             }

//             // Ejemplo usando LinkedList<string>
//             LinkedList<string> nodos = new LinkedList<string>();
//             nodos.AddLast("Nodo 1");
//             nodos.AddLast("Nodo 2");
//             nodos.AddLast("Nodo 3");

//             Console.WriteLine("\nContenido de LinkedList<string>:");
//             foreach (var nodo in nodos)
//             {
//                 Console.WriteLine(nodo);
//             }

//             // Ejemplo usando ListaNodo personalizada
//             ListaNodo miLista = new ListaNodo();
//             miLista.AddNodo(5);
//             miLista.AddNodo(2);
//             miLista.AddNodo(8);
//             miLista.AddNodo(3);

//             Console.WriteLine("\nContenido de ListaNodo:");
//             miLista.MostrarLista();
//         }
//     }
// }
