namespace D_Cors_API_Demo.Models
{
    public class ProductList
    {
        public int pId { get; set; }

        public string pName { get; set; }

        public string pDescription { get; set; }
        public string pCategory { get; set; }

        public double pPrice { get; set; }

        public bool pIsInStock { get; set; }
    }

    private static List<ProductList> productLists = new List<ProductList>()
        {
            new ProductList(){pId=101,pName="Satish",pCategory="Mobile",pDescription="NA",pPrice=100000,pIsInStock=true},
            new ProductList(){pId=102,pName="Sampath",pCategory="Ayush Hair Shampoo",pDescription="Dandruff Shampoo",pPrice=1000,pIsInStock=true},
        };    
}
