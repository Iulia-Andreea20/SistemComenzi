// clasa Comanda: id, numar, vizitator, valuare, data, lista de elemente lista<ElementeComanda>

public class Comanda {

    public int Id {get; set;}
    public int Numar {get; set;}

    public Utilizator User {get; set;}

    public double Valuare {get; set;}

    public string Data {get; set;}

    public List<ElementComanda> ElementeComanda = new List<ElementComanda>();
}