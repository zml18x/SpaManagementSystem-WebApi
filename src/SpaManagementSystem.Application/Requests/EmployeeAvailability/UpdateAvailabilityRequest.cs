﻿namespace SpaManagementSystem.Application.Requests.EmployeeAvailability;

public record UpdateAvailabilityRequest(DateOnly Date, IEnumerable<AvailabilityHoursRequest> AvailabilityHours);