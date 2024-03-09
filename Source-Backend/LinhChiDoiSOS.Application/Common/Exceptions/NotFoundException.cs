﻿using System.Text.Encodings.Web;
using System.Text.Json;

public class NotFoundException : Exception
{
    public NotFoundException()
        : base()
    {
    }

    public NotFoundException(string message)
        : base(message)
    {
    }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NotFoundException(string name, object key)
        : base($"Entity \"{name}\" ({key}) was not found.")
    {
    }

    public NotFoundException(string name, object key, string message) : base(JsonSerializer.Serialize(new
    {
        DebugMessage = $"Enity {name} with Id: ({key}) was not found.",
        Message = message
    }, new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }))
    {

    }
}
