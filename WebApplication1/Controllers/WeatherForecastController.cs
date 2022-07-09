using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using WebApplication1;




namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private IMongoCollection<User> _collection;
        public ToDoController(IMongoClient client)
        {
            var database = client.GetDatabase("todo");
            _collection = database.GetCollection<User>("users");
        }
        
        [HttpGet("manga")]
        public IEnumerable<User> Get()
        {
            return _collection.Find(s => true).ToList();
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _collection.InsertOne(user);
        }
        
        
    }
}