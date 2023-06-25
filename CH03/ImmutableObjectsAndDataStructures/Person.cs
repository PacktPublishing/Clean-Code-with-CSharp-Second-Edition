using System;

namespace CH3.ImmutableObjectsAndDataStructures;

public struct Person

{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(int id, string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName))
            throw new ArgumentException($"'{nameof(firstName)}' cannot be null or empty.", nameof(firstName));
        
        if (string.IsNullOrEmpty(lastName))
            throw new ArgumentException($"'{nameof(lastName)}' cannot be null or empty.", nameof(lastName));

        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}