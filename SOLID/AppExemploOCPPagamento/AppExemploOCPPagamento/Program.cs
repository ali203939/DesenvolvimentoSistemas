using AppExemploOCPPagamento.Model;

CalculadoraPagamento calculador = new CalculadoraPagamento();
decimal valorPagamento, valorDaCompra;

Console.WriteLine("Digite o valor da compra:");
valorDaCompra = Convert.ToDecimal(Console.ReadLine());

valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoBlackFriday());
Console.WriteLine($"O valo da compra de ${valorDaCompra} " +
    $"Resultou em R${valorPagamento} depois de aplicado o desconto BF.");

valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoCupom());
Console.WriteLine($"O valo da compra de ${valorDaCompra} " +
    $"Resultou em R${valorPagamento} depois de aplicado o desconto de cupom.");


valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoSemanaConsumidor());
Console.WriteLine($"O valo da compra de ${valorDaCompra} " +
    $"Resultou em R${valorPagamento} depois de aplicado o desconto da semana do consumidor.");