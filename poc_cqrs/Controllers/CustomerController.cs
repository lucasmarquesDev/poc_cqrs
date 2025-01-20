using MediatR;
using Microsoft.AspNetCore.Mvc;
using poc_cqrs.Application.UseCases.CreateCustomerCommand;
using poc_cqrs.Application.UseCases.DeleteCustomerCommand;
using poc_cqrs.Application.UseCases.GetAllCustomerQuery;
using poc_cqrs.Application.UseCases.GetByIdCustomerQuery;
using System.Runtime.CompilerServices;

namespace poc_cqrs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IMediator _mediator;

        public CustomerController(ILogger<CustomerController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("{customerId}")]
        public ActionResult<GetByIdCustomerResponse> GetById([FromRoute] int customerId)
        {
            var customer = _mediator.Send(new GetByIdCustomerQuery(customerId)).Result;

            return customer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetAllCustomerResponse>> GetAll()
        {
            var result = _mediator.Send(new GetAllCustomerQuery()).Result;

            return result;
        }

        [HttpPost(Name = "Create")]
        public bool Create([FromBody] CreateCustomerCommand command)
        {
            var resul = _mediator.Send(new CreateCustomerCommand(command.CustomerId, command.CompanyName, command.Phone, command.Country, command.City, command.Region, command.Address, command.Name)).Result;

            return resul.Integration;
        }

        [HttpDelete(Name = "Delete")]
        public bool Delete([FromHeader] int customerId)
        {
            var resul = _mediator.Send(new DeleteCustomerCommand(customerId)).Result;

            return resul.Integration;
        }
    }
}
