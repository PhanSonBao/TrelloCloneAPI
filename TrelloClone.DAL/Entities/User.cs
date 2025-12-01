using System.ComponentModel.DataAnnotations;

namespace TrelloClone.DAL;

public class User
{
    //Data Annotations
    [Key] //Xác định khóa chính
    public int Id { get; set; }
    
    [Required] //Not null
    [StringLength(250)] //Giới hạn kí tự
    public string Name { get; set; }
}