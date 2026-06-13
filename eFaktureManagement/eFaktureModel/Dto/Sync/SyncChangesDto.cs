using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Dto.Sync
{
    public class SyncChangesDto
    {
        public SyncChangesDto()
        {
            Date = DateTime.Now.AddDays(-1);
        }

        public SyncChangesDto(DateTime date)
        {
            Date = date;
        }

        public DateTime Date { get; set; }

    }
}
