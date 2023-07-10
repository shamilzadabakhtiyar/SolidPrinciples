using System.Net.Mail;

public abstract class BaseCar
{
    public int TripKM { get; set; }

    public abstract double GetCostPerKM();

    // public void SendTripInfoEmailToDriver(DriverInfo driver)
    // {
    //     if(!string.IsNullOrEmpty(driver.EmailAddress))
    //     {
    //         var mailMessage = new MailMessage();
    //         mailMessage.To.Add(driver.EmailAddress);

    //         var client = new SmtpClient("mail.mercedes.com", 587);
    //         client.Send(mailMessage);
    //     }
    // }

    // public void SendTripInfoSmsToDriver(DriverInfo driver)
    // {
    //     if(!string.IsNullOrEmpty(driver.PhoneNumber))
    //     {
    //         var smsSender = new SmsSender();
    //         smsSender.SendSms(new SmsModel()
    //         {
    //             Message = "Todays trip",
    //             PhoneNumber = driver.PhoneNumber,
    //             SendTime = DateTime.Now
    //         });
    //     }
    // }
}