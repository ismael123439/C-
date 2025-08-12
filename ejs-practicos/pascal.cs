            // // Declara una variable entera 'pisos' para guardar la cantidad de filas del triángulo.
            // int pisos = 0;

            // // Inicializa un arreglo de tamaño 1 que se usará para calcular los valores de la fila anterior del triángulo.
            // int[] arr = new int[1];

            // // Pide al usuario que ingrese el número de pisos (filas del triángulo de Pascal).
            // Console.WriteLine("Indique el numero de pisos");

            // // Convierte el valor leído por consola en número entero (tipo short, aunque lo guarda como int).
            // pisos = Convert.ToInt16(Console.ReadLine());

            // // Bucle externo para construir cada fila del triángulo, desde la 1 hasta la cantidad de pisos indicada.
            // for (int i = 1; i <= pisos; i++)
            // {
            //     // Crea un nuevo arreglo que representa la fila actual del triángulo. Su tamaño es igual al número de fila (i).
            //     int[] pascal = new int[i];

            //     // Bucle para imprimir espacios en blanco antes de los números, con el fin de centrar el triángulo.
            //     // ⚠️ ERROR: esta condición j < i está mal, el bucle nunca se ejecuta correctamente. Además, j-- hace que sea infinito.
            //     for (int j = pisos; j < i; j--)
            //     {
            //         Console.Write(" ");
            //     }

            //     // Bucle interno para calcular los valores de la fila actual.
            //     for (int k = 0; k < i; k++)
            //     {
            //         // Los extremos de cada fila en el triángulo de Pascal siempre son 1.
            //         if (k == 0 || k == (i - 1))
            //         {
            //             pascal[k] = 1;
            //         }
            //         else
            //         {
            //             // Los valores intermedios se calculan sumando dos valores de la fila anterior: arr[k] + arr[k-1]
            //             pascal[k] = arr[k] + arr[k - 1];
            //         }

            //         // Muestra por pantalla el valor calculado seguido de un espacio.
            //         Console.Write(pascal[k] + " ");
            //     }

            //     // Guarda la fila actual como la anterior para usarla en la siguiente iteración.
            //     arr = pascal;

            //     // Salta a la siguiente línea (para imprimir la siguiente fila del triángulo).
            //     Console.WriteLine("");
            // }