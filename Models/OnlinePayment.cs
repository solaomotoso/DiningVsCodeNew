namespace DiningVsCodeNew.Models
{
    public class OnlinePayment
    {
         public int Id { get; set; }
         public string? TransRefNo { get; set; }
         public DateTime TransDate { get; set; }
         public int Paidby{get;set;}
         public float AmountPaid { get; set; }

    }
   
}