using TranSPEiApiModGes.Application.Adminstrator.Response.Commands;
using TranSPEiApiModGes.Application.Common.Errors;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Domain.Aggregates;
using Domain.Domains;
using TranSPEiApiModGes.Application.Common.Services;
using MediatR;

namespace TranSPEiApiModGes.Application.Customers.Commands.AddAccountCredit;

public class NewCustomerAccountCommandHandler : IRequestHandler<NewCustomerAccountCommand, NewCustomerAccountResult>
{
    private readonly ICustomerRepository _customerRepository;

    public NewCustomerAccountCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<NewCustomerAccountResult> Handle(NewCustomerAccountCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Email = request.Emailaddress.ToLower(),
            Password = PasswordGenerator.RandomPassword(),
            Role = "customer",

        };
        var result = await _customerRepository.NewCustomerAccount(user,request);
        if (result is not NewCustomerAccountAggregate transferDetails)
        {
            throw new InternalServerError();
        }
        return new NewCustomerAccountResult(result);

    }
}

