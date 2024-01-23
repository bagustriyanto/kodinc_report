using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using ReportService.Helpers;
using ReportService.Models;
using ReportService.Repositories.Interfaces;

namespace ReportService.Controllers;

public class HomeController : Controller
{
    private readonly AppLogger _logger;
    private readonly IUnitOfWork unitOfWork;

    public HomeController(AppLogger logger,
    IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    [Route("history")]
    public async Task<IActionResult> GetHistory([FromForm] DataTableRequest request)
    {
        try
        {
            if (request.start == 0)
            {
                request.start = 1;
            }

            var data = await unitOfWork.historyRepository.GetByFilterList(null, request.start, request.length, default);
            BaseResponse result = new()
            {
                Data = data,
                RecordsTotal = await unitOfWork.historyRepository.GetTotal(default)
            };
            result.RecordsFiltered = result.RecordsTotal;
            return Ok(result);
        }
        catch (System.Exception ex)
        {
            _logger.Error(nameof(HomeController), ex.Message, ex);
            return StatusCode((int)HttpStatusCode.InternalServerError, ex);
        }
    }

    [HttpPut]
    [Route("history/status/{id}")]
    public async Task<IActionResult> ResetStatus(Guid id, [FromBody] ReqBody request)
    {
        try
        {
            var data = await unitOfWork.historyRepository.GetById(id);
            if (data is null)
            {
                return BadRequest(new { message = "Data not found" });
            }

            data.Status = request.status;
            unitOfWork.historyRepository.Update(data);
            await unitOfWork.Save();

            return Ok(new { message = "Update status successfully" });
        }
        catch (Exception ex)
        {
            _logger.Error(nameof(HomeController), ex.Message, ex);
            return StatusCode((int)HttpStatusCode.InternalServerError, new { message = ex.Message });
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public record DataTableRequest
    {
        public int start { get; set; }
        public int length { get; set; }
    }

    public record ReqBody
    {
        public string? status { get; set; }
    }
}
