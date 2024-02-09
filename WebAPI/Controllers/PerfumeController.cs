using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class PerfumeController : ControllerBase
	{

		private readonly IPerfumeService _perfumeService;
		private readonly ILoggerService _loggerService;
		private readonly IUserDetailService _userDetailService;
		public PerfumeController(IPerfumeService perfumeService, ILoggerService loggerService, IUserDetailService userDetailService)
		{
			_perfumeService = perfumeService;
			_loggerService = loggerService;
			_userDetailService = userDetailService;
		}

		[HttpGet]
		[EnableQuery]
		public IActionResult GetAllList()
		{
			var result = _perfumeService.GetAllList().AsQueryable();
			var userDetail = _userDetailService.GetUserDetail(1);
			_loggerService.Log(userDetail.FirstName + " " + userDetail.LastName + " isimli kullanýcý parfümleri inceliyor.");
			return Ok(result);
		}

		[HttpGet]
		[EnableQuery]
		public IActionResult GetAllListWithBrand()
		{
			var result = _perfumeService.GetAllList().Include(x => x.Brand).AsQueryable();
			var userDetail = _userDetailService.GetUserDetail(1);
			_loggerService.Log(userDetail.FirstName + " " + userDetail.LastName + " isimli kullanýcý parfümleri inceliyor.");

			return Ok(result);
		}

		[HttpGet]
		public IActionResult Startup()
		{
			string resultObje = "{ \"api\" : \"Welcome To My API Service.\"}";
			return Ok(resultObje);
		}
	}
}
