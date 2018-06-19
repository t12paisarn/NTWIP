using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MFOWebCoreMaster.Models;

namespace MFOWebCoreMaster.Controllers
{
    public class MisProdRoutingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new MCPContext())
            {
                var model = await context.mis_prod_routing.AsNoTracking().ToListAsync();
                model = model.OrderBy(x => x.Order_No).ThenBy(n=>n.Op_No).ToList();
               
                return View(model);
            }
            
        }  
        
    }
}