namespace MediatR.Example.Requests.CreateProduct;

public class CreateProductRequest : IRequest<int>
{
    public string ProductName { get; set; }

    public CreateProductRequest(string productName)
    {
        ProductName = productName;
    }
}