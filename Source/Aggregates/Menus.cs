using Dolittle.SDK.Aggregates;
using Dolittle.SDK.Events;
using Source.Commands;
using System;

namespace Source.Aggregates
{
 
    [AggregateRoot("")]
    public class Menus : AggregateRoot
    {
        public Menus(EventSourceId eventSourceId) : base(eventSourceId)
        {
        }

        public void Process(RequestMenuForRestaurant command)
        {

        }
    }
}
