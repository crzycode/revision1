using System.ComponentModel.DataAnnotations;

public class Products{
    [Key]
    public int p_id {get;set;}
    public string p_name {get;set;}
    public decimal p_price { get; set; }
    public decimal p_total { get; set;}

}