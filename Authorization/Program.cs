using Authorization;

AccountManager.Acounts = new List<AccountManager.AccountInfo>() {
        new AccountManager.AccountInfo("1", "1", true),
        new AccountManager.AccountInfo("2", "2"),
        new AccountManager.AccountInfo("3", "3", false, true)
    };
Console.WriteLine("User:");
Console.Write("Input User Name : ");
string UserName = Console.ReadLine();
Console.Write("Input Password : ");
string Password = Console.ReadLine();
AccountManager.AccountInfo user = new AccountManager.AccountInfo(UserName, Password);
Console.WriteLine("All Accounts");
Console.WriteLine("__________________________");
foreach (var item in AccountManager.Acounts)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("--------------------------");
Console.WriteLine("Update Account");
Console.WriteLine("__________________________");
Console.Write("Input updating User Name ");
UserName = Console.ReadLine();
Console.Write("Input  new User Name : ");
string NewUserName = Console.ReadLine();
Console.Write("Input new Password : ");
string NewPassword = Console.ReadLine();
Console.Write("Input  new admin property : ");
bool IsAdmin = Convert.ToBoolean(Console.ReadLine());
Console.Write("Input  new block property : ");
bool IsBlock = Convert.ToBoolean(Console.ReadLine());
AccountManager.UpdateByUserName(user, UserName, new AccountManager.AccountInfo(NewUserName, NewPassword,IsAdmin,IsBlock));
Console.WriteLine("--------------------------");
Console.WriteLine("All Accounts");
Console.WriteLine("__________________________");
foreach (var item in AccountManager.Acounts)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("--------------------------");
Console.WriteLine("Add new Account");
Console.WriteLine("__________________________");
Console.Write("Input  new User Name : ");
NewUserName = Console.ReadLine();
Console.Write("Input new Password : ");
NewPassword = Console.ReadLine();
Console.Write("Input  new admin property : ");
IsAdmin = Convert.ToBoolean(Console.ReadLine());
Console.Write("Input  new block property : ");
IsBlock = Convert.ToBoolean(Console.ReadLine());
AccountManager.AddAcount(user, new AccountManager.AccountInfo(NewUserName, NewPassword, IsAdmin, IsBlock));
Console.WriteLine("--------------------------");
Console.WriteLine("All Accounts");
Console.WriteLine("__________________________");
foreach (var item in AccountManager.Acounts)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("--------------------------");
Console.WriteLine("Remove Account");
Console.WriteLine("__________________________");
Console.Write("Input removing account User Name ");
UserName = Console.ReadLine();
AccountManager.RemoveByUserName(user, UserName);
Console.WriteLine("--------------------------");
Console.WriteLine("All Accounts");
Console.WriteLine("__________________________");
foreach (var item in AccountManager.Acounts)
{
    Console.WriteLine(item.ToString());
}