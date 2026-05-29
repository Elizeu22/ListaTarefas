using Microsoft.AspNetCore.Mvc;
using TodoApi.Service;
using TodoApi.Models;
using TodoApi.Persistencia;

namespace TodoApi.Controllers
{
    public class TarefaController : Controller
    {
        private TarefaServico servicoTarefa = new TarefaServico();


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Selecionar()
        {
            var tarefas = servicoTarefa.Tarefas();
            return Ok(tarefas);
        }


        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Gravar(Tarefa tarefas)
        {
            servicoTarefa.Gravar(tarefas);
            return Ok(tarefas);
        }



        [HttpGet("api/[controller]/{idTarefa}")]
        public IActionResult SelecionarID(int idTarefa)
        {
            var tarefa = servicoTarefa.SelecionarId(idTarefa);

            if (tarefa == null)
                return NotFound("Tarefa não encontrada.");

            return Ok(tarefa);
        }



        [HttpDelete("{idTarefa}")]
        public IActionResult DeletarID(int idTarefa)
        {
            var tarefa = servicoTarefa.DeletarId(idTarefa);

            if (tarefa == null)
                return NotFound("Tarefa não encontrada.");

            return Ok(tarefa);
        }



        [HttpPut("{idTarefa}")]
        public IActionResult AtualizarID(int idTarefa,[FromBody]Tarefa tarefas)
        {
            var tarefaAtualizada = servicoTarefa.AtualizarId(idTarefa, tarefas);

            if (tarefaAtualizada == null)
                return NotFound("Tarefa não encontrada.");

            return Ok(tarefaAtualizada);
        }


    }
}
