namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Aplicação de Boas Práticas: Validação básica
            if (!string.IsNullOrWhiteSpace(placa))
            {
                // Padronizamos a placa para letras maiúsculas para facilitar a busca depois
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com a placa {placa.ToUpper()} estacionado com sucesso!");
            }
            else
            {
                Console.WriteLine("A placa não pode ser vazia. Tente novamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            // O método .Any() retorna true se a lista tiver pelo menos um item
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Laço de repetição para percorrer a lista
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Capturamos a entrada e já garantimos que fique em maiúscula para a busca
            string placa = Console.ReadLine()?.ToUpper();

            // O método .Any() percorre a lista procurando se a placa digitada existe lá dentro
            if (veiculos.Any(x => x.ToUpper() == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Convert.ToInt32 converte o texto digitado (string) para um número inteiro (int)
                int horas = Convert.ToInt32(Console.ReadLine());

                // Cálculo da cobrança
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Removemos o veículo da lista
                veiculos.Remove(placa);

                // Exibimos o resultado usando interpolação de strings
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

    }
}