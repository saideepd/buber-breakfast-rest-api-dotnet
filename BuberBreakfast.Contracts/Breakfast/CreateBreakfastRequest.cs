namespace BuberBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
    string Name,
    string Descriptions,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);