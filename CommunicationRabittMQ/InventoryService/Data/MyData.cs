using Models;

namespace InventoryService.Data
{
    public static class MyData
    {
        public static List<Order> Data { get; set; }
        static MyData()
        {
            Data = new List<Order>();
        }
    }
}
