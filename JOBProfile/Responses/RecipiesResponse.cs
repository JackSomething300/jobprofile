namespace JOBProfile.Responses
{
    public class RecipiesResponse
    {
        public RecipiesResponse() => Ingredients = new List<string>();

        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CookingInstructions { get; set; }
    }
}
