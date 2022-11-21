namespace DiningVsCodeNew
{
    public class OrderedMeal
    {
        public int Id { get; set; }

        public string Guest{get;set;}
         public string MealId { get; set; }
         public string EnteredBy { get; set; }
         public float Amount { get; set; }
         public DateTime DateEntered { get; set; }
         public Boolean Active { get; set; }
         public Boolean Submitted { get; set; }
    }
}