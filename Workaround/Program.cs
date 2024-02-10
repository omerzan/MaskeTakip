// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;


Person person1 = new Person();
person1.FirstName = "ÖMER";
person1.LastName = "KOCA";
person1.NationalIdentity = 123;
person1.DateofBirth = 1998;

PttManager pttManager= new PttManager(new PersonManager());

pttManager.GiveMask(person1);