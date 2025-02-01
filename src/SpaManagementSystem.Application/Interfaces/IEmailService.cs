﻿namespace SpaManagementSystem.Application.Interfaces;

public interface IEmailService
{
    public Task SendEmailAsync(string email, string subject, string message);
}