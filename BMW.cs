using System.Net.Mail;

public class BMW : BaseCar, IEmailSendable, IMultipleEmailSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }

    public void SendTripInfoEmailToDriver(DriverInfo driver)
    {
        if(!string.IsNullOrEmpty(driver.EmailAddress))
        {
            var mailMessage = new MailMessage();
            mailMessage.To.Add(driver.EmailAddress);

            var client = new SmtpClient("mail.bmw.com", 587);
            client.Send(mailMessage);
        }
    }

    public void SendTripInfoEmailToDrivers(List<DriverInfo> drivers)
    {
        foreach (var item in drivers)
        {
            SendTripInfoEmailToDriver(item);
        }
    }
}