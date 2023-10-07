namespace DiningVsCodeNew
{
    public class Email
    {
         public string firstName { get; set; }
         
        public string HtmlMail(string narration, string applink, string salutation,
                            string emailfromsystem, string narration1, string logourl)
                                 
                {
                     string htmlBody  = "<table><tr><td colspan='4' style='font-family: Century Gothic;font-weight: bold; font-style: italic; font-size: 14pt;color: #FF0000;'>" +
                                        "<div style='max-width: 600px;margin: 0 auto;padding: 20px;'>" +
                                        "<div style='text-align: center;margin-bottom: 20px;'>" +
                                        "<img src='"+logourl+"' style='width: 150px;'>" +
                                        "</div>"+
                                        "<h1 style='color: #004085;text-align: center;font-size: 24px;margin-top: 0;'>"+narration+"</h1>"+
                                        "<div style='padding: 20px;background-color: #f8f9fa;border-radius: 5px;'>"+
                                        "<p style='color: #333333;margin-bottom: 10px;'>"+salutation+"</p>"+
                                        "<p style='color: #333333;margin-bottom: 10px;'>"+emailfromsystem+"</p>"+
                                        "<p>"+narration1+"</p>" +
                                         "</div>"+
                                        "<a href="+"https://example.com"+ "'style='display: inline-block;margin-top: 20px;padding: 10px 20px;background-color: #007bff;color: #ffffff;text-decoration: none;border-radius: 5px;'>"+applink+"</a>"+
                                        "</div>"+
                                        "</body>";
                                         return htmlBody;

                 }


    }
   
}