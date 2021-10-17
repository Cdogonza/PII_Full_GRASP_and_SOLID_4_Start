namespace Full_GRASP_And_SOLID
{
    // Claramente se ve la utilizacion del patron Creator, dandole a esta clase la responsabilidad de crear instancias de su producto, y no en el Program como antes
    public class ProductCatalog : GenericCatalog

    {
        public static  void PopulateCatalogs()

        {   
            AddToCatalog(new Product("Café", 100));
            AddToCatalog(new Product("Leche", 200));
            AddToCatalog(new Product("Café con leche", 300));
        }


    }
}