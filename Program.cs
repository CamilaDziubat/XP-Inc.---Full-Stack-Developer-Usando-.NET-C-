// // // // // Importa o namespace que contém a classe "Pessoa", caso precise utilizá-la futuramente.
 using ExemplosFundamentos.models;

// Laços de Repetição

int numero = 5;

// Laço de repetição com 'for'

for(int contador = 0; contador <= 10; contador++ )
{
    Console.WriteLine($"{numero} x {contador} = {numero *  contador}");
}



















// //Calculadora calc = new Calculadora();

// //calc.Somar(10,20);
// //calc.Subtrair(20,10);
// //calc.Dividir(100,2);
// //calc.Multiplicar(100,10);
// //calc.Potencia(3,3);
// //calc.Seno(30);
// //calc.Coseno(30);
// //calc.Tangente(30);

// int numero = 10;

// // Exibindo o valor inicial de 'numero'
// Console.WriteLine($"Número inicial: {numero}");

// // Incrementando o valor de 'numero' e informando o usuário
// Console.WriteLine("Incrementando o 10...");

// // Incrementando
// //numero = numero + 1;
// numero++;

// // Exibindo o novo valor de 'numero'
// Console.WriteLine($"Novo valor após incremento: {numero}");

























// // // // OPERADOR (OR) - PIPE || 

// // // bool  ehMaiorDeIdade = true;

// // // // Verifica se a pessoa é maior de idade, ou seja, se a idade é maior ou igual a 18.

// // // bool possuiAltorizacaoDoResponsavel =false;

// // // // Verifica se a pessoa possui altorização do responsável para realizar a entrar.

// // // if (ehMaiorDeIdade || possuiAltorizacaoDoResponsavel)
// // // {
// // //     Console.WriteLine("Entrada Autorizada!");
// // // }
// // // else 
// // // {
// // //     Console.WriteLine("Entrada Negada!");
// // // }
// // // //---------------------------------------------------------------------------------------//
// // // //OPERADOR AND (&&)

// // // bool presencaminima = true;

// // // // Verifica se a pessoa está presente na sala de espera, ou seja, se a presença mínima é atendida.

// // // //double media  = 7.5;

// // // // Verifica se a pessoa possui a habilidade técnica necessária para realizar a entrar, ou seja, se a habilidade é superior ou igual a 7.5.  

// // // //if (presencaminima && media >= 7)
// // // //{
// // //     //Console.WriteLine("Entrada Autorizada!");
// // // //}
// // // else
// // // {
// // //     Console.WriteLine("Entrada Negada!");
// // // }

// // // //---------------------------------------------------------------------------------------//
// // //                          // OPERADOR NOT (!) //

// //  //bool choveu =true;
// //  //bool estaTarde =true;

// // // // Verifica se a pessoa está chovendo e se é de tarde.

// //  //if (!choveu && !estaTarde)
// //     //{
// //     //  Console.WriteLine("Esta Autorizado a Pedalar");   
// //    // }
// //  //else  {
// //         // Console.WriteLine("Esta Negado a Pedalar");
// //       // }


// // // //---------------------------------------------------------------------------------------//

// // // // // Declaração e inicialização das variáveis de controle de estoque e compra.
// // // // int quantidadeEmEstoque = 10; // Quantidade de itens disponíveis em estoque.
// // // // int quantidadeDeCompra = 0; // Quantidade que o cliente deseja comprar.

// // // // // Verifica se é possível realizar a venda, ou seja, se a quantidade de compra é maior que 0 e se há estoque suficiente.
// // // // bool possivelVenda = quantidadeDeCompra > 0 && quantidadeEmEstoque >= quantidadeDeCompra;

// // // // // Exibe no console a quantidade em estoque e a quantidade de compra.
// // // // Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// // // // Console.WriteLine($"Quantidade De Venda: {quantidadeDeCompra}");

// // // // // Exibe no console se é possível realizar a venda.
// // // // Console.WriteLine($"É Possivel Realizar a Venda? {possivelVenda}");

// // // // // Condicional para verificar diferentes situações de compra
// // // // if (quantidadeDeCompra == 0) 
// // // // {
// // // //     // Informa que não é possível realizar a compra se a quantidade de compra for igual a zero.
// // // //     Console.WriteLine("Não é possível realizar a compra, pois a quantidade de compra é zero.");
// // // // }
// // // // else if (possivelVenda)
// // // // {
// // // //     // Se a venda é possível, exibe uma mensagem de sucesso.
// // // //     Console.WriteLine("Compra Realizada Com Sucesso!");
// // // // }
// // // // else
// // // // {
// // // //     // Caso a quantidade de compra seja maior que o estoque, informa que a compra não pode ser realizada.
// // // //     Console.WriteLine("Não é possível realizar a compra, pois não há estoque suficiente.");
// // // // }

// // // // // Comentários de código para futuras referências e explicações
// // // // // Neste bloco, há exemplos de manipulação de strings e conversões de tipos:

// // // // // string a = "15-"; // Uma string que contém um valor que não pode ser convertido diretamente em um inteiro.
// // // // // int b = 0; // Variável para armazenar o resultado da conversão.

// // // // // A função 'int.TryParse' tenta converter a string 'a' em um inteiro e atribui o valor à variável 'b'.
// // // // // Se a conversão falhar, 'b' permanecerá com o valor padrão 0.
// // // // //int.TryParse(a, out b);

// // // // // Exibe o valor de 'b' após a tentativa de conversão.
// // // // //Console.WriteLine(b);

// // // // // Mensagem indicando que a conversão foi realizada (mesmo que não tenha resultado em um valor válido).
// // // // Console.WriteLine("Conversão realizada com sucesso!!");
// // // // Console.WriteLine("Ai sim, Garota!!! Show!!!");

// // // // // Abaixo estão exemplos de conversões explícitas conhecidas como "casting".

// // // // // Convertendo a string "5" para um número inteiro usando 'Convert.ToInt32' e 'int.Parse'.
// // // // // int a = Convert.ToInt32("5");
// // // // // int a = int.Parse("5");
// // // // // Console.WriteLine(a);

// // // // // Exemplo básico de operações aritméticas:
// // // // // int a = 10;
// // // // // int b = 5;
// // // // // int c = a + b;
// // // // // Console.WriteLine(c);

// // // // // Manipulação de datas usando a classe DateTime:
// // // // DateTime dataAgora = DateTime.Now.AddDays(5); // Adiciona 5 dias à data e hora atual.
// // // // Console.WriteLine(dataAgora.ToString("dd/MM/yyyy HH:mm")); // Exibe a data no formato "dia/mês/ano horas:minutos".

// // // // // Declaração de variáveis com diferentes tipos de dados para ilustrar os conceitos:
// // // // string apresentacao = "Olá, seja bem-vindo"; // Uma string para mensagens de boas-vindas.
// // // // int quantidade = 1; // Um número inteiro que representa a quantidade.
// // // // double altura = 1.80; // Um número de ponto flutuante que representa a altura.
// // // // double peso = 70.5; // Outro número de ponto flutuante que representa o peso.
// // // // decimal preco = 1.80M; // Um número decimal com precisão adequada para valores monetários (o 'M' indica que é um tipo decimal).
// // // // bool condicao = true; // Um valor booleano que pode ser 'true' ou 'false'.

// // // // // Exibe as variáveis no console para visualizar os valores atribuídos.
// // // // Console.WriteLine(apresentacao);
// // // // Console.WriteLine("Qual o valor da quantidade " + quantidade);
// // // // Console.WriteLine("Qual o valor da altura " + altura.ToString("0.00"));
// // // // Console.WriteLine("Qual o valor da peso " + peso);
// // // // Console.WriteLine("Qual o valor da preco " + preco);
// // // // Console.WriteLine("Qual o valor da condicao " + condicao);

// // // // // Comentado: Exemplo de uso da classe 'Pessoa' que faz parte do namespace importado
// // // // // Pessoa Client1 = new Pessoa();
// // // // // Client1.Nome = "Camila"; // Atribui um valor à propriedade 'Nome' da classe 'Pessoa'.
// // // // // Client1.Idade = 27; // Atribui um valor à propriedade 'Idade' da classe 'Pessoa'.
// // // // // Client1.Apresentar(); // Chama o método 'Apresentar' da classe 'Pessoa' para exibir uma mensagem.
