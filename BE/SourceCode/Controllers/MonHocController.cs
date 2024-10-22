using Microsoft.AspNetCore.Mvc;
using SourceCode.IServices;
using System.Linq;

namespace SourceCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly IMonHocService monHocService;

        public MonHocController(IMonHocService monHocService)
        {
            this.monHocService = monHocService;
        }

        [HttpGet]
        public IActionResult GetAllMonHocs()
        {
            try
            {
                var monHocs = monHocService.GetAllMonHocs();
                return Ok(monHocs);
            }
            catch (Exception ex)
            {
                // Log exception here (if you have a logging framework)
                return StatusCode(500, "Đã xảy ra lỗi khi lấy danh sách môn học.");
            }
        }

        [HttpGet("{khoaHocID}")]
        public IActionResult GetMonHocsByKhoaHocID(int khoaHocID)
        {
            try
            {
                var monHocs = monHocService.GetMonHocsByKhoaHocID(khoaHocID);
                if (monHocs == null || !monHocs.Any())
                {
                    return NotFound("Không tìm thấy môn học cho khóa học này.");
                }
                return Ok(monHocs);
            }
            catch (Exception ex)
            {
                // Log exception here (if you have a logging framework)
                return StatusCode(500, "Đã xảy ra lỗi khi lấy danh sách môn học cho khóa học này.");
            }
        }
    }
}
