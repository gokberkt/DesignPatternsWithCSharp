namespace BuilderPatternExample.Models
{
    public class EmailMessage
    {
        public string From { get; set; } = "";
        public string To { get; set; } = "";
        public string Subject { get; set; } = "";
        public string Body { get; set; } = "";
        public List<string> Cc { get; set; } = new();
        public List<string> Bcc { get; set; } = new();
        public List<string> Attachments { get; set; } = new();

        public void Send()
        {
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"To: {To}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Cc: {string.Join(", ", Cc)}");
            Console.WriteLine($"Bcc: {string.Join(", ", Bcc)}");
            Console.WriteLine($"Attachments: {string.Join(", ", Attachments)}");

            Console.WriteLine("\n E-posta gönderildi!");
        }
    }
}
