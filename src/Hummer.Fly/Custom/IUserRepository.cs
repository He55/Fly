namespace Hummer.Fly.Custom
{
    public interface IUserRepository
    {
        bool ValidateLastChanged(string lastChanged);
    }
}
