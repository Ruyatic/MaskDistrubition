























using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "A";
person1.LastName = "B";
person1.NationalIdentity = 123;
person1.DateOfBirthYear = 2000;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);