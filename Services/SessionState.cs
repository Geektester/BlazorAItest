public class SessionState
{
    public bool IsLoggedIn { get; private set; }
    public string Username { get; private set; }

    public void SetUser(string username)
    {
        Username = username;
        IsLoggedIn = true;
    }

    public void Logout()
    {
        Username = string.Empty;
        IsLoggedIn = false;
    }
}
