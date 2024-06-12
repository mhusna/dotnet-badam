using EntityFramework_I;
using System.Globalization;
using System.Xml.Linq;

dynamic d10 = "mrb";
d10 = 123;

object obj = 12;
//int sayi = obj;

dynamic obj2 = 13;
int sayi2 = obj2;

#region ObjectInitializer
Personel personel = new Personel()
{
    ID = 1,
    Name = "Aşiy"
};

Personel personel2 = new Personel()
{
    ID = 2,
    Name = "Zakka"
};
#endregion

#region CollectionInitializer
List<Personel> personeller = new List<Personel>()
{
    personel, personel2
};
#endregion

#region Anonymous Type
var nesne = new { ID = 111, Ad = "Cevdet", Adres = "Jamaika" };
#endregion