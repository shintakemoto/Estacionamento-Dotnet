namespace DesafioFundamentos.Models
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
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            //verifica duplicidade de veiculo
             if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
             {
                Console.WriteLine("Placa já registrada");
             }
             else 
             {
                veiculos.Add(placa);
                Console.WriteLine($"O estacionamento está com {veiculos.Count} carro(s)");
             }
            
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 

                horas = Int32.Parse(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
            Console.WriteLine($"O estacionamento está com {veiculos.Count} carro(s)");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine($"O estacionamento está com {veiculos.Count} carro(s)");
                Console.WriteLine("Os veículos estacionados são:");
                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"Placa: {veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
