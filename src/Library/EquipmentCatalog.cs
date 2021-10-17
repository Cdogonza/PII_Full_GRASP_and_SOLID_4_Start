
    // Claramente se ve la utilizacion del patron Creator, dandole a esta clase la responsabilidad de crear instancias de Equipment, y no en el Program como antes

namespace Full_GRASP_And_SOLID
{
    public class EquipmentCatalog : GenericCatalog

    {            
        public static  void PopulateCatalogs()
        {
             AddToCatalog(new Equipment("Cafetera", 1000)); 
             AddToCatalog(new Equipment("Hervidor", 2000));
        }   
    }
}