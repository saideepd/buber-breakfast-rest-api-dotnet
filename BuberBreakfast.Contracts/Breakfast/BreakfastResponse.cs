namespace BuberBreakfast.Contracts.Breakfast;

public record BreakfastResponse(
    Guid id,
    string Name,
    string Descriptions,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> Savory,
    List<string> Sweet
);