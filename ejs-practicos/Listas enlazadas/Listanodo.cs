// using nodoss;

// public class ListaNodo
// {
//     private Nodo primero;
//     private int size;

//     public ListaNodo()
//     {
//         primero = null;
//         size = 0;
//     }

//     public void AddNodo(int dato)
//     {
//         Nodo nuevo = new Nodo(dato);

//         // Caso 1: lista vacía o insertar al inicio
//         if (primero == null || dato < primero.dato)
//         {
//             nuevo.siguiente = primero;
//             primero = nuevo;
//             size++;
//             return;
//         }

//         // Caso 2: insertar en el medio o final
//         Nodo actual = primero;
//         while (actual.siguiente != null && actual.siguiente.dato < dato)
//         {
//             actual = actual.siguiente;
//         }

//         // Insertar nodo
//         nuevo.siguiente = actual.siguiente;
//         actual.siguiente = nuevo;
//         size++;
//     }

//     public void MostrarLista()
//     {
//         Nodo actual = primero;
//         while (actual != null)
//         {
//             Console.Write(actual.dato + " -> ");
//             actual = actual.siguiente;
//         }
//         Console.WriteLine("null");
//     }
// }
