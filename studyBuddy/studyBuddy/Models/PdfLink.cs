namespace studyBuddy.Models
{
    public class PdfLink
    {

        public int Id { get; set; }

        public int PdfId { get; set; }

        public string FileName { get; set; }

        public virtual Pdf Pdf { get; set; }

    }
}
