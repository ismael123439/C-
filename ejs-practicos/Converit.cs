//  int opcion, repetir = 0;
//         var con = new Conversor();

//         do
//         {
//             Console.WriteLine("escoja una de las opciones");
//             Console.WriteLine("1- m/s ----> km/h");
//             Console.WriteLine("2- km/h ----> m/s");
//             opcion = Convert.ToInt32(Console.ReadLine());
//             switch (opcion)
//             {
//                 case 1:
//                     con.conversor1();
//                     break;
//                 case 2:
//                     con.conversor2();
//                     break;
//                 case 3:
//                     Console.WriteLine("opcion invalida");
//                     break;
//             }
//             Console.WriteLine("seleccione 1 para seguir convirtiendo, de lo contrario 2 para salir");
//             repetir = Convert.ToInt32(Console.ReadLine());
//         } while (repetir == 1);
        
//     }

//     class Conversor() //subclase
//     {
//         private double velocidad;

//         public void conversor1()
//         {
//             Console.WriteLine("Introdusca una velocidad en m/s");
//             velocidad = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine($"{ velocidad} m/s es igual a {velocidad * 3600 / 1000} km/h");
//         }
//         public  void conversor2()
//         {
//             Console.WriteLine("Introdusca una velocidad en km/h");
//             velocidad = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine($"{ velocidad} km/h es igual a {velocidad * 1000 / 3600} m/s");
//         }