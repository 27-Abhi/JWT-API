namespace JWT_API
{
    public class User
    {
        public string Username { get; set; }=   string.Empty;
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
