using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BucksNewUniversity.Data;
using BucksNewUniversity.Models;

namespace BucksNewUniversity.Pages.Students
{
  public class IndexModel : PageModel
  {
    private readonly BucksNewUniversity.Data.SchoolContext _context;

    public IndexModel(BucksNewUniversity.Data.SchoolContext context)
    {
      _context = context;
    }

    public string NameSort { get; set; }
    public string DateSort { get; set; }
    public string CurrentFilter { get; set; }
    public string CurrentSort { get; set; }

    public PaginatedList<Student> Students { get; set; }

    public async Task OnGetAsync(string sortOrder,
        string currentFilter, string searchString, int? pageIndex)
    {
      CurrentSort = sortOrder;

      NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
      DateSort = sortOrder == "Date" ? "date_desc" : "Date";

      if (searchString != null)
      {
        pageIndex = 1;
      }
      else
      {
        searchString = currentFilter;
      }

      CurrentFilter = searchString;

      IQueryable<Student> studentIQ = from s in _context.Students
                                      select s;

      if (!String.IsNullOrEmpty(searchString))
      {
        studentIQ = studentIQ.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper())
                               || s.FirstMidName.ToUpper().Contains(searchString.ToUpper()));
      }

      switch (sortOrder)
      {
        case "name_desc":
          studentIQ = studentIQ.OrderByDescending(s => s.LastName);
          break;
        case "Date":
          studentIQ = studentIQ.OrderBy(s => s.EnrollmentDate);
          break;
        case "date_desc":
          studentIQ = studentIQ.OrderByDescending(s => s.EnrollmentDate);
          break;
        default:
          studentIQ = studentIQ.OrderBy(s => s.LastName);
          break;
      }

      int pageSize = 10;
      Students = await PaginatedList<Student>.CreateAsync(
          studentIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
    }
  }
}
