namespace Authorization
{
    public static class AccountManager
    {
        public static List<AccountInfo> Acounts { get; set; } = new List<AccountInfo>();
        private static bool IsAuthorizated(AccountInfo user)
        {
            foreach (var item in Acounts)
            {
                if (user == item && item.IsAdmin && !item.IsBlock)
                {
                    user.IsAdmin = item.IsAdmin;
                    user.IsBlock = item.IsBlock;
                    return true;
                }
            }
            return false;
        }
        public static void AddAcount(AccountInfo user, AccountInfo addingAcount)
        {
            if (IsAuthorizated(user))
            {
                Add(addingAcount);
            }
        }
        private static void Add(AccountInfo acount)
        {
            Acounts.Add(acount);
        }
        public static void RemoveByUserName(AccountInfo user, string UserName)
        {
            if (IsAuthorizated(user))
            {
                Remove(Acounts.First(x => x.UserName == UserName));
            }
        }
        private static void Remove(AccountInfo acount)
        {
            Acounts.Remove(acount);
        }
        public static void UpdateByUserName(AccountInfo user, string UserName, AccountInfo updatingAcount)
        {
            if (IsAuthorizated(user))
            {
                Update(UserName, updatingAcount);
            }
        }
        private static void Update(string UserName, AccountInfo acount)
        {
            Remove(Acounts.First(x => x.UserName == UserName));
            Add(acount);
        }
        public class AccountInfo
        {
            public string UserName { get; init; }
            public string Password { get; init; }
            public bool IsAdmin { get; set; }
            public bool IsBlock { get; set; }
            public AccountInfo(string userName, string password, bool isAdmin = false, bool isBlock = false)
            {
                UserName = userName;
                Password = password;
                IsAdmin = isAdmin;
                IsBlock = isBlock;
            }

            public static bool operator ==(AccountInfo first, AccountInfo second)
            {
                return first.UserName == second.UserName && first.Password == second.Password;
            }
            public static bool operator !=(AccountInfo first, AccountInfo second)
            {
                return !(first == second);
            }
            public override bool Equals(object? obj)
            {
                if (obj == null)
                    return false;

                if (GetType() != obj.GetType())
                    return false;
                AccountInfo other = (AccountInfo)obj;
                return this == other;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override string ToString()
            {
                return $"UserName = {UserName},Password = {Password},IsAdmin = {IsAdmin}, IsBlock = {IsBlock}";
            }
        }
    }
   
}
