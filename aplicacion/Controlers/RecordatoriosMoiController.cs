using aplicacion.Models;
using Microsoft.AspNetCore.Mvc;

namespace aplicacion.Controllers;

public class RecordatoriosMoiController : Controller
{
    // Datos de ejemplo (después se conectará a BD)
    private static List<RecordatorioMoi> _recordatorios = new()
    {
        new RecordatorioMoi { Id = 1, Titulo = "Reunión con equipo", Descripcion = "Reunión de trabajo", FechaHora = DateTime.Now.AddHours(2) },
        new RecordatorioMoi { Id = 2, Titulo = "Entregar reporte", Descripcion = "Entregar reporte", FechaHora = DateTime.Now.AddDays(1) },
        new RecordatorioMoi { Id = 3, Titulo = "Llamada con cliente", Descripcion = "Llamada con cliente", FechaHora = DateTime.Now.AddHours(5) }
    };

    public IActionResult IndexMoi()
    {
        var lista = _recordatorios.OrderBy(r => r.FechaHora).ToList();
        return View(lista);
    }

    public IActionResult GetLista()
    {
        var lista = _recordatorios.OrderBy(r => r.FechaHora).ToList();
        return PartialView("ListaRecordatorios", lista);
    }
}