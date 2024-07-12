// See https://aka.ms/new-console-template for more information
namespace Atividade
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true){
                Clientes Nome = new Clientes();
            Pessoa_Fisica pessoaFisica = new Pessoa_Fisica();
            Pessoa_Juridica pessoaJuridica = new Pessoa_Juridica();
            string pessoa;
            float valorCompra;
            System.Console.WriteLine("Digite seu nome:");
            Nome.nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu endereço:");
            Nome.endereco = Console.ReadLine();
            System.Console.WriteLine("Informe o valor da compra:");
            valorCompra = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe se é Pessoa Fisica (f) ou Pessoa Juridica (j)");
            pessoa = Console.ReadLine();
            if (pessoa == "f")
            {
                System.Console.WriteLine("Informe seu RG:");
                pessoaFisica.rg = Console.ReadLine();
                System.Console.WriteLine("Informe seu CPF:");
                pessoaFisica.cpf = Console.ReadLine();
                pessoaFisica.Pagar_Imposto(valorCompra);
                System.Console.WriteLine("\n");
                System.Console.WriteLine("................. PESSOA FISICA ......................");
                System.Console.WriteLine($"Nome...........: {Nome.nome}");
                System.Console.WriteLine($"RG.............: {pessoaFisica.rg}");
                System.Console.WriteLine($"CPF............: {pessoaFisica.cpf}");
                System.Console.WriteLine($"Endereço.......: {Nome.endereco}");
                System.Console.WriteLine($"Valor da Compra: {valorCompra.ToString("C")}");
                System.Console.WriteLine($"Imposto Cobrado: {pessoaFisica.valor_imposto.ToString("C")}");
                System.Console.WriteLine($"Total..........: {pessoaFisica.total.ToString("C")}");
                System.Console.WriteLine("........................................................");
            } else if (pessoa == "j") {
                System.Console.WriteLine("Informe seu CNPJ:");
                pessoaJuridica.cnpj = Console.ReadLine();
                System.Console.WriteLine("Informe sua Inscrição Estadual:");
                pessoaJuridica.ie= Console.ReadLine();
                pessoaJuridica.Pagar_Imposto(valorCompra);
                System.Console.WriteLine("\n");
                System.Console.WriteLine(".................... PESSOA JURIDICA ......................");
                System.Console.WriteLine($"Nome..............: {Nome.nome}");
                System.Console.WriteLine($"CNPJ..............: {pessoaJuridica.cnpj}");
                System.Console.WriteLine($"Inscrição Estadual: {pessoaJuridica.ie}");
                System.Console.WriteLine($"Endereço..........: {Nome.endereco}");
                System.Console.WriteLine($"Valor da Compra...: {valorCompra.ToString("C")}");
                System.Console.WriteLine($"Imposto Cobrado...: {pessoaJuridica.valor_imposto.ToString("C")}");
                System.Console.WriteLine($"Total.............: {pessoaJuridica.total.ToString("C")}");
                System.Console.WriteLine("........................................................");
            } else {
                System.Console.WriteLine(" Informe uma opção valida!!!");
            }
                                     
            }            
        }
    }
}
