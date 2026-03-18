using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace API.Models;

/// <summary>
/// objetos a serem vendidos na loja
/// </summary>

public class Photography
{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Nome associado a fotografia
    /// </summary>
    [StringLength(50)]
    [Display(Name = "Título")]
    [Required(ErrorMessage = "Título é obrigat´roio")]
    public string Title { get; set; }
    
    /// <summary>
    /// Descricao do produto
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Ficheiro
    /// </summary>
    public string File { get; set; }
    
    /// <summary>
    /// Dia em que foi tirada
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// preco
    /// </summary>
    public decimal Price { get; set; }
   
    
    
    /* *************************
     *   Relacionamentos 1-N   *
     ************************* */
    
    [ForeignKey(nameof(Category))]
    public int CategoryFK { get; set; }

    /// <summary>
    /// Categoria a qual pertence
    /// </summary>
    [ValidateNever]
    public Category Category { get; set; } = null!;
    
    /// <summary>
    /// Lista de compras
    /// </summary>
    public ICollection<Purchase> Purchases { get; set; }
    
}