using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_SHOP.Models
{

    public enum SortState
    {
        TitleAsc,    // по названию по возрастанию
        TitleDesc,   // по названию по убыванию
        PriceAsc,    // по цене по возрастанию
        PriceDesc,   // по цене по убыванию
    }

    public class SortInfo
    {
        public SortState Current { get; private set; }     // текущее значение сортировки

        public SortInfo(SortState sortOrder)
        {

            Current = sortOrder;
        }
    }
}