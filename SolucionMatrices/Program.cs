int[,] lista=new int[3,3];
lista[0,0] = 4;
lista[0,1] = 2;
lista[0,2] = 3;

lista[1, 0] = 1;
lista[1, 1] = 3;
lista[1, 2] = 4;

lista[2, 0] = 2;
lista[2, 1] = 1;
lista[2, 2] = 2;

Matrices matriz = new Matrices();
int det= matriz.Sarrus3x3(lista);
matriz.MostrarMatriz(lista);
Console.WriteLine(det);
class Matrices()
{
    public void MostrarMatriz(int[,] matriz)
    {
        for(int fila = 0; fila < matriz.GetLength(0); fila++)
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
        int[] lista1 = [matriz[0,0], matriz[1,1], matriz[2,2]];
        int[] lista2 = [matriz[1,0], matriz[2,1], matriz[0,2]];
        int[] lista3 = [matriz[2,0], matriz[0,1], matriz[1,2]];

        int result1=Multiplicar(lista1);
        int result2=Multiplicar(lista2);
        int result3=Multiplicar(lista3);

        int suma1 = result1 + result2 + result3;

        int[] lista4 = [matriz[0,2 ], matriz[1, 1], matriz[2, 0]];
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
        for(int i = 1; i < lista.Length; i++)
        {
            resultado = resultado * lista[i];
        }
        return resultado;
    }
}
