//Sale sale = new Sale(); // Podemos crear el objeto asi
//Sale sale = new(); //  Así
var sale = new Sale(5); // O con var

var salewithTax = new SaleWithTax(5, 1.16m); // Creamos un objeto de la clase hija (La m indica que es un decimal)
sale.Total = 5; // Si en el contructor quitaramos el set, No podriamos asignarle ningún valor.


var message = sale.GetInfo();
Console.WriteLine(message); // Imprimimos el valor



class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
        //_someProtected = 5; // Se puede acceder a la propiedad protegida
    }

    public override string GetInfo() // Con Override sobreescribimos el método virtual del padre
    {
        return "El total es" + Total + "Impuesto es: " + Tax;
    }

    public string GetInfo(int a) // Sobrecarga del método GetInfo
    {
        return a.ToString();
    }
}

class Sale
{  
    public decimal Total { get; set; } // Las popiedades se escriben con mayuscla por convención
    private decimal _some; // Se le pone _ a las propiedades privadas
    protected decimal _someProtected; // Con protected se puede acceder a la propiedad desde una clase hija
    public Sale(decimal total)
    {
        Total = total;
        _some = 8; // Solo se puede acceder a una propiedad privada dentro de la clase
    }

    public virtual string GetInfo() // Con virtual le decimos que el método se puede sobreescribir
    {
        return "El toatal es: " + Total;
        //return $"Total: {Total}";
    }
}


