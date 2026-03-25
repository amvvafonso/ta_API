using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class MyUser
{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Nome do user
    /// </summary>
    [Required]
    public string Name { get; set; }
    
    /// <summary>
    /// Morada do user
    /// </summary>
    public string? Address { get; set; }
    
    /// <summary>
    /// Codigo postal
    /// </summary>
    public string? PostalCode { get; set; }
    
    /// <summary>
    /// País
    /// </summary>
    public string? Country { get; set; }
    
    /// <summary>
    /// Numero de contribuinte
    /// </summary>
    public string? TaxNumber { get; set; }
    
    /// <summary>
    /// Numero de telemovel
    /// </summary>
    public string? Cellphone { get; set; }
    
    
    /* ************************* 
     *   Relacionamentos 1-N   *
     ************************* */

    /// <summary>
    /// Lista de compras
    /// </summary>
    public ICollection<Purchase> Purchases { get; set; } = [];
}