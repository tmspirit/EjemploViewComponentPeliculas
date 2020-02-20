using EjemploViewComponentPeliculas.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploViewComponentPeliculas.ViewComponents
{
    //Heredamos de ViewComponent
    public class MenuGenerosViewComponent: ViewComponent
    {
        RepositoryPeliculas repo;

        public MenuGenerosViewComponent(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }
        //Solo Un Task por ViewComponent
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(repo.Getgeneros());
        }
    }
}
