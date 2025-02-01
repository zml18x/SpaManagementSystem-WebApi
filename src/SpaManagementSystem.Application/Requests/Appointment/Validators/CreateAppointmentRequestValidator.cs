﻿using FluentValidation;
using SpaManagementSystem.Application.Common.Validation;

namespace SpaManagementSystem.Application.Requests.Appointment.Validators;

public class CreateAppointmentRequestValidator : AbstractValidator<CreateAppointmentRequest>
{
    public CreateAppointmentRequestValidator()
    {
        RuleFor(x => x.SalonId)
            .ValidateId("SalonId");
        
        RuleFor(x => x.EmployeeId)
            .ValidateId("EmployeeId");
        
        RuleFor(x => x.CustomerId)
            .ValidateId("CustomerId");
        
        RuleFor(x => x.Date)
            .NotEmpty().WithMessage("Date is required.")
            .Must(d => d >= DateOnly.FromDateTime(DateTime.Now))
            .WithMessage("Date cannot be in the past.");

        RuleFor(x => x.StartTime)
            .NotEmpty().WithMessage("StartTime is required.")
            .Must((request, startTime) => startTime < request.EndTime)
            .WithMessage("StartTime must be earlier than EndTime.");

        RuleFor(x => x.EndTime)
            .NotEmpty().WithMessage("EndTime is required.")
            .Must((request, endTime) => endTime > request.StartTime)
            .WithMessage("EndTime must be later than StartTime.");

        RuleFor(x => x.Services)
            .NotEmpty().WithMessage("Services collection is required.")
            .Must(s => s.Any()).WithMessage("At least one service must be provided.")
            .ForEach(serviceRule =>
            {
                serviceRule.SetValidator(new CreateAppointmentServiceRequestValidator());
            });
        
        When(x => !string.IsNullOrEmpty(x.Notes), () =>
        {
            RuleFor(x => x.Notes!)
                .MaximumLength(500).WithMessage("Notes cannot be longer than 500 characters");
        });
    }
}