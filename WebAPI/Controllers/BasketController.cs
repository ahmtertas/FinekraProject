using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class BasketController : ControllerBase
	{

		private readonly IBasketService _basketService;
		private readonly ILoggerService _loggerService;
		private readonly IUserDetailService _userDetailService;
		private readonly IBasketItemService _basketItemService;
		private readonly IPerfumeService _perfumeService;
		public BasketController(IBasketService basketService, ILoggerService loggerService, IUserDetailService userDetailService, IBasketItemService basketItemService, IPerfumeService perfumeService)
		{
			_basketService = basketService;
			_loggerService = loggerService;
			_userDetailService = userDetailService;
			_basketItemService = basketItemService;
			_perfumeService = perfumeService;
		}

		[HttpDelete]
		public IActionResult ItemDeleteFromBasket(int id)
		{
			Basket basket;
			var basketItem = _basketItemService.GetBasketItem(id);
			if (basketItem == null)
			{
				return NotFound();
			}
			else
			{
				_basketItemService.Delete(basketItem);
				basket = _basketService.GetWithSubData(basketItem.BasketId).FirstOrDefault();
				var perfumeName = _perfumeService.GetPerfume(basketItem.PerfumeId);
				_loggerService.Log(basket.UserDetail.FirstName + " " + basket.UserDetail.LastName + " isimli kullanýcý " + perfumeName.PerfumeName + " isimli parfümü " + DateTime.Now.ToString("yyyy-mm-dd  HH:mm") + " tarihinde sepetinden sildi.");
				return Ok(basket);
			}

		}

		[HttpPost]
		public IActionResult ItemAddToBasket(Basket basket)
		{
			var isThereBasket = _basketService.GetUserBasket(basket.UserDetailId);
			BasketItem basketItem = new BasketItem();

			if (isThereBasket != null)
			{
				if (basket.BasketItems.Count == 0)
				{
					return BadRequest();
				}
			}
			else
			{
				basket.CreateDate = DateTime.Now;
				_basketService.Insert(basket);
				isThereBasket = _basketService.GetUserBasket(basket.UserDetailId);
				if (isThereBasket == null) { return BadRequest(); }
			}

			basketItem.BasketId = isThereBasket.BasketId;
			basketItem.PerfumeId = basket.BasketItems[0].PerfumeId;
			basketItem.Count = basket.BasketItems[0].Count;
			basketItem.Price = basket.BasketItems[0].Price;
			_basketItemService.Insert(basketItem);

			var result = _basketService.GetWithSubData(basket.UserDetailId).FirstOrDefault();
			var perfumeName = _perfumeService.GetPerfume(basketItem.PerfumeId);

			_loggerService.Log(result.UserDetail.FirstName + " " + result.UserDetail.LastName + " isimli kullanýcý " + perfumeName.PerfumeName + " isimli parfümden " + basketItem.Count + " adet " + DateTime.Now.ToString("yyyy-mm-dd HH:mm") + " tarihinde sepetine ekledi.");

			return Ok(result);

		}

		[HttpPut]
		public IActionResult ItemUpdateToBasket(BasketItem basketItem)
		{
			Basket basket;
			if (basketItem == null)
			{
				return NotFound();
			}
			else
			{
				_basketItemService.Update(basketItem);
				basket = _basketService.GetWithSubData(basketItem.BasketId).FirstOrDefault();

			}

			var perfumeName = _perfumeService.GetPerfume(basketItem.PerfumeId);
			_loggerService.Log(basket.UserDetail.FirstName + " " + basket.UserDetail.LastName + " isimli kullanýcý " + perfumeName.PerfumeName + " isimli parfümünü " + DateTime.Now.ToString("yyyy-mm-dd  HH:mm") + " tarihinde güncelledi.");

			return Ok(basket);
		}

		[HttpGet]
		[EnableQuery]
		public IActionResult GetBasket(int userDetailId)
		{
			var userBasket = _basketService.GetUserBasket(userDetailId);
			if (userBasket == null)
			{
				return NotFound();
			}
			else
			{
				return Ok(userBasket);
			}
		}
	}
}
