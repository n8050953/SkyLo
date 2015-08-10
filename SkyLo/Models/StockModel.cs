using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkyLo.Models
{
  public class StockModel
  {
    [Display(Name="Stock name")]
    [Required]
    public string StockName { get; set; }

    [Display(Name="Stock type")]
    [Required]
    public string StockType { get; set; }

    [Display(Name="Initial stock level")]
    public int StockLvl { get; set; }
  }
}