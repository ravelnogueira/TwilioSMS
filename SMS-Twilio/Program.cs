using Twilio;
using Twilio.Rest.Verify.V2.Service;

class Example
{
    static void Main(string[] args)
    {

        string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
        string authToken = "d45488fb45bd679b77e980b3dfce1d31";

        TwilioClient.Init(accountSid, authToken);

        var verification = VerificationResource.Create(
            to: "+5521992250096",
            channel: "sms",
            pathServiceSid: "VAd8e8447abf76ebfbcdac9f65a1e2bdaf"
        );

        
        void ValidarSms()
        {

            string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
            string authToken = "d45488fb45bd679b77e980b3dfce1d31";

            TwilioClient.Init(accountSid, authToken);

            var verification = VerificationResource.Create(
                to: "+15017122661",
                channel: "sms",
                pathServiceSid: "VAd8e8447abf76ebfbcdac9f65a1e2bdaf"
            );

            Console.WriteLine(verification.AccountSid);
        }

    }
}