using lab07.Models.Movies;
using Microsoft.AspNetCore.Mvc;

namespace lab07.Controllers;

[ApiController]
public class ApiCompaniesController(MoviesContext context): ControllerBase
{

    [HttpGet("api/companies")]
    public List<ProductionCompany> GetCompanies(string filter)
    {
        return context
            .ProductionCompanies
            .Where(c => c.CompanyName.ToLower().Contains(filter.ToLower()))
            .ToList();
    }
}