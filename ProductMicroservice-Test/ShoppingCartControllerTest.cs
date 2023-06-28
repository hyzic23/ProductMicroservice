// using ProductMicroservice.Controllers;
// using ProductMicroservice.IRepository;


// namespace ProductMicroservice_Test;

// public class ShoppingCartControllerTest
// {
//     private readonly ShoppingCartController _controller;
//     private readonly IShoppingCartService _service;
//     public ShoppingCartControllerTest()
//     {
//         _service = new ShoppingCartServiceFake();
//         _controller = new ShoppingCartController();
//     }

//     [Fact]
//     public void Get_WhenCalled_ReturnsOkResult()
//     {
//         // Act
//         var okResult = _controller.Get();
//         // Assert
//         Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
//     }

//     [Fact]
//     public void Get_WhenCalled_ReturnsAllItems()
//     {
//         // Act
//         var okResult = _controller.Get() as OkObjectResult;
//         // Assert
//         var items = Assert.IsType<List<ShoppingItem>>(okResult.Value);
//         Assert.Equal(3, items.Count);
//     }
// }