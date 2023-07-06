using DiningVsCodeNew.Models;

namespace DiningVsCodeNew
{

    public class Served
{
    public int Id { get; set; }
    public PaymentMain paymentMain { get; set; }
    public DateTime Dateserved { get; set; }
    public int ServedBy { get; set; }
}

}