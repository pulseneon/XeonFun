using System.ComponentModel.DataAnnotations;

namespace XeonFun.Entites.Requests
{
    public class VideocardRequest
    {
        [Required]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; } = null; // скидка 

        [Required, MinLength(3), MaxLength(45)]
        public string Name { get; set; }
        [MinLength(3), MaxLength(1000)]
        public string? Description { get; set; }
        public string? Country { get; set; } // страна производитель
        public int? Warranty { get; set; } = 12; // гарантия товара
        public string ManufactureCode { get; set; } // код товара производетеля
        public string? Color { get; set; }
        public int Stock { get; set; } = 0;

        [Required, MinLength(3), MaxLength(35)]
        public string GraphicsProcessor { get; set; }
        [Required, MinLength(3), MaxLength(35)]
        public string Microarchitecture { get; set; }
        public int TechnicalProcess { get; set; } // число техпроцессов измеряемое в нм
        public int ChipFrequency { get; set; } // частота чипа
        public int? ChipTurboBoostFrequency { get; set; } = null; // турбобуст
        public int? ALU { get; set; } // универсальные процессоры 
        public bool? RTX { get; set; } = null; // RXT лучи
        public int? RTCores { get; set; } = null; // RT ядра
        public int? TensorKernels { get; set; } = null; // тензорные ядра
        public int MemoryCapacity { get; set; }
        public int MemoryType { get; set; }
        public int MaxMemoryBandwidth { get; set; } // макс. пропускная способность
        public int EffectiveMemoryCapacity { get; set; } // эффективная частота
        public int MemoryBusBitRate { get; set; } // разрядность шины
    }
}
