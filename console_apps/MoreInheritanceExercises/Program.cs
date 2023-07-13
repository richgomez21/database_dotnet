
Book book = new Book{
    Title = "Magic Tree House",
    Author = "Earl Deez"
};
System.Console.WriteLine(book.Read(10));

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Novel novel = new Novel{
    Title = "Novel",
    Author = "Mac DEEZ"
};
System.Console.WriteLine(novel.Read(10));

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Textbook textbook = new Textbook{
    Title = "Textbook",
    Author = "Mac DEEZ"
};

System.Console.WriteLine(textbook.Read(10));

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");
//////////////////////////////////////////////////////
Musician newMusician = new Musician();
newMusician.Name = "Earl";
string song1 = newMusician.Play("song 1");

System.Console.WriteLine($"{newMusician.Name} Sings: {song1}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Guitarist newGuitarist = new Guitarist();
newGuitarist.Name = "DAN";
string song2 = newGuitarist.Play("song 2");

System.Console.WriteLine($"{newGuitarist.Name} Sings: {song2}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Pianist newPianist = new Pianist();
newPianist.Name = "JOE";
string song3 = newPianist.Play("song 3");

System.Console.WriteLine($"{newPianist.Name} Sings: {song3}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");
//////////////////////////////////////////////////////
Restaurant newRestaurant = new Restaurant();
newRestaurant.Name = "GUD EATS";
string newDish = newRestaurant.ServeDish("FOOD");

System.Console.WriteLine($"{newRestaurant.Name} Food: {newDish}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Pizzeria newPizzeria = new Pizzeria();
newPizzeria.Name = "GUD PIZZA";
string newDish2 = newPizzeria.ServeDish("5 cheez pizza");

System.Console.WriteLine($"{newPizzeria.Name} Food: {newDish2}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

SushiBar newSushiBar = new SushiBar();
newSushiBar.Name = "GUD SUSH";
string newDish3 = newSushiBar.ServeDish("CALI ROLL");

System.Console.WriteLine($"{newSushiBar.Name} Food: {newDish3}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");
//////////////////////////////////////////////////////

Computer newComputer = new Computer();
newComputer.Brand = "Microsoft";
System.Console.WriteLine($"{newComputer.Brand} {newComputer.Boot("microsoft")}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Desktop newDesktop = new Desktop();
newDesktop.Brand = "Apple";
System.Console.WriteLine($"{newDesktop.Brand} {newDesktop.Boot("apple")}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");

Laptop newLaptop = new Laptop();
newLaptop.Brand = "RAZER";
System.Console.WriteLine($"{newLaptop.Brand} {newLaptop.Boot("razer")}");

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-=-=-=--");