namespace EventEase.Services;

public class UserSessionService
{
    public string? UserName { get; private set; }
    public string? Email { get; private set; }
    public bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserName);

    public event Action? StateChanged;

    public void SetUser(string name, string email)
    {
        UserName = name;
        Email = email;
        StateChanged?.Invoke();
    }

    public void Clear()
    {
        UserName = null;
        Email = null;
        StateChanged?.Invoke();
    }
}
