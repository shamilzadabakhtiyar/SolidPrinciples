using System.Net.Mail;

public class MercedesBenz: BaseCar, ISmsSendable, IEmailSendable
{
    public override double GetCostPerKM()
    {
        return 2;
    }

    public void Go()
    {
        System.Console.WriteLine("Car is now going...");
    }

    public void Stop()
    {
        System.Console.WriteLine("Car has stoped...");
    }

    public void SendTripInfoEmailToDriver(DriverInfo driver)
    {
        if(!string.IsNullOrEmpty(driver.EmailAddress))
        {
            var mailMessage = new MailMessage();
            mailMessage.To.Add(driver.EmailAddress);

            var client = new SmtpClient("mail.mercedes.com", 587);
            client.Send(mailMessage);
        }
    }

    public void SendTripInfoSmsToDriver(DriverInfo driver)
    {
        if(!string.IsNullOrEmpty(driver.PhoneNumber))
        {
            var smsSender = new SmsSender();
            smsSender.SendSms(new SmsModel()
            {
                Message = "Todays trip",
                PhoneNumber = driver.PhoneNumber,
                SendTime = DateTime.Now
            });
        }
    }
}