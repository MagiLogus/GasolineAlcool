// 2-Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine($"Informe a quantidade e litros vendidos: ");
float litrosVendidos = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o tipo de combustível, utilizando a seguinte forma (A- álcool e G- gasolina): ");
char tipoCombustivel = char.Parse(Console.ReadLine());

float preco = 0;
float desconto = 0;
float valorTotal = 0;

switch (tipoCombustivel) 
{
case 'A':
preco = 4.90F;
if (litrosVendidos <= 20) 
{
    desconto = 0.03F;
} 
else 
{
    desconto = 0.05F;
}
break;

case 'G':
preco = 5.3F;
if (litrosVendidos <= 20) 
{
desconto = 0.04F;
} 
else 
{
desconto = 0.06F;
}
break;

default:
Console.WriteLine("Tipo de combustível inválido");
break;
}

valorTotal = (litrosVendidos * preco) * desconto;
Console.WriteLine($"Valor a ser pago: R$ {Math.Round(valorTotal, 2).ToString()}");