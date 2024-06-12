using Soru15;

Seat seat = new Seat(5);
Console.WriteLine(seat.Number);

Person person = new Person() { Ad = "Ahmet"};
seat.Passenger = person;
Console.WriteLine(person.Ad);

Person person2 = new Person() { Ad = "Mehmet" };
seat.Passenger = person2;
Console.WriteLine(person.Ad);

