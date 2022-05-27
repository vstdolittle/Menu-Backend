// DishHandler.cs
using Dolittle.SDK.Events;
using Dolittle.SDK.Events.Handling;
using Microsoft.Extensions.Logging;

[EventHandler("f2d366cf-c00a-4479-acc4-851e04b6fbba")]
public class MenuHandler
{
    readonly ILogger _logger;

    public MenuHandler(ILogger<MenuHandler> logger)
    {
        _logger = logger;
    }

    public void Handle(MenuOpened @event, EventContext eventContext)
    {
        _logger.LogInformation("{Chef} has prepared {Dish}. Yummm!", @event.UserId, @event.RestaurantId);
    }
}