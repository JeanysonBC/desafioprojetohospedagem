// using System.Text;
// using DesafioProjetoHospedagem.Models;

// Console.OutputEncoding = Encoding.UTF8;

// // Cria os modelos de hóspedes e cadastra na lista de hóspedes
// List<Pessoa> hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa(nome: "Hóspede 1");
// Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// hospedes.Add(p1);
// hospedes.Add(p2);

// // Cria a suíte
// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// // Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 10);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// // Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

// Para ler e escrever dados em C#, utilizamos os seguintes métodos da classe Console:
// - Console.ReadLine: lê UMA linha com dado(s) de Entrada (Inputs) do usuário;
// - Console.WriteLine: imprime um texto de Saída (Output) e pulando uma linha.

using System;

public class Program 
{

  public static void Main(string[] args) 
  {
    string[] entrada;
    float participantes;
    float cachorrosQuentes;

    do{
        entrada = Console.ReadLine().Split();
        participantes = float.Parse(entrada[0]);
        cachorrosQuentes = float.Parse(entrada[1]);
    }while((participantes < 1 || participantes > 1000) || (cachorrosQuentes < 0 || cachorrosQuentes > 1000));
    
    float media = participantes / cachorrosQuentes;
    string resultado = media.ToString("F2");

    Console.WriteLine(resultado);

    //TODO: Calcular a média de cachorros-quentes consumidos pelos participantes.
    
    //TODO: Imprimir a média com duas casas decimais.
    //Dica: Pesquise sobre o método "ToString".
  }
}