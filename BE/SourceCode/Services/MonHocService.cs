using SourceCode.DBContext;
using SourceCode.MonHocModel;
using Microsoft.EntityFrameworkCore;
using SourceCode.IServices; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SourceCode.Services
{
    public class MonHocService : IMonHocService
    {
        private readonly CourseManagementContext context;

        public MonHocService(CourseManagementContext context)
        {
            this.context = context;
        }

        public IEnumerable<MonHoc> GetAllMonHocs()
        {
            var monHocs = context.MonHoc.ToList();

            foreach (var monHoc in monHocs)
            {
                if (monHoc.MoTa == null)
                {
                    monHoc.MoTa = "Mô tả không có sẵn";
                }
            }

            return monHocs;
        }

        public IEnumerable<MonHoc> GetMonHocsByKhoaHocID(int khoaHocID)
        {
            return context.MonHoc
                .Where(m => m.KhoaHocID == khoaHocID)
                .ToList();
        }
    }
}
