namespace TestePratico.Data;

public class XptoService
{
    public static int[] Processar()
    {
        var array1 = new[] { 5, 3, 1, 4, 2 };
        var array2 = new[] { 6, 8, 7, 9, 10 };

        var resultado = new int[array1.Length + array2.Length - 1];
        
        Array.Copy(array1, resultado, array1.Length);
        Array.Copy(array2, 0, resultado, array1.Length, array2.Length);

        for (var i = 0; i < resultado.Length - 1; i++)
        {
            for (var j = 0; j < resultado.Length - i - 1; j++)
            {
                if (resultado[j] > resultado[j + 1])
                {
                    var temp = resultado[j];
                    resultado[j] = resultado[j + 1];
                    resultado[j + 1] = temp;
                }
            }
        }

        return resultado;
    }
}