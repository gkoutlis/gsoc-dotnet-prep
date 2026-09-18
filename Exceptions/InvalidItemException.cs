using System;
using System.ComponentModel.DataAnnotations;

public class InvalidItemException : Exception
{
    public string? ParaName { get; private set; }
    
    public InvalidItemException(string message)
        : base(message)
    {
    }

    public InvalidItemException(string message, string? paraName)
    : base(message)
    {
        ParaName = paraName;
    }
}