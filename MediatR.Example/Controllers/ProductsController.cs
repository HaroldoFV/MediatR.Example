using MediatR.Example.Requests.ChangeProductPrice;
using MediatR.Example.Requests.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Example.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(
        ILogger<ProductsController> logger,
        IMediator mediator
    )
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        var response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPut("{id:int}/price")]
    public async Task<IActionResult> AdjustPrice(
        [FromBody] Decimal price,
        [FromRoute] int id
    )
    {
        await _mediator.Send(new ChangeProductPriceRequest(id, price));
        return NoContent();
    }
}