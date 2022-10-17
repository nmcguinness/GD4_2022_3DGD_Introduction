namespace GD
{
    /// <summary>
    /// Used to indicate priority (e.g. completion of objectives)
    /// </summary>
    public enum PriorityType : sbyte
    {
        //assigning explicit values here allows us to sort whatever entity (e.g. GameObjective) use this type
        Low = 0, Normal = 1, High = 2, Critical = 3
    }
}