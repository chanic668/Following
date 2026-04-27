using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FollowingServerDAL.Models;

[Table("Country")]
public partial class Country
{
    [Key]
    [Column("countryCode")]
    public int CountryCode { get; set; }

    [Column("countryNameHebrew")]
    [StringLength(50)]
    public string? CountryNameHebrew { get; set; }

    [Column("countryNameEnglish")]
    [StringLength(50)]
    public string? CountryNameEnglish { get; set; }

    [InverseProperty("CountryCodeNavigation")]
    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
