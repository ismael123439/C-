// using System;
// using System.Text;
// using schol;

// namespace Curso_de_net_core
// {
//     class Program
//     {
//         static void Main()
//         {
//             var s1 = new Estudiante() {
//                 Nombre = "Alex",
//                 edad = 33,
//                 notas = 50.6
//             };
//             var s2 = new Estudiante()
//             {
//                 Nombre = "Joel",
//                 edad = 38,
//                 notas = 80.6
//             };
//             var s3 = new Estudiante()
//             {
//                 Nombre = "PDHN",
//                 edad = 23,
//                 notas = 60.6
//             };
//             var school = new School();
//             school.addStudent(s1);
//             school.addStudent(s2);
//             school.addStudent(s3);
//             bool valor = false;
//             do
//             {
//                 Console.WriteLine("Ingrese el nombre");
//                 String name = Console.ReadLine();
//                 valor = school.buscarPorNombre(name);

//             } while (valor);
//             Console.ReadKey();
//         }
//     }
// }
