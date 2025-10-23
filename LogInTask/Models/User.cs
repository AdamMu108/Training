namespace LogInTask.Models
{
    public class User
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public bool IsOtpEnabled { get; set; }
        public string? StaticOtp { get; set; }
        public bool IsActive { get; set; }
    }


}