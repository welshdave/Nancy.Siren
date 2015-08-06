﻿namespace Nancy.Siren.Demo
{
    using Nancy.Siren.Demo.Model;

    public class OrdersModule : NancyModule
    {
        public OrdersModule(IOrderRepository orderRepository) : base("/orders")
        {
            Get["/"] = _ =>
                {
                    var orders = orderRepository.GetAll();
                    return orders;
                };

            Get["/{id:int}"] = parameters =>
            {
                int id = parameters.id;
                var order = orderRepository.GetById(id);
                return order;
            };
        }
    }
}
