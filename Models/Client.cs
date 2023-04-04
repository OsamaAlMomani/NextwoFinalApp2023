using NextwoFinalApp2023.Models.shared_models;

namespace NextwoFinalApp2023.Area.Administrator.Models
{
    public class Client : CommonProp
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Img { get; set; }
    }
}
