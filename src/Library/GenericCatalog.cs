using System.Collections.Generic;
using System.Linq;

// Se creo esta clase generica para definir lo que debe tener la clase ProductCatalog y EquipmentCatalog
// A traves de esta clase cada catalogo puede extender su comportamiento sin la necesidad de modificar la propia clase 
namespace Full_GRASP_And_SOLID
{
    public class GenericCatalog
    {
        public static List<ICatalogItem> catalog = new List<ICatalogItem>();
         
        public static void AddToCatalog(ICatalogItem item){

            catalog.Add(item);

        }
        public static ICatalogItem ItemAt(int index)
        {
            return catalog[index] as ICatalogItem;
        }

        public static ICatalogItem GetByDescription(string description)
        {
            var query = from ICatalogItem var in catalog where var.Description == description select var;
            return query.FirstOrDefault();
        }
    }
}