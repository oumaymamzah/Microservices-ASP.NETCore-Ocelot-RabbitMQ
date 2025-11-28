using MassTransit;
using OrdersAPI.Data;
using Shared.Models;

namespace OrdersAPI.Consumer
{
    public class ProductCreatedConsumer : IConsumer<ProductCreated>
    {
        private readonly OrdersDbContext _context;

        public ProductCreatedConsumer(OrdersDbContext context)
        {
            _context = context;
        }

        public async Task Consume(ConsumeContext<ProductCreated> context)
        {
            var message = context.Message;

            var product = new Product
            {
                // Id = message.Id,
                Name = message.Name,
                Price = message.Price
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}