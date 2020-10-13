using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ASP_SHOP.Models
{

    public enum SortState
    {
        [Display(Name= "By name (ascending)")]
        TitleAsc,    // по названию по возрастанию
        [Display(Name = "By name (descending)")]
        TitleDesc,   // по названию по убыванию
        [Display(Name = "By price (ascending)")]
        PriceAsc,    // по цене по возрастанию
        [Display(Name = "By price (descending)")]
        PriceDesc,   // по цене по убыванию
    }

    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }

    public class SortInfo
    {
        // сортировка товаров
        public SortState Current { get; private set; }     // текущее значение сортировки

        public SortInfo(SortState sortOrder)
        {
            Current = sortOrder;
        }
    }
}