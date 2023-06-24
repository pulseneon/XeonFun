using System;

namespace XeonFun.Entites.Models.Products
{
    public class Videocard: Product
    {
        public string GraphicsProcessor { get; set; }
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
