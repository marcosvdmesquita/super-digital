using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperDigital.API.Controllers
{
    [Route("api/operacao")]
    [ApiController]
    public class OperacaoController : ControllerBase
    {
        [HttpPost]
        [Route("transferencia")]
        public async Task<ActionResult> Transferencia([FromBody] string contaDebito, string contaCredito, decimal valorTransferencia)
        {
            return Created(string.Empty, "");
        }
    }
}