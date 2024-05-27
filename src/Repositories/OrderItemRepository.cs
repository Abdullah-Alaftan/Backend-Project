using AutoMapper;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private DbSet<OrderItem> _orderItems;
        private DatabaseContext _databaseContext;
        private IMapper _mapper;


        public OrderItemRepository(DatabaseContext databaseContext, IMapper mapper)
        {
            _orderItems = databaseContext.OrderItems;
            _databaseContext = databaseContext;
            _mapper = mapper;

        }

        public OrderItem CreateOne(OrderItem newOrderItem)
        {
            _orderItems.Add(newOrderItem);
            _databaseContext.SaveChanges();
            return newOrderItem;
        }

        public OrderItem? DeleteOne(Guid orderItemId)
        {
            var deleteItem = FindOne(orderItemId);
            _orderItems.Remove(deleteItem!);
            _databaseContext.SaveChanges();
            return deleteItem;
        }
        public IEnumerable<OrderItem> FindAll()
        {
            return _orderItems;
        }

        public OrderItem? FindOne(Guid orderId)
        {
            var FindOrderItem = _orderItems.Find(orderId);
            return FindOrderItem;
        }

        public OrderItem? UpdateOne(OrderItem updatedItem)
        {

            // var updatedOrderItems = _orderItems.Select((item)=>{
            //     if (item.Id == updatedItem.Id){
            //         return updatedItem;
            //     }
            //     return item;
            // });
            // _orderItems = updatedOrderItems.ToList();
            return updatedItem;
        }
    }
}