using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class OrderController : ControllerBase
	{

		private readonly IOrderService _orderService;
		private readonly IBasketService _basketService;
		private readonly ILoggerService _loggerService;
		private readonly IOrderDetailService _orderDetailService;
		public OrderController(IBasketService basketService, ILoggerService loggerService, IOrderService orderService, IOrderDetailService orderDetailService)
		{
			_basketService = basketService;
			_loggerService = loggerService;
			_orderService = orderService;
			_orderDetailService = orderDetailService;
		}


		[HttpPost]
		public IActionResult CompleteOrder(Order order)
		{
			var basket = _basketService.GetAllList(order.UserDetailId).FirstOrDefault();
			Order newOrder = new Order
			{
				OrderDate = DateTime.Now,
				Phone = order.Phone,
				ShipAddress = order.ShipAddress,
				UserDetailId = order.UserDetailId
			};
			_orderService.Insert(newOrder);

			var lastOrder = _orderService.GetByUserId(newOrder.UserDetailId);

			for (int i = 0; i < basket.BasketItems.Count; i++)
			{
				OrderDetail newOrderDetail = new OrderDetail
				{
					OrderId = lastOrder.OrderId,
					Count = basket.BasketItems[i].Count,
					Price = basket.BasketItems[i].Price,
					PerfumeId = basket.BasketItems[i].PerfumeId
				};

				_orderDetailService.Insert(newOrderDetail);
			}

			basket.IsCompleted = true;
			_basketService.Update(basket);
			var result = _orderService.GetByUserId(newOrder.UserDetailId);

			_loggerService.Log(basket.UserDetail.FirstName + " " + basket.UserDetail.LastName + " isimli kullanýcý " + lastOrder.OrderId + " nolu sipariþini " + DateTime.Now + " tarihinde tamamladý.");

			return Ok(result);
		}
	}
}
