using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using PersonApp.Domain;

namespace PersonApp.Repositories
{

public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }


        //Escribe un método en el cual se retorne la información de todas las personas.
        public IEnumerable<Person> GetAll()
                {
                    var query = _persons.Select(person => person);
                    return query;
                }
        //Escribe un método en el cual se retorne únicamente el nombre completo de las personas, el correo y el año de nacimiento.
        public IEnumerable<Object> GetFields()
        {
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1),
                Correo = person.Email
            });

            return query;
        }
        //Escribe un método que retorne la información de todas las personas cuyo genero sea Femenino.

        public IEnumerable<Person> GetByGender()
        {
            var gender = 'F';
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }
        //Escribe un método que retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años.
        public IEnumerable<Person> GetByRangeAge()
        {
            var minAge = 20;
            var maxAge = 30;
            var query = _persons.Where(Person => Person.Age >= minAge && Person.Age <= maxAge);
            return query;
        }
        //Escribe un método que retorne la información de los diferentes trabajos que tienen las personas.
        public IEnumerable<string> GetDistinct()
        {            
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }
        //Escribe un método que retorne la información de las personas cuyo nombre contenga la palabra "ar".
        public IEnumerable<Person> GetContains()
        {            
            var query = _persons.Where(person => person.FirstName.Contains("ar"));
            return query;
        }

        //Escribe un método que retorna la información de las personas cuyas edades sean 25, 35 y 45 años.
        public IEnumerable<Person> GetByAges()
        {
            var ages = new List<int>{25,35,45};
            var query = _persons.Where(Person => ages.Contains(Person.Age));
            return query;
        }
        //Escribe un método que retorne la información ordenas por edad para las personas que sean mayores a 40 años.
        public IEnumerable<Person> GetPersonsOrdered()
        {
            var minAge = 40;
            var query = _persons.Where(Person => Person.Age > minAge).OrderBy(person => person.Age);
            return query;
        }
        //Escribe un método que retorne la información ordenada de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad.
        public IEnumerable<Person> GetPersonsOrderedDescending()
        {
            var gender = 'M';
            var minAge = 20;
            var maxAge = 30;
            var query = _persons.Where(Person => Person.Gender == gender && Person.Age >= minAge && Person.Age <= maxAge ).OrderByDescending(person => person.LastName);
            return query;
        }
        //Escribe un método que retorne la cantidad de personas con género femenino.
        public int CountPerson()
        {
            var gender = 'F';
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }
        //Escribe un método que retorna si existen personas con el apellido “Shemelt”.
        public bool ExistPerson()
        {
            var lastName = "Shemelt";
            var query = _persons.Exists(person => person.LastName == lastName);
            return query;
        }
        //Escribe un método que retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad.
        public IEnumerable<Person> TakePerson()
        {
            var job = "Software Consultant";
            var age = 25;
            var take = 1;
            var query = _persons.Where(person => person.Job == job && person.Age == age).Take(take);
            return query;
        }

        //Escribe un método que retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”.
        public IEnumerable<Person> TakePersonFirst()
        {
            var job = "Software Consultant";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }
        //Escribe un método que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”.
        public IEnumerable<Person> SkipPerson()
        {
            var job = "Software Consultant";
            var skip = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }
        //Escribe un método que omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”.
        public IEnumerable<Person> SkipTakePerson()
        {
            var job = "Software Consultant";
            var skip = 3;
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }

    }
}