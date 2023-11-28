using System;

class Program
{
    static void Main()
    {
        string textoCifrado = File.ReadAllText("provinhaBarbadinha.txt");
        string textoDecifrado = decifrar(textoCifrado);
        textoDecifrado = textoDecifrado.Replace("@", "\n");

        Console.WriteLine("Conteúdo do texto cifrado: \n" + textoCifrado);

        string[] palindromos = palindromo(textoDecifrado);

        Console.WriteLine("\nPalíndromos encontrados: ");
        foreach (var p in palindromos)
        {
            if (p.Length > 2)
                Console.WriteLine(p);
        }

        int numeroCaracteresCifrado = textoCifrado.Length;
        Console.WriteLine("\nNúmero de caracteres do texto cifrado: " + numeroCaracteresCifrado);

        int numeroPalavrasDecifrado = textoDecifrado.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("\nQuantidade de palavras no texto decifrado: " + numeroPalavrasDecifrado);

        Console.WriteLine("\nTexto decifrado em maiúsculas: \n" + textoDecifrado.ToUpper());
    }

    static string decifrar(string textoCifrado)
    {
        char[] caracteresCifrados = textoCifrado.ToCharArray();
        for (int i = 0; i < caracteresCifrados.Length; i++)
        {
            int chave = (i % 5 == 0) ? 8 : 16;
            caracteresCifrados[i] = (char)(caracteresCifrados[i] - chave);
        }
        return new string(caracteresCifrados);
    }

    static string[] palindromo(string texto)
    {
        return texto.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(palavra =>
            {
                char[] caracteres = palavra.ToCharArray();
                Array.Reverse(caracteres);
                return palavra.Equals(new string(caracteres), StringComparison.OrdinalIgnoreCase);
            })
            .ToArray();
    }
}

//Gabriela Koch
//https://github.com/gabkoch/Aval03.git
