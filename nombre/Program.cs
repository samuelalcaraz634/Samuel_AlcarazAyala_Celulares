// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Estados
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Sistemas
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Sedes
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Celulares
{
    public int Id = 0;
    public string? Modelo = "";
    public decimal Precio = 0.0m;
    public Estados Estado = new Estados();
    public Sistemas Sistema= new Sistemas();
    public List<Sedes> SedesDisponibles = new List<Sedes>();
}

var celular = new Celulares();
Celulares cl1 = new Celulares();

celular.Id = 1;
celular.Modelo = "iphone 15";
celular.Precio = 3500000.0m;
celular.Estado = new Estados() { Id = 1, Nombre = "Nuevo" };
celular.Sistema = new Sistemas() { Id = 1, Nombre = "Apple" };
celular.SedesDisponibles = new List<Sedes>();
celular.SedesDisponibles.Add(new Sedes() { Id = 1, Nombre = "Envigado" });
celular.SedesDisponibles.Add(new Sedes() { Id = 2, Nombre = "Medellín" });

foreach (var sede in celular.SedesDisponibles)
{
    Console.WriteLine(sede.Nombre);
}

