using eFaktureModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Sync
{
    public abstract class AInvoiceChangeRecord
    {
        [Key]
        public int Id { get; set; }
        public ESyncRecordStatus RecordStatus{ get; set; }
        public ESyncType SyncType { get; set; }

        public DateTime RecordedOn { get; set; }


    }
}
