public class Management{
    public int CounterIdUtilizator {get; set;} = 0;    
    public int CounterIdComanda {get; set;} = 0;
    public int CounterIdProdus { get; set;} = 0;
    public int contorIdElementeComanda{get; set;} = 0;

    List <Utilizator> Utilizatori = new List <Utilizator>();
    List <Comanda> Comenzi = new List <Comanda>();
    List<Produs> Produse = new List <Produs>();

    public void AdaugaProdus(){
        System.Console.WriteLine("Intodu numele produsului pe care vrei sa-l adaugi in lista de produse: ");
        CounterIdProdus++;
        Produs produs1 = new Produs(){Id = CounterIdProdus};
        produs1.Nume = Console.ReadLine();
        System.Console.WriteLine("Ce pret are produsul?\n");
        produs1.Pret= int.Parse(Console.ReadLine());
        Produse.Add(produs1);
 
    }
    public void AdaugaUser(){
        CounterIdUtilizator++;
        Utilizator user1 = new Utilizator(){Id = CounterIdUtilizator};
        System.Console.WriteLine("Introduce numele utilizatorului: ");
        user1.Nume = Console.ReadLine();
        Utilizatori.Add(user1);

        foreach(var user in Utilizatori)
        {
            System.Console.WriteLine(user.Id + " "+ user.Nume);
        }

    }

    public void AdaugaComanda(){
         System.Console.WriteLine("Pentru ce utilizator vrei sa adaugi o comanda?\n");
        System.Console.WriteLine("Introduceti numele utilizatorului: ");
        string AuxNume = Console.ReadLine();
        Utilizator Utilizator1 = Utilizatori.Find(u => u.Nume == AuxNume);

        if(Utilizator1 != null)
        {
            CounterIdComanda++;
            Comanda comanda1 = new Comanda(){Id = CounterIdComanda};

            System.Console.WriteLine("Doresti sa adaugi un produs in comanda?(y/n)\n");
            while(true) {
                
                char _optiune = Console.ReadLine()[0];
                
                if(_optiune == 'y')
                {
                    System.Console.WriteLine("Produsele disponibile sunt urmatoarele: ");
                    System.Console.WriteLine("IdProdus NumeProdus PretProdus");

                    foreach(var produs in Produse)
                    {   
                        System.Console.WriteLine(produs.Id + "\t"+ produs.Nume + "\t" + produs.Pret);
                    }

                    System.Console.WriteLine("Intoduceti numele produsului pe care vreti sa-l intoduceti: \n");
                    string numeProdus = Console.ReadLine();
                    
                    Produs Produs1 = Produse.Find(p => p.Nume == numeProdus);
                    
                    if(Produs1 != null)
                    {
                        contorIdElementeComanda++;
                        System.Console.WriteLine("Ce cantitate doresti sa intoduci?");
                        string cantitate = Console.ReadLine();
                        ElementComanda element1 = new ElementComanda(){Id = contorIdElementeComanda, Cantitate = int.Parse(cantitate)};
                        element1.Produs = Produs1;
                        comanda1.Valuare += int.Parse(cantitate) * element1.Produs.Pret;
                        comanda1.ElementeComanda.Add(element1);
                        comanda1.User = Utilizator1;
                    }
                    
                    
                } else 
                {
                    System.Console.WriteLine("Comanda a fost plasata cu succes!");
                    System.Console.WriteLine("Produsele din comanda sunt urmatoarele: ");
                    foreach (var element in comanda1.ElementeComanda)
                    {
                        System.Console.WriteLine(element.Produs.Nume);
                    }
                    System.Console.WriteLine("Valuarea comenzii este: " + comanda1.Valuare);

                    Comenzi.Add(comanda1);
                    System.Console.WriteLine("Produsul a fost adaugat cu succes in comanda!\n");
                    break;
                }

                

                System.Console.WriteLine("Produsele din comanda sunt urmatoarele: ");
                foreach (var element in comanda1.ElementeComanda){
                    System.Console.WriteLine(comanda1.Id + " "+ element.Produs.Nume);
                }
                System.Console.WriteLine("Valuarea comenzii este: " + comanda1.Valuare);
                System.Console.WriteLine("Doresti sa mai adaugi un produs in comanda?(y/n)\n");
            }


    }
}

public void ValuareComenziPerUtilizator(){
    System.Console.WriteLine("Pentru ce utilizator vrei sa vezi valuarea totala a comenzilor?");
    string numeU = Console.ReadLine();

    Utilizator U1 = Utilizatori.Find(u => u.Nume == numeU);
    double totalComenzi = 0;
    if(U1 != null){
        foreach(var comanda in Comenzi)
        {
            if(comanda.User.Nume == numeU){
                totalComenzi += comanda.Valuare;
            }
        }

        System.Console.WriteLine($"Valuarea totala a comenzilor utilizatorului este: " + totalComenzi);
    }
    else{
        System.Console.WriteLine("Utilizatorul nu exista!");
    }
}
}