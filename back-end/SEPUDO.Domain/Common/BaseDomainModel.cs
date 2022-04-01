
namespace SEPUDO.Domain.Common
{
    public abstract class BaseDomainModel
    {        
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
