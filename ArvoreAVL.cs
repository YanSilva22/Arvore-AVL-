using System;

class Avl
{
    private No? Raiz;

    private int Altura(No? no) => no == null ? 0 : no.GetAltura();

    private int FatorBalanceamento(No? no)
    {
        if (no == null) return 0;
        return Altura(no.GetEsquerda()) - Altura(no.GetDireita());
    }

    private void AtualizarAltura(No no)
    {
        int alturaEsq = Altura(no.GetEsquerda());
        int alturaDir = Altura(no.GetDireita());
        no.SetAltura(1 + Math.Max(alturaEsq, alturaDir));
    }

    private No RotacaoDireita(No y)
    {
        No x = y.GetEsquerda()!;
        No T2 = x.GetDireita()!;

        x.SetDireita(y);
        y.SetEsquerda(T2);

        AtualizarAltura(y);
        AtualizarAltura(x);

        return x;
    }

    private No RotacaoEsquerda(No x)
    {
        No y = x.GetDireita()!;
        No T2 = y.GetEsquerda()!;

        y.SetEsquerda(x);
        x.SetDireita(T2);

        AtualizarAltura(x);
        AtualizarAltura(y);

        return y;
    }

    private No Balancear(No no)
    {
        AtualizarAltura(no);
        int fb = FatorBalanceamento(no);

        // Rotação direita simples
        if (fb > 1 && FatorBalanceamento(no.GetEsquerda()) >= 0)
            return RotacaoDireita(no);

        // Rotação esquerda-direita dupla
        if (fb > 1 && FatorBalanceamento(no.GetEsquerda()) < 0)
        {
            no.SetEsquerda(RotacaoEsquerda(no.GetEsquerda()!));
            return RotacaoDireita(no);
        }

        // Rotação esquerda simples
        if (fb < -1 && FatorBalanceamento(no.GetDireita()) <= 0)
            return RotacaoEsquerda(no);

        // Rotação direita-esquerda dupla
        if (fb < -1 && FatorBalanceamento(no.GetDireita()) > 0)
        {
            no.SetDireita(RotacaoDireita(no.GetDireita()!));
            return RotacaoEsquerda(no);
        }

        return no;
    }

    public void Inserir(int valor)
    {
        Raiz = Inserir(Raiz, valor);
    }

    private No Inserir(No? no, int valor)
    {
        if (no == null) return new No(valor);

        if (valor < no.GetValor())
            no.SetEsquerda(Inserir(no.GetEsquerda(), valor));
        else if (valor > no.GetValor())
            no.SetDireita(Inserir(no.GetDireita(), valor));
        else
            return no; // valor duplicado

        return Balancear(no);
    }

    public void Remover(int valor)
    {
        Raiz = Remover(Raiz, valor);
    }

    private No? Remover(No? no, int valor)
    {
        if (no == null) return null;

        if (valor < no.GetValor())
            no.SetEsquerda(Remover(no.GetEsquerda(), valor));
        else if (valor > no.GetValor())
            no.SetDireita(Remover(no.GetDireita(), valor));
        else
        {
            // Nó com um ou nenhum filho
            if (no.GetEsquerda() == null || no.GetDireita() == null)
            {
                No? temp = no.GetEsquerda() ?? no.GetDireita();

                if (temp == null)
                {
                    // Nenhum filho
                    return null;
                }
                else
                {
                    // Um filho
                    return temp;
                }
            }

            // Nó com dois filhos: buscar sucessor (menor da direita)
            No sucessor = GetMin(no.GetDireita()!);
            no.SetValor(sucessor.GetValor());
            no.SetDireita(Remover(no.GetDireita(), sucessor.GetValor()));
        }

        return Balancear(no);
    }

    private No GetMin(No no)
    {
        while (no.GetEsquerda() != null)
            no = no.GetEsquerda()!;
        return no;
    }

    public bool Buscar(int valor)
    {
        return Buscar(Raiz, valor);
    }

    private bool Buscar(No? no, int valor)
    {
        if (no == null) return false;
        if (valor == no.GetValor()) return true;
        if (valor < no.GetValor()) return Buscar(no.GetEsquerda(), valor);
        else return Buscar(no.GetDireita(), valor);
    }

    public void ImprimirPreOrdem()
    {
        Console.Write("Árvore em pré-ordem: ");
        PreOrdem(Raiz);
        Console.WriteLine();
    }

    private void PreOrdem(No? no)
    {
        if (no == null) return;
        Console.Write($"{no.GetValor()} ");
        PreOrdem(no.GetEsquerda());
        PreOrdem(no.GetDireita());
    }

    public void ImprimirFatores()
    {
        Console.WriteLine("Fatores de balanceamento:");
        ImprimirFB(Raiz);
    }

    private void ImprimirFB(No? no)
    {
        if (no == null) return;
        Console.WriteLine($"Nó {no.GetValor()}: Fator de balanceamento {FatorBalanceamento(no)}");
        ImprimirFB(no.GetEsquerda());
        ImprimirFB(no.GetDireita());
    }

    public void ImprimirAltura()
    {
        Console.WriteLine($"Altura da árvore: {Altura(Raiz)}");
    }
}
