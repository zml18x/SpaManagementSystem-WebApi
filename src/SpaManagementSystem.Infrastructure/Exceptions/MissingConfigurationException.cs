﻿namespace SpaManagementSystem.Infrastructure.Exceptions;

public class MissingConfigurationException : Exception
{
    public MissingConfigurationException(string? message) : base(message)
    {
    }
    public MissingConfigurationException(string message, Exception innerException) : base(message, innerException)
    {
    }
}