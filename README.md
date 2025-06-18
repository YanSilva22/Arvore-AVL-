# Árvore AVL - C#

## Informações Gerais 
Este projeto foi desenvolvido pelos parametros dados na diciplina de Análise de Projetos Orientados a Objetos I. Nesse sentido,
o projeto feito foi uma Árvore Binária de Busca Autobalanceada (Árvore AVL) com os conceitos de Orientação a Objetos na linguagem C#.

## Estrutura do Projeto

### UML

<img src="./documents/Classe UML.png" alt="UML" width="1000"/>

### Arquivos 
A solução deste trabalho está dividida em 4 arquivos:

- *`Program.cs`*: Programa principal onde será rodado o código, lendo o arquivo inicial se fornecido, se não, usa como padrão *`comandos.txt`*.
- *`No.cs`*: Classe de definição de Nós (folhas) da Árvore AVL, com seu Valor(int), elemento a Esquerda(No), elemento a Direita(No) e Altura(int) em que se encontra, com seus respectivos Getters e Setters.
- *`ArquivoAVL.cs`*: Classe responsável pela leitura de arquivos *`.txt`* especifícados na execução pelo método *`ExecutarComandos()`*;
- *`ArvoreAVL.cs`*: Classe de definição e funcionamento geral da Árvore AVL, incluindo os métodos de acesso público:
    - *`Inserir()`*;
    - *`Remover()`*;
    - *`Buscar()`*;
    - *`ImprimirPreOrdem()`*;
    - *`ImprimirFatores()`*;
    - *`ImprimirAltura()`*.

## Execução
Para execultar este projeto siga as intruções abaixo:

1. Mova para o diretório de sua preferencia:
    ```bash
    mkdir seu_diretorio     #caso não tenha criado
    cd caminho/para/seu_diretorio
    ```

2. Clone o repositorio no seu diretótio:
    ```bash
    git init    #caso não tenha iniciado
    git clone https://github.com/YanSilva22/Arvore-AVL-.git
    ```

3. Mover para a pasta *`Arvore-AVL-`*, caso não esteja nela, e executar o programa com *`dotnet run`*. SDK.NET 8.0 ou superior:
    ```bash
    cd Arvore-AVL-    #caso não esteja nessa pasta quando clonado
    dotnet run
    ```

4. (Opcional) Se desejado, forneça o caminho do arquivo *`.txt`* no final do comando de execução para testar outro arquivo, contanto que esse arquivo siga os padrões definidos em [Padrão de Arquivo](#padrão-de-arquivo).
    ```bash
    dotnet run caminho/do/seu/test.txt
    ```

## Padrão de Arquivo
Caso o usuario deseje, este programa consegue executar arquivos *`.txt`*'s externos, porém, eles terão que seguit os padrões de inscrita como os fornecidos no exemplo:
```bash
I 10
I 20
I 30
P
I 15
P
R 20
P
B 15
B 25
F
H
```

**Onde:**
- I: Inserção de um No com seu valor(int);
- R: Remoção do No através do seu valor(int)
- B: Busca de um valor;
- P: Impressão da árvore em pre-ordem;
- F: Impressão do fator de balanceamento;
- H: Impressão da altura da árvore.

## Autores 

- <a href="https://github.com/AlexandreComp456890">Alexandre Rocha Fonte</a>
- <a href="https://github.com/jhenifersgomes209">Jhenifer Patricia Gomes da Silva</a>
- <a href="https://github.com/YanSilva22">Yan Vinicius Silva</a>  

