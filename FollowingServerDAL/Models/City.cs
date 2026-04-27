using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingServerDAL.Models;

[Table("City")]
public partial class City
{
    [Key]
    [Column("cityCode")]
    public int CityCode { get; set; }

    [Column("countryCode")]
    public int? CountryCode { get; set; }

    [Column("cityNameHebrew")]
    [StringLength(50)]
    public string? CityNameHebrew { get; set; }

    [Column("cityNameEnglish")]
    [StringLength(50)]
    public string? CityNameEnglish { get; set; }

    [ForeignKey("CountryCode")]
    [InverseProperty("Cities")]
    public virtual Country? CountryCodeNavigation { get; set; }
}
