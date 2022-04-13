namespace VUK_Manager.Models
{
    public class ReportModel
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool TwoSlings { get; set; }
        public string SlingsConfigText { get; set; }
        public int BottomConfigIndex { get; set; }
        public string BottomConfigText { get; set; }
        public int TopConfigIndex { get; set; }
        public string TopConfigText { get; set; }
        public int DensityCloth { get; set; }
        public int DensityBottom { get; set; }
        public int DensityTop { get; set; }
        public int ClothPrice { get; set; }
        public double ThreadPrice { get; set; }
        public double SlingLength { get; set; }
    }
}
