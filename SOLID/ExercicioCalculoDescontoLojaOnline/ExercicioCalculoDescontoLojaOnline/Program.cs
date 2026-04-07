using ExercicioCalculoDescontoLojaOnline.Model;

decimal valorCompra, valorPagamento;
CalcularPagamento calcular = new CalcularPagamento();

Console.WriteLine("Digite o valor da compra:");
valorCompra = Convert.ToInt32(Console.ReadLine());

valorPagamento = calcular.CalcularTotal(valorCompra, new DescontoSazonal());
Console.WriteLine($"A compra de R${valorCompra} " + $"Ficou no total de R${valorPagamento} com o desconto sazonal.");

valorPagamento = calcular.CalcularTotal(valorCompra, new DescontoCupom());
Console.WriteLine($"A compra de R${valorCompra} " + $"Ficou no total de R${valorPagamento} com o desconto de cupom.");

valorPagamento = calcular.CalcularTotal(valorCompra, new DescontoQuantidade());
Console.WriteLine($"A compra de R${valorCompra} " + $"Ficou no total de R${valorPagamento} com o desconto por quantidade.");