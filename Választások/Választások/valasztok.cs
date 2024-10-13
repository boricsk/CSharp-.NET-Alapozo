
namespace Választások
{
    public class Valasztok
    {
        //ez az osztály a választó listát fogja tartalmazni.
        //a listát propertykénk kell definiálni
        public List<Valaszto> ValasztoLista { get; set; }

        //konstruktor kezdőbeállításhoz
        public Valasztok()
        {
            ValasztoLista = new List<Valaszto>();
        }
    }
}
