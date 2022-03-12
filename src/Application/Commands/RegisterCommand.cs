using Application.Common;
using Domain.Common;
using MediatR;

namespace Application.Commands;

public class RegisterCommand : IRequest<Result>
{
    public string? Name { get; set; }
    public string? Nickname { get; set; }
    public Gender Gender { get; set; }
}