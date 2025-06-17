using System;

class No
{
    private int Valor;
    private No? Esquerda;
    private No? Direita;
    private int Altura;

    public No(int valor)
    {
        Valor = valor;
        Altura = 1; // Altura inicial (folha)
    }

    // Getters e Setters
    public int GetValor() => Valor;
    public void SetValor(int valor) => Valor = valor;

    public No? GetEsquerda() => Esquerda;
    public void SetEsquerda(No? esquerda) => Esquerda = esquerda;

    public No? GetDireita() => Direita;
    public void SetDireita(No? direita) => Direita = direita;

    public int GetAltura() => Altura;
    public void SetAltura(int altura) => Altura = altura;
}
