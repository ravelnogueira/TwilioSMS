using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;

namespace SMS_Twilio.Service
{
    public class Validity
    {
            public static void ValidarSms(string code)
            {
                string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
                string authToken = "d45488fb45bd679b77e980b3dfce1d31";

                TwilioClient.Init(accountSid, authToken);

                var verificationCheck = VerificationCheckResource.Create(
                    to: "+5521992250096",
                    code: code,
                    pathServiceSid: "VAd8e8447abf76ebfbcdac9f65a1e2bdaf"
                );

                Console.WriteLine(verificationCheck.Status);
            }
       
    }
}
