using eFaktureModel.Api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eFaktureModel.Model.Sales
{
    [Table(nameof(SalesInvoice))]

    public class SalesInvoice : Invoice
    {



    }
}
