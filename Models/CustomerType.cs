namespace DiningVsCodeNew
{
    public class CustomerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CustomerRoute> customerRoute { get; set; } =new List<CustomerRoute>();
    }
   

}