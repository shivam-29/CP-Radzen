using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Shared.Helpers;
public class PagingParameters
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;

    public int Take { get; set; } = 10;

    public int Skip { get; set; } = 0;
}