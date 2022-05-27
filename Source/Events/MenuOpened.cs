using Dolittle.SDK.Events;

[EventType("1844473f-d714-4327-8b7f-5b3c2bdfc26a")]
public class MenuOpened
{
    public MenuOpened (Guid userId, Guid restaurantId)
    {
        UserId = userId;
        RestaurantId = restaurantId;
    }

    public Guid UserId { get; }
    public Guid RestaurantId { get; }
}