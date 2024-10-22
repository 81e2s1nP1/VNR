using SourceCode.MonHocModel;

namespace SourceCode.KhoaHocModel
{
    public class KhoaHoc
    {
        public int ID { get; set; }
        public string TenKhoaHoc { get; set; }
        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }

}
