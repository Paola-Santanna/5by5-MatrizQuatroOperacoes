//Construa 2 matrizes e mostre os resultados, com as 4 operações;
//Criar funções no exercício de 4 operações das matrizes:
//1 - O usuário vai informar qual operação ele quer fazer
//2 - Criar a função de sorteio da matriz
//3 - Criar a função que vai informar o tamanho da criação da matriz

int qnt_linhas = 3, qnt_colunas = 3, escolhaUsuario;

float[,] matriz_1 = new float[qnt_linhas, qnt_colunas];
float[,] matriz_2 = new float[qnt_linhas, qnt_colunas];

//Funções
void GerarMatriz(float[,] matrizGerada)
{
    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizGerada[linha, coluna] = new Random().Next(0, 10);
        }
    }
}

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine("\n" + titulo);
    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
    Console.WriteLine();
}

void SomarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qnt_linhas, qnt_colunas];

    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] + m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Somada...");
}

void SubtrairMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qnt_linhas, qnt_colunas];

    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] - m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Subtraída...");
}

void MultiplicarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qnt_linhas, qnt_colunas];

    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] * m2[linha, coluna];
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Multiplicada...");
}

void DividirMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizResultante = new float[qnt_linhas, qnt_colunas];

    for (int linha = 0; linha < qnt_linhas; linha++)
    {
        for (int coluna = 0; coluna < qnt_colunas; coluna++)
        {
            matrizResultante[linha, coluna] = m1[linha, coluna] / m2[linha, coluna];

            if (matrizResultante[linha, coluna] == 0)
                Console.WriteLine("Ocorreu uma divisão por 0");
        }
    }
    ImprimirMatriz(matrizResultante, "Resultado da Matriz Somada...");
}

void OpcaoEscolhida(int opcao)
{
    switch (opcao)
    {
        case 1:
            SomarMatriz(matriz_1, matriz_2);
            break;
        case 2:
            SubtrairMatriz(matriz_1, matriz_2);
            break;
        case 3:
            MultiplicarMatriz(matriz_1, matriz_2);
            break;
        case 4:
            DividirMatriz(matriz_1, matriz_2);
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
}
void Menu()
{
    Console.WriteLine("\nMENU PRINCIPAL");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.Write("Informe a opção desejada: ");
    escolhaUsuario = int.Parse(Console.ReadLine());
    OpcaoEscolhida(escolhaUsuario);
}

//Primeira Matriz
//Geração
GerarMatriz(matriz_1);
ImprimirMatriz(matriz_1, "Primeira Matriz:");

//Segunda Matriz
//Geração
GerarMatriz(matriz_2);
ImprimirMatriz(matriz_2, "\nSegunda Matriz:");

do
{
    Menu();
    Console.ReadKey();
    Console.WriteLine();
    Console.Clear();
} while (true);
