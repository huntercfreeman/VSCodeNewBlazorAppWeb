using System.ComponentModel.DataAnnotations;

namespace BlazorExtensionWeb.Code
{
    public class NewBlazorApp
    {
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string SolutionName { get; set; }
        public bool SolutionProjectSameDirectory { get; set; }
    }

}