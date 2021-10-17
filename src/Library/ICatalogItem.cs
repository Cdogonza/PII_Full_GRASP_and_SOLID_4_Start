namespace Full_GRASP_And_SOLID
{
// Esta interface se creo porque las clases Product y Equipment tiene una estructura del constructor igual en cuanto a los parametros que reciben
// Nos permite reutilizar los metodos y tener una lista unica que utilizan los catalogos sin la necesidad de crear listas para cada Tipo
public interface ICatalogItem
{

    string Description { get; set; }
    double Cost { get; set; }


}
}