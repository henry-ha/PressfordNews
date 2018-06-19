namespace Interfaces
{
    public interface IUser
    {
        string ConnectionString { get; set; }
        int UserID { get; }
        bool IsPublisher { get; set; }
    }
}