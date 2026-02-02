using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL.Entities;

public class User
{
    //Data Annotations
    [Key] //Xác định khóa chính
    public int UID { get; set; }
    
    [Required] //Not null
    [StringLength(250)] //Giới hạn kí tự
    public string Name { get; set; }
    
    public ICollection<Board> Boards { get; set; }
}