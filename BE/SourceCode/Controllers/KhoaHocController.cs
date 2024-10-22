using Microsoft.AspNetCore.Mvc;
using SourceCode.IServices;
using System;

namespace SourceCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private readonly IKhoaHocService khoaHocService;

        public KhoaHocController(IKhoaHocService khoaHocService)
        {
            this.khoaHocService = khoaHocService;
        }

        [HttpGet]
        public IActionResult GetAllKhoaHocs()
        {
            try
            {
                var khoaHocs = khoaHocService.GetAllKhoaHocs();
                return Ok(khoaHocs);
            }
            catch (Exception ex)
            {
                // Log exception here (if you have a logging framework)
                return StatusCode(500, "Đã xảy ra lỗi khi lấy danh sách khóa học.");
            }
        }
    }
}
