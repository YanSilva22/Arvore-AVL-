class Program
{
    static void Main(string[] args)
    {
        // Verifica se o caminho do arquivo foi passado como argumento
        string caminhoArquivo = null;

        if (args.Length == 0)
        {
            Console.WriteLine("Arquivo não selecionado, usando o arquivo padrão 'comandos.txt'.");
            caminhoArquivo = "comandos.txt";
        }
        else
        {
            caminhoArquivo = args[0];
        }

        ArquivoAVL executor = new ArquivoAVL();
        executor.ExecutarComandos(caminhoArquivo);
    }
}
