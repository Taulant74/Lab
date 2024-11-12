namespace backendLab.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int GuestID { get; set; }
        public string FeedbackType { get; set; }
        public string Message { get; set; }
        public DateTime FeedbackDate { get; set; }

        // Relationships
        public Guest Guest { get; set; }
    }


}
