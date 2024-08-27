using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication7.Models;

namespace WebApplication7.Pages;

public class Create : PageModel
{
    private readonly AppMyDbContext _myDbContext;

    [BindProperty]
    public Product Product { get; set; }

    public Create(AppMyDbContext myDbContext)
    {
        _myDbContext = myDbContext;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _myDbContext.Products.Add(Product);
        _myDbContext.SaveChanges();

        return RedirectToPage("./Index");
    }
}

