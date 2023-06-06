using CafeCommon;
using Microsoft.AspNetCore.Mvc;
using OrderService.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: <OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new Order[] { };
        }

        // GET <OrderController>/5
        [HttpGet("{id}")]
        public Order Get(string id)
        {
            return _orderRepository.Get(id);
        }

        // POST <OrderController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
        }

        // PUT <OrderController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Order order)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
