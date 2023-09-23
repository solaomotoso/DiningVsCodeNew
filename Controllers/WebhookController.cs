using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;
using System.Text.Unicode;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class WebhookController : ControllerBase
{
       
        CustomerRouteRepository _repCustRoute;
         
         int idvalue=0;
        public WebhookController(CustomerRouteRepository repCustRoute)
        {
            this._repCustRoute=repCustRoute;
        }
        // GET: api/Cities
        [HttpPost]
        public async Task<ActionResult<string>> PostTransaction([FromBody] Transaction payload)
        {
        //     string key="sk_test_c35634b6a8685736ba950f5dbb0492ebeb4257f9";
        //     string jsonInput = payload; //the json input
        //     string inputString = Convert.ToString(new JValue(jsonInput));
           String result = "";
        //     byte[] secretkeyBytes = System.Text.Encoding.UTF8.GetBytes(key);
        //     byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(inputString);
        //     using (var hmac = new HMACSHA512(secretkeyBytes))
        //     {
        //         byte[] hashValue = hmac.ComputeHash(inputBytes);
        //         result = BitConverter.ToString(hashValue).Replace("-", string.Empty);;
        //     }
        //       String xpaystackSignature = ""; //put in the request's header value for x-paystack-signature
        //       //hash == req.headers['x-paystack-signature']
        //       string signature = Request.Headers["SIGNATURE"];
        //       if(result.ToLower().Equals(xpaystackSignature)) {
        //   // you can trust the event, it came from paystack
        //   // respond with the http 200 response immediately before attempting to process the response
        //   //retrieve the request body, and deliver value to the customer
        //     } 
        //      else {
        //          // this isn't from Paystack, ignore it
        //           }
            return result;
         }
        
      
       
}