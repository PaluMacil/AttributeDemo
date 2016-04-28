namespace AttributeDemo
{
    public class Session
    {
        public string User { get; set; }
        public Roles Role { get; set; }

    }

    public enum Roles
    {
        Anonymous,
        Normal,
        Admin
    };
}