using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Surf
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty!;
        public Project Project { get; set; } = null!;
        public SurfCostProfile CostProfile { get; set; } = null!;
        public Maturity Maturity { get; set; }
        public double InfieldPipelineSystemLength { get; set; }
        public double UmbilicalSystemLength { get; set; }
        public ArtificialLift ArtificialLift { get; set; }
        public int RiserCount { get; set; }
        public int TemplateCount { get; set; }
        public ProductionFlowline ProductionFlowline { get; set; }
    }

    public class SurfCostProfile : TimeSeriesCost<double>
    {
        [ForeignKey("Surf.Id")]
        public Surf Surf { get; set; } = null!;
    }

    public enum ProductionFlowline
    {
        Default = 999
    }
}
