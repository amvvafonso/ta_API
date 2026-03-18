using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public class Purchase
{
    /// <summary>
    /// PK
    /// </summary>
    [Key]
    public int Id { get; set; }
    
    /// <summary>
    /// Data da compra
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Estado da compra
    /// </summary>
    public State State { get; set; }
  
    
    
    
    /* *************************
     *   Relacionamentos 1-N   *
     ************************* */

    /// <summary>
    /// Chave estrangeira para o utilizador
    /// </summary>
    [ForeignKey(nameof(Buyer))]
    public int BuyerFK { get; set; }
    
    /// <summary>
    /// Utilizador associado a compra
    /// </summary>
    /// 
    public MyUser Buyer { get; set; }
    
    
    /* *************************
     *   Relacionamentos N-M   *
     ************************* */
    
    /// <summary>
    /// Lista de fotografias associado as compras
    /// </summary>
    public ICollection<Photography> Photographies { get; set; }

}

public enum State
{
    Pending,
    Paid,
    Sent,
    Delivered,
    Closed
}