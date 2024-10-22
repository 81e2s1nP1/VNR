using SourceCode.DBContext;
using Microsoft.EntityFrameworkCore;
using SourceCode.IServices;
using System.Collections.Generic;
using System.Linq;
using SourceCode.KhoaHocModel;
namespace SourceCode.Services
{
    public class KhoaHocService : IKhoaHocService
    {
        private readonly CourseManagementContext context;

        public KhoaHocService(CourseManagementContext context)
        {
            this.context = context;
        }

        public IEnumerable<KhoaHoc> GetAllKhoaHocs()
        {
            return context.KhoaHoc.ToList();
        }
    }
}
