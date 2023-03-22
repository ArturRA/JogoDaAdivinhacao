namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nivelDificuldade = 1, totalDeTentativas = 0;
            double totalDePontos = 1000;

            #region Validar entrada
            while (true)
            {
                Console.Write("Escolha o nivel de dificuldade.\n"
                            + "(1) Fácil.\n"
                            + "(2) Médio.\n"
                            + "(3) Difícil.\n");
                nivelDificuldade = Convert.ToInt32(Console.ReadLine());

                if (1 <= nivelDificuldade && nivelDificuldade  <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor digite uma dificuldade valida.");
                    Console.WriteLine("Digite qualquer tecla para tentar novamente....");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

            }
            #endregion

            switch (nivelDificuldade)
            {
                case 1:
                    totalDeTentativas = 15;
                    break;
                case 2:
                    totalDeTentativas = 10;
                    break;
                case 3:
                    totalDeTentativas = 5;
                    break;
            }

            // Gerando o número aleatório
            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);
            int quantidadeChutes = 1;

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Tentativa {quantidadeChutes} de {totalDeTentativas}");

                #region Input do usuario
                Console.WriteLine("Qual o seu chute? ");
                int numeroChute = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region Processamento
                if ( numeroChute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine($"Você fez {totalDePontos} pontos!");
                    break;
                }
                else if ( numeroChute < numeroSecreto)
                    Console.WriteLine("Seu chute foi menor que o número secreto");
                else
                    Console.WriteLine("Seu chute foi maior que o número secreto");

                totalDePontos -= Math.Abs((numeroChute - numeroSecreto) / 2);

                if (quantidadeChutes <= totalDeTentativas)
                {
                    Console.WriteLine("Que azar! Tente novamente!");
                }
                #endregion
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}