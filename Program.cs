internal class Program
{
    private static void Main(string[] args)
    {
        
        string userInput = "";

        while (userInput.ToLower() !="exit")
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            userInput = Console.ReadLine() ?? "";
            
            if (userInput == "1")
            {
                CatFood catFood = new CatFood();

                Console.WriteLine("What is the name of the cat food?");
                catFood.Name = Console.ReadLine() ?? "";

                Console.WriteLine("What is the price of hte cat food?");
                if (decimal.TryParse(Console.ReadLine() ?? "0", out decimal result))
                {
                    catFood.Price = result;
                }
                else
                {
                    Console
                }
            }

        }
    }
}

class Product
{
    public static string Name { get; set; }
    {
        return Console.WriteLine("Name");
    

    public static decimal Price { get; set; }
{
        return Console.WriteLine("Price");
    }

    public static int Quantity { get; set; }
{
        return Console.WriteLine("Quantity");
    }

    public static string Descripton { get; set; }
{
        return Console.WriteLine("Descripton");
    }
}


    
class CatFood
{
    public static double WeightPounds { get; set; }
    {
        return Console.WriteLine("pounds");
    }
    public static bool KittenFood { get; set; }
{
        return Console.WriteLine("Food");
    }
}
class DogLeash
    {
    public static int LengthInches { get; set; }
        {
        return Console.WriteLine("Inc");
        }
    public static string Material { get; set; }
{
        return Console.WriteLine("Material");
        }
    }
public class ProductLogic
{
    private List<Product> _products;
    private Dictionary<string, DogLeash> _dogLeashes;
    private Dictionary<string, CatFood> _catFoods;

    public ProductLogic()
    {
        _products = new List<Product>();
        _dogLeashes = new Dictionary<string, DogLeash>();
        _catFoods = new Dictionary<string, CatFood>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);

        if (product is DogLeash dogLeash)
        {
            _dogLeashes[dogLeash.Name] = dogLeash;
        }
        else if (product is CatFood catFood)
        {
            _catFoods[catFood.Name] = catFood;
        }
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public DogLeash GetDogLeashByName(string name)
    {
        return _dogLeashes.ContainsKey(name) ? _dogLeashes[name] : null;
    }
}

class Program
{
    static void Main()
    {
        var productLogic = new ProductLogic();

        // Example usage:
        var dogLeash = new DogLeash { Name = "Retractable Leash" };
        productLogic.AddProduct(dogLeash);

        Console.WriteLine("Product added successfully!");
    }
}