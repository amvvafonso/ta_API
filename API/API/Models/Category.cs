using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Category
{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Nome da categoria
    /// </summary>
    public string Name { get; set; }
    
    /* *************************
     *   Relacionamentos 1-N   *
     ************************* */
    
    /// <summary>
    /// Lista de fotos
    /// </summary>
    public ICollection<Photography> Photographies { get; set; }
}