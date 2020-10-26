namespace WebApplication.Models
{
    public class CompanyAddedViewModel
    {
        public CompanyAddedViewModel(int numberOfCharsInName, int numberOfCharsInDescription, bool isHidden)
        {
            NumberOfCharsInName = numberOfCharsInName;
            NumberOfCharsInDescription = numberOfCharsInDescription;
            IsHidden = isHidden;
        }

        public CompanyAddedViewModel()
        {
        }

        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescription { get; set; }
        public bool IsHidden { get; set; }
    }
}