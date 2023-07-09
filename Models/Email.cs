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
                                        "<img src='"+logourl+"' style='width: 20px;'>" +
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

//         public string emailcontent(string narration, string RedirectUrl, string salutation,
//                             string emailfromsystem, string narration1, string narration2, 
//                                  string narration3, string narration4)
//                 {
//             string htmlBody  = "<body style='font-family: Arial, sans-serif;background-color: #ffffff;color: #333333;'>" +
// "<table style='width: 100%;'><tr><td style='font-size: 14pt;font-weight: normal; height:9px; vertical-align:text-top;'></td>" +
// "</tr></table></td> </tr>" +
// "<tr><td colspan='4'></td> </tr><tr><td colspan='4'></td> </tr> " +
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>" + salutation + "</td><td colspan='3' style='font-family:Century Gothic; font-size:14pt'></td> </tr>" +
// "<tr><td colspan='4' style='font-family:Century Gothic; font-size:14pt'></td> </tr>" +
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>" + emailfromsystem + "</td><td colspan='3' style='font-family:Century Gothic; font-size:14pt'></td> </tr>" +
// "<tr><td>&nbsp;</td><td colspan='3'></td></tr><tr><td style='font-family:Century Gothic; font-size:14pt'></td><td style='font-family:Century Gothic; font-size:14pt' colspan='3'>" +
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>" + narration + "</td><td colspan='3' style='font-family:Century Gothic; font-size:14pt'></td> </tr>" +
// "<tr><td>&nbsp;</td><td colspan='3'></td></tr><tr><td style='font-family:Century Gothic; font-size:14pt'><b> PS. </b>  <a href='" + RedirectUrl + "'>Link </a> for further action.</td><td style='font-family:Century Gothic; font-size:14pt' colspan='3'>" +
// "</td></tr> " +
// "<tr><td>&nbsp;</td><td colspan='3'> &nbsp;</td></tr>" +
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>Regards,</td><td>&nbsp;</td></tr>" +
// "<tr><td style='font-family:Century Gothic; font-size:14pt'> Mail Administrator</td><td>&nbsp;</td></tr> </table>";
           

//        return htmlBody;

//        }

 
//         Public Function HtmlMailrequest(ByVal narration As String, ByVal RedirectUrl As String) As String
//             Dim htmlBody As String = "<table><tr><td colspan='4' style='font-family: Arial;font-weight: bold; font-style: italic; font-size: 35pt;color: #FF0000;'>" &
// "<table style='width: 100%;'><tr><td style='font-size: 10pt;font-weight: normal; height:9px; vertical-align:text-top;'></td>" &
// "</tr></table></td> </tr>" &
// "<tr><td colspan='4'></td></tr> " &
// "<tr><td colspan='4'></td> </tr><tr><td colspan='4'></td> </tr> " &
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>" & narration & "</td><td colspan='3' style='font-family:Century Gothic; font-size:14pt'></td> </tr>" &
// "</td></tr> " &
// "<tr><td>&nbsp;</td><td colspan='3'> &nbsp;</td></tr>" &
// "<tr><td style='font-family:Century Gothic; font-size:14pt'>Regards,</td><td>&nbsp;</td></tr>" &
// "<tr><td style='font-family:Century Gothic; font-size:14pt'> Application Manager.</td></tr>" &
// "</td> </tr></table>"
//             Return htmlBody

//         End Function
    }
   
}