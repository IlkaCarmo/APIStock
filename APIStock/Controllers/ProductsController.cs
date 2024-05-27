using APIStock.Data.Collections;
using APIStock.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Data.MongoDB _mongoDB;

        IMongoCollection<Product> _ProductCollection;

        public ProductsController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _ProductCollection = _mongoDB.DB.GetCollection<Product>(typeof(Product).Name.ToLower());
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult GetProduct()
        {
            var product = _ProductCollection.Find(Builders<Product>.Filter.Empty).ToList();

            return Ok(product);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult PostProduct([FromBody] ProductDto dto)
        {
            var product = new Product(dto.Name, dto.Description, dto.Price, dto.category, dto.supplier, dto.Created_at, dto.Updated_at);
            _ProductCollection.InsertOne(product);
            return StatusCode(201, "Product adicionado");
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
