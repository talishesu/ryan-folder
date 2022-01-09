using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ryan.Models.DataContexts;
using ryan.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ryan.Models.ViewModels
{
    public class InfoViewComponent : ViewComponent
    {
        readonly RyanDbContext db;
        public InfoViewComponent(RyanDbContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            InfoViewModel vm = new InfoViewModel();
            vm.InfoLayout = await db.InfoLayout.FirstOrDefaultAsync();
            vm.InfoLayoutJob = await db.InfoLayoutJob.ToListAsync();

            return View(vm);
        }
    }
}
