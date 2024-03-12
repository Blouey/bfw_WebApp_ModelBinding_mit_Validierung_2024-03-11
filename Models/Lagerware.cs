using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace bfw_WebApp_ModelBinding_mit_Validierung.Models;

public class Lagerware
{
    public int Artikelnummer { get; set; }
    
    [Required(ErrorMessage = "Bitte geben Sie die Artikelbezeichnung ein")]
    [StringLength(50, MinimumLength = 3)]
    public string? Artikelbezeichnung { get; set; }
    
    [Range(0, int.MaxValue)]
    [Required(ErrorMessage = "Bitte geben Sie den Lagerbestand ein")]
    [Display(Name = "Lagerbestand")]
    public int? Lagerbestand { get; set; }
    
    [Range(0, double.MaxValue)]
    [Required(ErrorMessage = "Bitte geben Sie den Preis ein")]
    [DataType(DataType.Currency)]
    public double? Preis { get; set; }
    
    [Display(Name = "Ist freigegeben")]
    public bool? IstFreigegeben { get; set; }
    
    [Display(Name = "Lagernd seit")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Bitte geben Sie das Datum ein")]
    [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
    public DateOnly? LagerndSeit { get; set; }
}