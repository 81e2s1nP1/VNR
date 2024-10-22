using SourceCode.KhoaHocModel;

namespace SourceCode.MonHocModel
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMonHoc { get; set; }
        public string MoTa { get; set; }
        public int KhoaHocID { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
    }

}
