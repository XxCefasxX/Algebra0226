using SolucionMatrices;

int[,] matriz = new int[4, 4];
int FilaSeleccionada = 0;
Matrices matrices = new Matrices();

//for (int fila = 0; fila < matriz.GetLength(0); fila++)
//{
//    for (int columna = 0; columna < matriz.GetLength(1); columna++)
//    {
//        Console.WriteLine($"Ingrese el numero de {fila+1},{columna+1}");
//        matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
//        Console.Clear();
//    }
//}

//llamando clase de prueba
Test t = new Test();
t.otrometodo();

matriz = matrices.Demo();
matrices.MostrarMatriz(matriz);
Console.WriteLine($"Seleccione una file entre 1 - {matriz.GetLength(0)}");
FilaSeleccionada = Convert.ToInt32(Console.ReadLine());
int det = matrices.Laplace(matriz, FilaSeleccionada - 1);
Console.WriteLine($"Ls determinante es {det}");
//int det= matrices.Sarrus3x3(matriz);
//matrices.MostrarMatriz(matriz);
//Console.WriteLine($"La determinant de la matriz es: {det}");
class Matrices()
{
    public int[,] Demo()
    {
        int[,] matriz = new int[4, 4];
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 6;
        matriz[0, 3] = 28;

        matriz[1, 0] = 4;
        matriz[1, 1] = 5;
        matriz[1, 2] = 3;
        matriz[1, 3] = 30;

        matriz[2, 0] = 3;
        matriz[2, 1] = 1;
        matriz[2, 2] = 4;
        matriz[2, 3] = 33;

        matriz[3, 0] = 5;
        matriz[3, 1] = 4;
        matriz[3, 2] = 2;
        matriz[3, 3] = 35;
        return matriz;
    }
    public void MostrarMatriz(int[,] matriz)
    {
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            string f = "";
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                f = $"{f} {matriz[fila, columna]}";
            }
            Console.WriteLine(f);
        }
    }
    public int Sarrus3x3(int[,] matriz)
    {
        int[] lista1 = [matriz[0, 0], matriz[1, 1], matriz[2, 2]];
        int[] lista2 = [matriz[1, 0], matriz[2, 1], matriz[0, 2]];
        int[] lista3 = [matriz[2, 0], matriz[0, 1], matriz[1, 2]];

        int result1 = Multiplicar(lista1);
        int result2 = Multiplicar(lista2);
        int result3 = Multiplicar(lista3);

        int suma1 = result1 + result2 + result3;

        int[] lista4 = [matriz[0, 2], matriz[1, 1], matriz[2, 0]];
        int[] lista5 = [matriz[1, 2], matriz[2, 1], matriz[0, 0]];
        int[] lista6 = [matriz[2, 2], matriz[0, 1], matriz[1, 0]];

        int result4 = Multiplicar(lista4);
        int result5 = Multiplicar(lista5);
        int result6 = Multiplicar(lista6);

        int suma2 = result4 + result5 + result6;

        int determinante = suma1 - suma2;
        return determinante;
    }
    public int Multiplicar(int[] lista)
    {
        int resultado = lista[0];
        for (int i = 1; i < lista.Length; i++)
        {
            resultado = resultado * lista[i];
        }
        return resultado;
    }

    private int[,] obtenrSubMatriz(int[,] matriz, int fila, int columna)
    {
        int[,] submatriz = new int[matriz.GetLength(0) - 1, matriz.GetLength(0) - 1];

        int nF = 0;
        int nC = 0;

        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            if (f == fila)
                continue;
            nC = 0;

            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                if (c == columna)
                    continue;
                submatriz[nF, nC] = matriz[f, c];
                nC++;
            }
            nF++;
        }
        return submatriz;
    }

    public int Laplace(int[,] matriz, int FilaSeleccionada)
    {
        int resultado = 0;
        for (int columna = 0; columna < matriz.GetLength(1); columna++)
        {
            int numero = matriz[FilaSeleccionada, columna];
            int[,] submatriz = new int[matriz.Length - 1, matriz.Length - 1];

            submatriz = obtenrSubMatriz(matriz, FilaSeleccionada, columna);

            int menorComplementario = 0;
            if (submatriz.Length > 3)
            {
                menorComplementario = Laplace(submatriz, 2);
            }
            else
            {
                menorComplementario = Sarrus3x3(submatriz);
            }

            int aux = (FilaSeleccionada + 1) + (columna + 1);
            int signo = 0;
            if (aux % 2 == 0)
            {
                signo = 1;
            }
            else
            {
                signo = -1;
            }
            int adjunto = menorComplementario * signo;

            resultado += numero * adjunto;

            //Console.Write(numero + " ");
        }
        return resultado;
    }
}
