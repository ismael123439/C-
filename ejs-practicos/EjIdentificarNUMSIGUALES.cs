        // int[] arr = { 2, 3, 5,7,7};
        // int[] list = new int[arr.Length];

        // for (int i = 0; i < arr.Length; i++) // recorrer arr.Length
        // {
        //     int count = 0;            // definir una acum para guardar los numeros repetidos mas adelante y se reinicia cada vez q finaliza el bucle
        //     for (int j = 0; j < arr.Length; j++)
        //     {
        //         if (arr[i] == arr[j])         //compara si se repite el numero para sumar uno con el count
        //         {
        //             count++;  //crea la cantidad de veces que se erepite un numero
        //             if (numero(arr[i]))  //si el elemento que se guarda temporalmente en i se guarda de a uno en list[i]
        //             {
        //                 list[i] = arr[i];
        //             }
        //         }
        //     }
        //     if ((list[i] != 0))
        //     {
        //         Console.WriteLine(list[i] + " se repite " + count);
        //     }
            
        // }
        // bool numero(int num) // metodo local para comprobar si se repite el numero y descartarlo
        // {
        //     for (int i = 0; i < list.Length; i++) // for para recorrer list, que seria el contenedor de los valores
        //     {
        //         if (list[i] == num) //si el valor en list es igual a el dato num tira falso pq ya esta plasmado anteriormente
        //         {
        //             return false;
        //         }
        //     }
        //     return true; //si no, salta la condicion y lo imprime
        // }