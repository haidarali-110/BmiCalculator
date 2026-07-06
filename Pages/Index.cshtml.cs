using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BmiCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Age is required")]
        [Range(1, 120, ErrorMessage = "Enter a valid age")]
        public int? Age { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please select a gender")]
        public string? Gender { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Height is required")]
        [Range(1, 300, ErrorMessage = "Enter a valid height in cm")]
        public double? HeightCm { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Weight is required")]
        [Range(1, 500, ErrorMessage = "Enter a valid weight in kg")]
        public double? WeightKg { get; set; }

        public double? Bmi { get; private set; }
        public string? Classification { get; private set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid || HeightCm is null || WeightKg is null)
            {
                return;
            }

            double heightM = HeightCm.Value / 100.0;
            Bmi = Math.Round(WeightKg.Value / (heightM * heightM), 2);
            Classification = ClassifyBmi(Bmi.Value);
        }

        private static string ClassifyBmi(double bmi)
        {
            return bmi switch
            {
                < 16 => "Severe Thinness",
                < 17 => "Moderate Thinness",
                < 18.5 => "Mild Thinness",
                < 25 => "Normal",
                < 30 => "Overweight",
                < 35 => "Obese Class I",
                < 40 => "Obese Class II",
                _ => "Obese Class III"
            };
        }
    }
}