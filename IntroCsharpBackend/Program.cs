
// El número que le pasamos es para el _limit
var numbers = new MyList<int>(2);
var names = new MyList<string>(2);
var beers = new MyList<Beer>(2);


numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
Console.WriteLine(numbers.GetContent());


names.Add("John");
names.Add("Doe");
names.Add("Jane");
names.Add("Doe");
names.Add("Jack");
names.Add("Doe");
Console.WriteLine(names.GetContent());


beers.Add(new Beer { Name = "Corona", Price = 2.5 });
beers.Add(new Beer { Name = "Heineken", Price = 3.5 });
beers.Add(new Beer { Name = "Budweiser", Price = 1.5 });
beers.Add(new Beer { Name = "Modelo", Price = 2.0 });
Console.WriteLine(beers.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ", ";
        }
        return content;
    }

}


public class Beer
{
    public string Name { get; set; }
    public double Price { get; set; }


    public override string ToString() // Sobreescribimos el método ToString para que nos muestre el nombre y el precio de la cerveza del obejeto Object.
    {
        return "Nombre: " + Name + " Price :" + Price;
    }
}