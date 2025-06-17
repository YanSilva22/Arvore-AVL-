using System;
using System.IO;

class ArquivoAVL
{
    private Avl arvore;

    public ArquivoAVL()
    {
        arvore = new Avl();
    }

    public void ExecutarComandos(string caminhoArquivo)
    {
        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine($"Arquivo não encontrado: {caminhoArquivo}");
            return;
        }

        string[] linhas = File.ReadAllLines(caminhoArquivo);

        foreach (var linha in linhas)
        {
            string comando = linha.Trim();

            if (string.IsNullOrEmpty(comando)) continue;

            // Comando pode ser "I 10", "R 20", "B 15", "P", "F", "H"
            string[] partes = comando.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string operacao = partes[0].ToUpper();

            switch (operacao)
            {
                case "I":
                    if (partes.Length == 2 && int.TryParse(partes[1], out int valorInserir))
                    {
                        arvore.Inserir(valorInserir);
                    }
                    break;

                case "R":
                    if (partes.Length == 2 && int.TryParse(partes[1], out int valorRemover))
                    {
                        arvore.Remover(valorRemover);
                    }
                    break;

                case "B":
                    if (partes.Length == 2 && int.TryParse(partes[1], out int valorBuscar))
                    {
                        bool encontrado = arvore.Buscar(valorBuscar);
                        Console.WriteLine(encontrado ? "Valor encontrado" : "Valor não encontrado");
                    }
                    break;

                case "P":
                    arvore.ImprimirPreOrdem();
                    break;

                case "F":
                    arvore.ImprimirFatores();
                    break;

                case "H":
                    arvore.ImprimirAltura();
                    break;

                default:
                    Console.WriteLine($"Comando desconhecido: {comando}");
                    break;
            }
        }
    }
}

