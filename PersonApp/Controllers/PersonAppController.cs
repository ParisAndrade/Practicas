using System;
using Microsoft.AspNetCore.Mvc;
using PersonApp.Domain;
using PersonApp.Repositories;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonAppController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetFields")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetByGender")]
        public IActionResult GetByGender()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetByRangeAge")]
        public IActionResult GetByRangeAge()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetDistinct")]
        public IActionResult GetDistinct()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDistinct();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetContains")]
        public IActionResult GetContains()
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetByAges")]
        public IActionResult GetByAges()
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAges();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetPersonsOrdered")]
        public IActionResult GetPersonsOrdered()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("GetPersonsOrderedDescending")]
        public IActionResult GetPersonsOrderedDescending()
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDescending();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("CountPerson")]
        public IActionResult CountPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("ExistPerson")]
        public IActionResult ExistPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("TakePerson")]
        public IActionResult TakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("TakePersonFirst")]
        public IActionResult TakePersonFirst()
        {
            var repository = new PersonRepository();
            var persons = repository.TakePersonFirst();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("SkipPerson")]
        public IActionResult SkipPerson()
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("SkipTakePerson")]
        public IActionResult SkipTakePerson()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 
        
    }
}  