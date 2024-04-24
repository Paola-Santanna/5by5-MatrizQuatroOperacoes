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
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_1[linha, coluna] = new Random().Next(0, 100);
    }
}

//Impressão

//Segunda Matriz
//Geração
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_2[linha, coluna] = new Random().Next(0, 100);
    }
}

//Impressão


//Matriz de Soma
//Geração
for (int linha = 0; linha < qnt_linhas; linha++)
{
    for (int coluna = 0; coluna < qnt_colunas; coluna++)
    {
        matriz_soma[linha, coluna] = matriz_1[linha, coluna] + matriz_2[linha, coluna];
    }
}

//Impressão

//Matriz de Subtração
//Geração

//Impressão

//Matriz de Multiplicação
//Geração

//Impressão

//Matriz de Divisão
//Geração

//Impressão

Console.WriteLine("\n\nPressione ENTER para encerrar...");
Console.ReadKey();