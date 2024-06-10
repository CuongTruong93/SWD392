using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWD392_Group3_Project.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SWD392_Group3_Project.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserRepository _userRepository;
        public LoginModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [BindProperty]
        [Required]
        public string Username { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = _userRepository.Authenticate(Username, Password);
            if (user == null)
            {
                ErrorMessage = "Invalid username or password";
                return Page();
            }

            return RedirectToPage("/AdminDashboard");
        }
    }
}
