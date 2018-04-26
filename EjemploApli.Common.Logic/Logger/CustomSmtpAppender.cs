namespace EjemploApi.Common.Logic.Logger
{
    public class CustomSmtpAppender : log4net.Appender.SmtpAppender
    {
        protected override void SendEmail(string messageBody)
        {
            base.SendEmail(messageBody);
        }
    }
}