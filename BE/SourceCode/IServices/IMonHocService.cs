using SourceCode.MonHocModel;

namespace SourceCode.IServices
{
    public interface IMonHocService
    {
        IEnumerable<MonHoc> GetAllMonHocs();
        IEnumerable<MonHoc> GetMonHocsByKhoaHocID(int khoaHocID);
    }
}
