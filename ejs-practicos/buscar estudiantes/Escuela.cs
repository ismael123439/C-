// using System;
// using System.Collections.Generic;
// using System.Text;
// using schol;

// namespace Curso_de_net_core
// {
//     public class School
//     {
//         private List<Estudiante> students;
//         public School()
//         {
//             students = new List<Estudiante>();
//         }
//         public void addStudent(Estudiante nuevoEstudiante)
//         {
//             students.Add(nuevoEstudiante);
//         }
//         public bool buscarPorNombre(String name)
//         {
//             bool encontrado = false;
//             int i = 0;
//             while (encontrado == false && i < students.Count)
//             {
//                 if (students[i].Nombre.Equals(name))
//                 {
//                     encontrado = true;
//                 }
//                 else
//                 {
//                     i++;
//                 }
//             }
//             if (encontrado)
//             {
//                 Console.WriteLine("Name: " + students[i].Nombre + "\n"
//              + "Age: " + students[i].edad + "\n"
//              + "Qualification: " + students[i].notas);
//                 return false;
//             }
//             else
//             {
//                 Console.WriteLine("No existe el nombre, intente nuevamente...!");
//                 return true;
//             }
//         }
//     }
// }
