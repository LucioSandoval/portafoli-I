using Microsoft.AspNetCore.Mvc;

namespace ProyectoPeliculas.Controllers;

public class PrincipalController : Controller{

    // Ruta para la página de inicio
    [Route("")]
    public string Index(){
        return "Estae es el index.";
    }

    // Ruta para la página de proyectos
    [HttpGet("projects")]
    public IActionResult Projects()
    {
        return Content("Aquí se muestran los proyectos del portafolio.");
    }

    // Ruta para la página de contacto
    [HttpGet("contacts")]
    public IActionResult Contacts()
    {
        return Content("Puedes contactarnos en esta página.");
    }
}