namespace Hummer.Fly.Custom
{
    public class UserRepository : IUserRepository
    {
        public bool ValidateLastChanged(string lastChanged)
        {
            if (int.TryParse(lastChanged, out int result))
            {
                if (result < 58)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
