using Microsoft.AspNetCore.Mvc;
using PosgtreSQLTest.Models;

namespace PosgtreSQLTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        protected TestDBContext _context;

        public ItemsController(ILogger<ItemsController> logger, TestDBContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "GetItems")]
        public IEnumerable<Items> GetItems()
        {
           return _context.Items.Take(10);
        }

        [HttpPost(Name = "Create Item")]
        public Items CreateItem(Items newItem)
        {
            _context.Add(newItem);
            _context.SaveChanges();
            return newItem;

        }
    }
}