using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Reference
{
    public enum InvoiceWorkStatus
    {
        UNASSIGNED,
        ERROR,
        STORNO,
        ASSIGNED,
        APPROVED,
        BOOKED,
    }
}
