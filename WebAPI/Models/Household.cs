using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("TblT_Household")]
    public class Household
    {
        [Key]
        public int HouseholdId { get; set; }

        [DisplayName("Jumlah orang dalam rumah")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int AmountPeople { get; set; }

        [DisplayName("Standmeter listrik bulan ini")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int Standmeter { get; set; }

        [DisplayName("Konsumsi gas LPG bulan ini (KG)")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int LpgConsumption { get; set; }

        [DisplayName("Standmeter listrik bulan ini (kWh)")]
        [Required(ErrorMessage = "Wajib di isi")]
        public int CityGasConsumption { get; set; }

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
    }
}

