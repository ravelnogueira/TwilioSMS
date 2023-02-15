using SMS_Twilio.Service;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

class Main1
{
    static void Main(string[] args)
    {
        Send.Execute();

        Console.WriteLine("Digite o código");

        var code1 = Console.ReadLine("Digie algo");

        Validity.ValidarSms(code1);

    }
}