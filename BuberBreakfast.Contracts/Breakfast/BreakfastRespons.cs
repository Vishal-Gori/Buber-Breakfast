namespace BubbleBreakfast.Contracts.Breakfast;

public record BreakfastREsponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDdateTime,
    List<string> Savory,
    List<string> sweets);