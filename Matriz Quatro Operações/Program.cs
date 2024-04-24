//Construa 2 matrizes e mostre os resultados, com as 4 operações;
int qnt_linhas = 3, qnt_colunas = 3;

int[,] matriz_1 = new int[qnt_linhas, qnt_colunas];
int[,] matriz_2 = new int[qnt_linhas, qnt_colunas];
int[,] matriz_soma = new int[qnt_linhas, qnt_colunas];
int[,] matriz_subtracao = new int[qnt_linhas, qnt_colunas];
int[,] matriz_multiplicacao = new int[qnt_linhas, qnt_colunas];
int[,] matriz_divisao = new int[qnt_linhas, qnt_colunas];

//Primeira Matriz
//Geração
Console.WriteLine("Primeira Matriz:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_1[linha, coluna] = new Random().Next(0, 10);
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_1[linha, coluna] + " ");
    }
}

//Segunda Matriz
//Geração
Console.WriteLine("\n\nSegunda Matriz:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_2[linha, coluna] = new Random().Next(0, 100);
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_2[linha,coluna] + " ");
    }
}

//Matriz de Soma
//Geração
Console.WriteLine("\n\nMatriz de Soma:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_soma[linha, coluna] = matriz_1[linha, coluna] + matriz_2[linha, coluna];
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_soma[linha, coluna] + " ");
    }
}

//Matriz de Subtração
//Geração
Console.WriteLine("\n\nMatriz de Subtração:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_subtracao[linha, coluna] = matriz_1[linha, coluna] - matriz_2[linha, coluna];
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_subtracao[linha, coluna] + " ");
    }
}

//Matriz de Multiplicação
//Geração
Console.WriteLine("\n\nMatriz de Multiplicação:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_multiplicacao[linha, coluna] = matriz_1[linha, coluna] * matriz_2[linha, coluna];
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_multiplicacao[linha, coluna] + " ");
    }
}

//Matriz de Divisão
//Geração
Console.WriteLine("\n\nMatriz de Divisão:");
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_divisao[linha, coluna] = matriz_1[linha, coluna] / matriz_2[linha, coluna];
    }
}

//Impressão
for (int linha = 0; linha < qnt_linhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        Console.Write(matriz_divisao[linha, coluna] + " ");
    }
}

Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();