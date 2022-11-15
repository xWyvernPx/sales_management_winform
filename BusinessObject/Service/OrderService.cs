using AutoMapper;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
namespace BusinessObject.Service
{

    public class OrderService : IOrderService
    {
        IOrderRepository orderRepository = new OrderRepository();
        IMapper _mapper;
        public OrderService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderObject>();
                cfg.CreateMap<OrderObject, Order>();
            });
            this._mapper = config.CreateMapper();
        }
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderObject>();
                cfg.CreateMap<OrderObject, Order>();
            });
            this._mapper = config.CreateMapper();

        }
        public void Create(OrderObject order)
        {

            if (order is not null)
            {
                orderRepository.CreateOrder(_mapper.Map<OrderObject, Order>(order));
            }
        }

        public void Delete(int id)
        {
            orderRepository.DeleteOrder(id);
        }

        public IEnumerable<OrderObject> FindAll()
        {
             return orderRepository.getAllOrder().Select(e => _mapper.Map<Order, OrderObject>(e));
        }

        public OrderObject GetById(int id)
        {
            var order = orderRepository.GetOrder(id);
            return _mapper.Map<Order,OrderObject>(order);
        }

        public void Update(OrderObject order)
        {
            if (order is not null)
            {
                orderRepository.UpdateOrder(_mapper.Map<OrderObject, Order>(order));
            }
        }
    }
}
