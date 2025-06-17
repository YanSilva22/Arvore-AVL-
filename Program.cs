class Program
{
    static void Main(string[] args)
    {
        // Verifica se o caminho do arquivo foi passado como argumento
        if (args.Length == 0)
        {
            Console.WriteLine("Uso: programa.exe <caminho_arquivo_comandos.txt>");
            return;
        }

        string caminhoArquivo = args[0];
        ArquivoAVL executor = new ArquivoAVL();
        executor.ExecutarComandos(caminhoArquivo);
    }
}
