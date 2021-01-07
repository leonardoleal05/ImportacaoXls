using System.Collections.Generic;
using ImportacaoXlsApi.Controllers.Generics;
using ImportacaoXlsApi.Infraestutura.Notification;
using ImportacaoXlsApi.Models;
using ImportacaoXlsApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Text;
using System.IO;

namespace ImportacaoXlsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImportacaoController : BaseController
    {
        private readonly ImportacaoService _service;

        public ImportacaoController(INotification notification, ImportacaoService service) : base(notification)
        {
            this._service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Importacao>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Importacao> Get(int id)
        {
            var planilha = _service.Get(id);
            if (planilha != null)
                return Ok(planilha);
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Importacao> UploadFile(Stream fileStream)
        {
            var importacoes = _service.UploadFile(fileStream);

            return Ok(importacoes);
        }
    }
}
