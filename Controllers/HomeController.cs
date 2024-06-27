using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Lucas S. Oliveira", "857.032.950-41", "lucas.silva@sp.senai.br", "Dino");
        Cliente cliente2 = new Cliente(02, "John Clemens", "039.618.250-09", "john.clemens@umbrella.com", "Chuchu");
        Cliente cliente3 = new Cliente(03, "Leon S. Kennedy", "800.777.920-50", "leon.scott@rpd.org", "Ash");
        Cliente cliente4 = new Cliente(04, "Ada Wong", "933.622.400-03", "ada.wong@connections.com", "Leo");
        Cliente cliente5 = new Cliente(05, "Chris Redfield", "911.702.988-00", "chris.redfield@bsaa.org", "July");

        //lista de clientes e atribuicao de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(01, "Umbrella Pets", "15.836.698/0001-57", "ubl.pets@umbrella.com");
        Fornecedor fornecedor3 = new Fornecedor(01, "RPD Pets INC", "40.810.224/0001-83", "rpd.pets@rpd.org");
        Fornecedor fornecedor4 = new Fornecedor(01, "CNC Dogs", "87.945.350/0001-09", "cnc.dogs@connections.us");
        Fornecedor fornecedor5 = new Fornecedor(01, "BSAA Dogs", "18.760.614/0001-37", "contato@bsaadogs.uk");

        //lista de fornecedores e atribuicao de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
