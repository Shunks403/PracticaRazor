using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication7.Models;

namespace WebApplication7.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly AppMyDbContext _myDbContext;

    public List<Product> Products { get; set; }
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public  void OnGet()
    {
        Products =  _myDbContext.Products.ToList();
    }
}