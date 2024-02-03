namespace BubbleBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequests(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> sweets);