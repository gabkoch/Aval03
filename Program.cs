using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Avaliação 03");

        string textoCifrado = "Lu0s z q0tm0uƒ€q~x ƒ40t ‚uy~t (~ 0†w|q~„mPe}q(†ytq(q‚q‚i0…}0uy~…„w0y‚‚m|u†qv„uPeu0q„qy…u0tm0 † (u}0†é‚yqƒ(s ‚u{0u0„i}q~xwƒPTqvt 0ri|qƒ0m0sywi‚‚ ƒ(u0sqz ~qƒ(q0uƒ|‚q~xwƒPSqz‚ ƒ0wƒƒ 0lyŠu~l 0ƒyuP_0ƒq~q|0o‚y„qvt 0~ë PTu~u0ƒuz0yƒƒw0 …u(sxq}i}0tu(‚uƒƒ}‚uy÷ë PPSi€y„qt0Y~ykyq|PZuƒƒ…z‚uy÷ë";

        string textoDecifrado = DeTeusPulos(textoCifrado);
        textoDecifrado = textoDecifrado.Replace("@", "\n");

        string[] palindromos = { "gloriosa", "bondade", "passam" };
        for (int i = 0; i < palindromos.Length; i++)
        {
            textoDecifrado = SubstituirPalindromo(textoDecifrado, palindromos[i], new[] { "deed", "level", "civic" }[i]);
        }

        Console.WriteLine($"Conteúdo do texto cifrado:\n{textoCifrado}");

        Console.WriteLine($"\nPalíndromos encontrados: {string.Join(", ", palindromos)}");

        Console.WriteLine($"\nNúmero de caracteres do texto decifrado: {textoDecifrado.Length}");

        Console.WriteLine($"\nQuantidade de palavras no texto decifrado: {ContarPalavras(textoDecifrado)}");

        Console.WriteLine($"\nTexto decifrado:\n{textoDecifrado.ToUpper()}");
    }

    static string DeTeusPulos(string textoCifrado)
    {
        char[] caracteresCifrados = textoCifrado.ToCharArray();
        for (int i = 0; i < caracteresCifrados.Length; i++)
        {
            if (i % 2 == 0)
            {
                caracteresCifrados[i] = (char)(caracteresCifrados[i] - 8);
            }
            else
            {
                caracteresCifrados[i] = (char)(caracteresCifrados[i] - 16);
            }
        }
        return new string(caracteresCifrados);
    }

    static string SubstituirPalindromo(string texto, string palindromo, string substituicao)
    {
        texto = texto.Replace(palindromo, substituicao);
        string palindromoReverso = new string(palindromo.Reverse().ToArray());
        texto = texto.Replace(palindromoReverso, substituicao);
        return texto;
    }

    static int ContarPalavras(string texto)
    {
        string[] palavras = texto.Split(new[] { ' ', '\t', '\n', '\r', '\f' }, StringSplitOptions.RemoveEmptyEntries);

        return palavras.Length;
    }
}
//Gabriela Koch
//https://github.com/gabkoch/Aval03.git