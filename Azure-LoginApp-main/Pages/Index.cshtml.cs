using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public string Message { get; set; }

    public void OnPost()
    {
        if (Username == "admin" && Password == "1234")
        {
            Message = "Login Successful!";
        }
        else
        {
            Message = "Invalid Credentials!";
        }
    }
}