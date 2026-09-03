using eFaktureModel.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eFaktureModel.Model.Sync
{
    public abstract class AInvoiceChangeRecord<T, K>
    {
        [Key]
        public int Id { get; set; }
        public ESyncRecordStatus RecordStatus{ get; set; }
        public ESyncType SyncType { get; set; }

        public DateTime RecordedOn { get; set; }

        public K ChangeId { get; set; } 

        [ForeignKey(nameof(ChangeId))]
        public T? Change { get; set; }  

    }
}
