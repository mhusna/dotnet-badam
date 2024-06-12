using SOLID_V_DIP.Cozum;

/* CONSTRUCTOR INJECTION KULLANIMI */
DbManager manager = new DbManager(new MsSQL());
Console.WriteLine(manager.Oku());

/* METHOD INJECTION KULLANIMI */
DbManager manager2 = new DbManager();
manager2.Inject(new Oracle());

Console.WriteLine(manager2.Oku());

/* PROPERTY INJECTION KULLANIMI */
DbManager manager3 = new DbManager();
manager3.InjectProp = new MsSQL();

Console.WriteLine(manager3.Oku());


/* 
  HATALI KULLANIM 

  Nasıl Çözeriz ? Injection yöntemleriyle.. 
 */
DbManager manager4 = new DbManager();
manager4.Oku();