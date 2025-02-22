using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{

    public class Exploration
    {
        public Guid Id { get; set; }
        public Project Project { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public WellType WellType { get; set; }
        public ExplorationCostProfile CostProfile { get; set; } = null!;
        public ExplorationDrillingSchedule DrillingSchedule { get; set; } = null!;
        public GAndGAdminCost GAndGAdminCost { get; set; } = null!;
        public double RigMobDemob { get; set; }

    }

    public class ExplorationCostProfile : TimeSeriesCost<double>
    {
        [ForeignKey("Exploration.Id")]
        public Exploration Exploration { get; set; } = null!;
    }

    public class ExplorationDrillingSchedule : TimeSeriesSchedule
    {
        [ForeignKey("Exploration.Id")]
        public Exploration Exploration { get; set; } = null!;
    }

    public class GAndGAdminCost : TimeSeriesCost<double>
    {
        [ForeignKey("Exploration.Id")]
        public Exploration Exploration { get; set; } = null!;
    }
}
