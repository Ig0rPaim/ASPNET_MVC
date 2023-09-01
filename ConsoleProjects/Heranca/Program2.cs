using Heranca.Entities2;
using Heranca.EntitiesTaxPlayers;

internal class Program2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //UPCASTING QUANDO UMA SUPERCLASSE RECEBE UMA SUBCLASSE NÃO PRECISA DE CASTING EXPLICITO
        // USADO COM POLIMORFISMO


        //DOWNCASTING QUANDO UMA SUBCLASSE RECEBE UMA SUPERCLASSE, PRECISA DE CASTING EXPLICITO
        // É INSEGURO TEM QUE TESTAR SE AS CLASSES SÃO COMPATIVEIS 'is' if( x is y)
        //POSSO USAR O 'as' PARA FAZER O CASTING x = y as x

        //VIRTUAL E OVERRIDE SERVEM PARA SOBREPOSSIÇÃO
        // public virtual
        //public override
        //PODE-SE UASR O 'base' PARA APROVEITAR A IMPLEMENTAÇÃO DA SUPERCLASSE E ACRESSENTAR ALGO

        //'sealed' SELA UMA CLASSE PARA QUE NÃO SEJA HERDADA, EMBORA OS METODOS POSSAM SER UTILIZADOS COM EXTENDS METHODS

        //POLIMORFISMO VARIÁVEIS DO MESMO TIPO INSTACIADAS COM OBJETOS DIFERENTER TEM COMPORTAMENTOS DIFERENTES
        //POLIMORFISMO ACONTECE EM TEMPO DE EXECUÇÃO OBJETOS GENERICOS ASSOSSIADOS A ESPECIFICOS EM TEMPO DE EXECUÇÃO

        //List<Product> products = new List<Product>();

        //Console.WriteLine("Enter the number of products:");
        //int NumberProducts = int.Parse(Console.ReadLine()!);

        //for(int i = 0; i < NumberProducts; i++)
        //{
        //    Console.WriteLine("Common, used or imported (c/u/i)?");
        //    string TypeProduct = Console.ReadLine()!;
        //    Console.WriteLine("Name: ");
        //    string ProductName = Console.ReadLine()!;
        //    Console.WriteLine("Price: ");
        //    double ProductPrice = Convert.ToDouble(Console.ReadLine());
        //    double ProductCustomsFee;
        //    DateTime ProductDate;
        //    switch(TypeProduct)
        //    {
        //        case "i":
        //            Console.WriteLine("Custms Fee: ");
        //            ProductCustomsFee = Convert.ToDouble(Console.ReadLine()!);
        //            products.Add(new ImportedProduct(ProductName!, ProductPrice, ProductCustomsFee));
        //            break;
        //        case "u":
        //            Console.WriteLine("Manufacture Date (DD/MM/YYYY): ");
        //            ProductDate = DateTime.Parse((Console.ReadLine()!));
        //            products.Add(new UsedProduct(ProductName!, ProductPrice, ProductDate));
        //            break;
        //        default:
        //            products.Add(new Product(ProductName, ProductPrice));
        //            break;
        //    }

        //}
        //foreach (Product product in products)
        //{
        //    Console.WriteLine(product.PriceTag());
        //}
        List<TaxPlayers> taxPlayers = new List<TaxPlayers>();

        Console.Write("Enter the number of tax payers:");
        int NumberOfPayers = int.Parse(Console.ReadLine()!);

        for( int i = 0; i < NumberOfPayers; i++ )
        {
            Console.WriteLine("Tax payer #1 data:");
            Console.Write("Individual or company (i/c)?");
            string Type = Console.ReadLine()!;
            Console.Write("Name: ");
            string Name = Console.ReadLine()!;
            Console.Write("Anual Income: ");
            double AnualIncome = double.Parse(Console.ReadLine()!);
            if (Type[0] == 'i')
            {
                Console.Write("HealthExpeditures: ");
                double HealthExpeditures = double.Parse(Console.ReadLine()!);
                taxPlayers.Add(new Individual(Name, AnualIncome, HealthExpeditures));
            }
            else if (Type[0] == 'c')
            {
                Console.Write("Number of employers: ");
                int Employers = int.Parse(Console.ReadLine()!);
                taxPlayers.Add(new Company(Name, AnualIncome, Employers));
            }
        }
        foreach(TaxPlayers taxPlayer in taxPlayers)
        {
            Console.WriteLine(taxPlayer);
        }
    }
}