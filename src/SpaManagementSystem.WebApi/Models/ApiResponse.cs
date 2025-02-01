﻿namespace SpaManagementSystem.WebApi.Models;

public class ApiResponse<T>
{
    public int Status { get; set; }
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public T? Data { get; set; }
}
