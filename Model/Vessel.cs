using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Vessels.Models
{
  public class Vessel
  {
    [Key]
    public int Id { get; set; }
    [Required, MinLength(3)]
    public String Name { get; set; }
    [Required]
    [Column(TypeName = "timestamp without time zone")]
    public DateTime ArrivalDate { get; set; }
    [Required]
    [Column(TypeName = "timestamp without time zone")]
    public DateTime DepartureDate { get; set; }
    [Required, MinLength(3)]
    public String Status { get; set; }
  }
}