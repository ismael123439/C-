//-----------------------------------------SECCION 2 VARIABLES---------------------------------------------------------------
// See https://aka.ms/new-console-template for more information
// int year = Convert.ToInt16("39");
// double doble = 2.61; //menor almacenammiento entre (15-16) 64 bits
// string nombre = "Jose";
// String nombres = "Jorge Martin";
// decimal decimals = 1.90m; //se usa para cantidades exactas y naturales como distancias almacena mas datos (28-29) 128 bits
// float flotante = 9.0F; // 7 digitos  32 bits
// bool FValor = false;
//bool VValor = true;
// char letra = 'A';
// Decimal dec = 0.09M;

// Console.WriteLine( nombres + " {0} {1} {2} ",letra,dec,FValor);
// Console.ReadLine();
// Console.WriteLine("Adios");

//------------------------------------------SECCION 3 OPERADORES-----------------------------------------------------------

// int num1 = 2;
// int num2 = 4;
// var suma = num1 + num2; // +,-,/,*,%

//val1 %= val2; //residuo de la divicion

// Console.WriteLine("{0}", suma);

// int val1 = 2;
// int val2 = 5;
// var data = val1 != val2; // se fija si son distintos y == verifica si son iguales
// Console.WriteLine("resultado = {0}", data);

//-----------------------------------------------SECCION 4 ESTRUCTURAS CONCICIONALES----------------------------------------- 
//  var data = val1 != val2; // se fija si son distintos y == verifica si son iguales


// if (data)
// {
//     if (val3 == val4)
//     {
//         Console.WriteLine("resultado: {0}", "la respuesta es true");
//     }
//     else
//     {
//         Console.WriteLine("resultado: {0}", "la respuesta es false");
//     }
// }
// else
// {
//     Console.WriteLine("resultado: {0}", "no funca ninguna condicion");
// }

// int val1 = 4;
// int val2 = 4;
// // double val3 = 9;
// // double val4 = 3;
// string name;
// var data = val1 != val2; // se fija si son distintos y == verifica si son iguales

// // if (data)
// // {
// //     name = "Borre";
// // }
// // else
// // {
// //     name = "Scocco";
// // }

// name = data ? "Borre" : "Scocco";

// Console.WriteLine("resultado: {0}",name);

//-------------------------------------------------SECCION 5 TIPOS DE ARRAYS O ARREGLOS-----------------------------------------

// string[] cadena = new string[5];//forma 1 de hacer un string
// cadena[0] = "Armani";
// cadena[1] = "Acuna";
// cadena[2] = "Dias";
// cadena[3] = "Martinez Quarta";
// cadena[4] = "Montiel";
// string[] name = { "Perez", "Aliendro", "Castano", "Lencina", };//forma 2 de hacer un string

// int[] edad = new int[5];
// edad[0] = 0;
// edad[1] = 1;
// edad[2] = 2;
// edad[3] = 3;
// edad[4] = 4;

// int[] dolar = { 1000, 1100, 2000, };

// double[,] bidimencionarray = new double[2, 2] { { 10.9, 3.7 }, { 20, 6.4 } };

// double[,,] tridimencionarray = new double[2,2,3] {{ {3,4,5},{4,6,9} }, { { 1,3, 5 }, { 2,7, 4 } } };

// Console.WriteLine("{0}", bidimencionarray[1,1]);

//----------------------------------------------------SECCION 6 FOR Y FOREACH-------------------------------------------------

// string[] name = { "Enzo", "Julian", "Lio" };
// int[] age = { 25, 26, 38 };
// // for (int i = 0; i < name.Length; i++)
// // {
// //     Console.WriteLine(name[i] + " age " + age[i]);
// // }

// foreach (var i in age)
// {
//     Console.WriteLine(i);
// }
//------------------------------------------------------------SECCION 8 ESTRUCTURA SWICH----------------------------
// var data = 5;
// var name = "Juan";
// switch (name)
// {
//     case "Juan":
//         Console.WriteLine("Julian {0}", name);
//         break;
//     case "Jorge":
//         Console.WriteLine("Julian {0}", data);
//         break;
//     case "Martin":
//         Console.WriteLine("Enzo {0}", data);
//         break;
//     default:
//         Console.WriteLine("Franco {0}", "default");
//         break;
// }

//             var (a, b, opcion) = (2, 4,"+");
// var result = opcion switch
// {
//     "+" => a == b,
//     "-" => a < b,
//     "*" => a > b
// };
// Console.Write("resultado: " + result);

//------------------------------------------------------------SECCION 9 WHILE AND DO WHILE--------------------
//             var valor = true;
// var count = 1;
// while (valor) // primero revisa la condicion y despues ejecuta el contenido
// {
//     if (count == 6)
//     {
//         break;
//     }
//     count++;
//     Console.WriteLine("Ejecucuion del while " + count);
// }
// count = 0;
// valor = true;
// Console.WriteLine(" ");
// do  //primero ejecuta, despues revisa la condicion para ver si vuelve a hacer el proceso
// {
//     if (count == 6)
//     {
//         break;
//     }
//     count++;
//     Console.WriteLine("Ejecucuion de do while " + count);
// } while (valor);
//----------------------------------------------------------SECCION 10 MANIPULACION D STRIGS------------------------------------
//     string name1 = "Enzo ";
// string name2 = "Julian";
// string name3 = name1;
// name1 += name2;
// Console.WriteLine("name: " + name1);
//             var nombre = (nombre1: "Julian", age1: 26, nombre2: "Enzo");
// Console.WriteLine($"{nombre.nombre1} age {nombre.age1} {nombre.nombre2}");

// Console.WriteLine("Nombres {0} age {1}",nombre.nombre2,nombre.age1);


// var curso = "Curso de C# desde cero";
// Console.WriteLine("Cadena {0}", curso.Substring(9, 11));
// var sub = curso.Replace("c", "C").Remove(5,12);
// Console.WriteLine("nuevo {0}", sub);


// var curso = "Curso de C# desde cero";
// var name = "martin";
// Console.WriteLine("Cadena {0}", curso.Substring(9, 11));
// var sub = curso.Replace("c", "C").Remove(5, 12);
// var data1 = curso.IndexOf('e');
// var data2 = curso.IndexOf("cero");
// var data = curso.Equals(name); //curso.ToLower().ToUpper().ToCharArray(); son otros metodos vistos,aunque no entienfdo de todo el ultimo
// foreach (var item in curso)
// {
//     Console.WriteLine(item);
// }


//---------------------------------------------------------------------SECCION 11 StringBuilder ------------------------------------------------------------------------
//     var name = new StringBuilder("nena sad remix");    <--------- no funciona el metodo en este archivo por tema de librerias
//     name[0] = 'N';
//     name.AppendLine().Append("yo se").AppendLine().Append("te queria ver");
//     // name.Capacity = 30;
//    name.AppendLine().AppendFormat(" Time {0} minutos", 2);
//     Console.WriteLine(name.ToString());
//     Console.WriteLine(name.Length);

//------------------------------------------------------------------------SECCION 13 PARAMETROD DE METODOS----------------------------------------------------
//static void Main()
//         Object[] parameters = { "Julian", 26, true };
//         //int[] cadena = { 1, 2, 3 };
//         new Program().metodo("Julian", 26, true);        // <-----------------------------------------------|
//     }                                                    //                                                 |
//                                                          //                                                 |
//     private void metodo(params object[] parameters)       //params agarra directamente los parametros de aca|
//     {
//         String nombre = (String)parameters[0];
//         int edad = (int)parameters[1];
//         bool boolean = (bool)parameters[2];
//         Console.WriteLine(nombre + " " + edad + " " + boolean);
//         for (int i = 0; i < parameters.Length; i++)
//         {
//             Console.Write(parameters[i] + " ");
//         }


//     static void Main()
//     {
//         int edad = 30;
//         new Program().metodo(edad);
//     }

//     private void metodo(in int num)    // si se pone la palabra clave "in" no se podra modificar el valor de edad/num
//     {
//         //num = 23;
//         Console.WriteLine("{0}", num);
//     }

//-----------------------------------------------------SECCION 14 FUNCIONES---------------------------------------------------------------

// static void Main()
// {
//     int data;
//     String name;

//     new Program().metodo(out data);
//     mensaje();
//     Console.WriteLine(data + " " + name);
//     void mensaje()=> name = "Enzo";
// }

// private void metodo(out int num)  //tambien se puede usar ref que es masomenos lo mismo, lo unico que no hace falta iniciar la variable
// {
//     num = function();

//     int function () => 1 + 8;
//     // int function ()
//     // {
//     //     return 50 + 80;
//     // }
// }


//--------------------------------------------------------SECCION 16 ARGUMENTOS OPCIONALES Y CON NOMBRE-----------------------------

// static void Main()
// {
//     var data = new Program();
//     data.metodo("5to", "juan",6);
// }
// private void metodo(String curso,String nombre = "Isma",int cantidad = 43)
// {
//     Console.WriteLine(cantidad + " " + nombre + " " + curso);
// }

// readonly int number = 39;// es un valor unico que se puede iniciar en metodos constructores
// const int NUMBER = 43; //valor constante, se usa cuando una variable no va a cambiar en ninguna parte del codigo

// public Program()
// {
//     number = 0;
// }
// static void Main()
// {
//     var data = new Program();
//     //data.number = 34;
//     Console.WriteLine(NUMBER);
// }
//-------------------------------------------SECCION 18 LISTAS GENERICAS----------------------------------------------------------
//List<Object> lista = new List<Object>();
//lista.Add("hola");
//lista.Add(32);
//lista.Add(false);
//lista.Add("Juan");
//lista.Insert(2, "Juan");
//lista.Clear();
//lista.Reverse();
//Console.WriteLine(lista.IndexOf(32,0,lista.Count));
//Console.WriteLine(lista.LastIndexOf("Juan"));
//Console.WriteLine(lista.Exists(e => e.Equals("hola")));
//lista.Remove(6);
// lista.ForEach(item =>
// {
// Console.WriteLine(item);
// });
// for (int i = 0; i < lista.Count; i++)
// {
//     Console.WriteLine(lista[i]);
// }
// int j = 0;
// for (; ; )
// {
//     if (j < lista.Count)
//     {
//         Console.WriteLine(j);
//         j++ ;
//     }
//     else
//     {
//         break;
//     }
// }

// foreach (var item in lista)
// {
//     Console.WriteLine(item);
// }