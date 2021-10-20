using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMEIStorageService.Models
{
    public class IMEIModel
    {
        public long Id { get; set; }

        [Required]
        public string IMEI { get; set; }

        public DateTime AddedDate { get; set; }
        public string AddedInfo { get; set; }

        public DateTime? RemovedDate { get; set; }
        public string RemovedInfo { get; set; }
    }
}
