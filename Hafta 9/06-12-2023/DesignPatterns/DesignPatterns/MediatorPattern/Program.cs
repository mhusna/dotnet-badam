using MediatorPattern.Abstract;
using MediatorPattern.Concrete;

ConcreteUser cevdet = new ConcreteUser("Cevdet");
ConcreteUser selami = new ConcreteUser("Selami");
ConcreteUser dursun = new ConcreteUser("Dursun");
ConcreteUser temel = new ConcreteUser("Temel");

Mediator mediator = new Mediator();
mediator.Register(cevdet);
mediator.Register(selami);
mediator.Register(dursun);
mediator.Register(temel);

cevdet.Send("Merhaba..");