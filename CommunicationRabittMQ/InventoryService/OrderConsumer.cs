using InventoryService.Data;
using MassTransit;
using Models;
using System.Text.Json;

namespace InventoryService
{
    public class OrderConsumer : IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
           var msg = context.Message;
            MyData.Data.Add(msg);
        }
    }
}
