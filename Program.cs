Management management = new Management ();


while(true){
    System.Console.WriteLine("Meniu\n");
    System.Console.WriteLine("\tApasa 1 pentru a adauga un utilizator");
    System.Console.WriteLine("\tApasa 2 pentru a adauga o comanda");
    System.Console.WriteLine("\tApasa 3 pentru a adauga un produs nou in lista de produse");
     System.Console.WriteLine("\tApasa 4 a vedea valoarea totala a comenzilor pentru un anumit utilizator");
     System.Console.WriteLine("\tApasa 9 pentru a finaliza comanda!");
    string optiune = Console.ReadLine();
    if(int.Parse(optiune) == 1){
        management.AdaugaUser();   
    } 
    else if(int.Parse(optiune) == 2){
       management.AdaugaComanda();
    }
    else if(int.Parse(optiune) == 3){
        management.AdaugaProdus();
    }
    else if(int.Parse(optiune) == 4){
        management.ValuareComenziPerUtilizator();
    }
    else if(int.Parse(optiune) == 9)
    {
        break;
    }

}

