using System;

namespace Variaveis
{
    class Program
    {
        enum Notas
        {
            Minimo = 10, 
            Media = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;

        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            //Console.WriteLine("Hello World!");

            ////integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 A 9.223.372.036.854.775.807

            //// integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; //16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Números Reais
            //float real1 = 100.75f; // 32 bits, intervalo de 1,5 x 10-45 a 3,4 x 1038, precisao de 7 digitos => sufixo f, ex.: 10.5f
            //double real2 = 12500.45; // 64 bits, intervalo de 5.0 x 10-34 a 1,7 x 10308, precisao de 15 digitos => sufixo d (opcional). ex.: 10.5d
            //decimal real3 = 752538.457m; // 128 bits, intervalo de pelo menos -7,9 x 10-28 a 7,9 x 1028, com precisao de pelo menos 28 digitos => sufixo m, ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caracteres
            //char letra = '\u0041';
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (cadeia de caracteres)
            //string texto = @"fatima oliveira\n 1997 s2";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implicito Var
            //var valor = 100;  // aceita qualquer tipo de valor. A partir do momento que recebe um valor vai ate o final, nao se consegue mais mudar o valor
            //valor = 20;
            //valor = "fatima"; //se for numero aceita, mas em formato string nao, a nao ser que ela ja tenha começado em string
            //*var valor = "fatima";
            //*valor = "maria";
            #endregion

            #region Tipo Object (Base para todos)
            //object obj = false;
            //obj = 200; // sao utilizadas para armazenar objetos derivados de classes
            //obj = "fatima";
            #endregion

            #region Constantes
            //const double pi = 3.1415; // constantes nao podem ser alteradas ao longo da execucao do programa
            //const string nome = "fatima";
            #endregion

            #region Enumeraçao
            //Notas notasAlunos = Notas.Media;
            #endregion

            #region Struct
            Pessoa p1 = new Pessoa(); // para inicializar uma estrutura faz desse jeito
            p1.altura = 1.48;
            p1.idade = 25;
            p1.nome = "fatima";

            Pessoa p2 = new Pessoa()
            {
                nome = "fatima",
                idade = 25,
                altura = 1.48

            };

            p1.nome = "login";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);
            #endregion

            Console.ReadKey();

        }
    }
}
