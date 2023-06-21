namespace DiningVsCodeNew
{
    public class PaymentDetails
    {
        public int id { get; set; }
         
         public string customerName  { get; set; }
         public DateTime dateEntered { get; set; }
         public string enteredBy { get; set; }

          public string voucherDescription { get; set; }
          public float amount { get; set; }
          public string custCode { get; set; }

           public Boolean served { get; set; }
           public DateTime dateServed { get; set; }
           public string servedBy { get; set; }
        public int paymentmodeid {get;set;}
        public int voucherid {get;set;}
        public int custtypeid { get; set; }
        public int unit { get; set; }
    }
    
}