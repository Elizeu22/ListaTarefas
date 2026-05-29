using TodoApi.Models;
using TodoApi.AppDbContext;
using TodoApi.Persistencia;


namespace TodoApi.Service
{
    public class TarefaServico
    {

        private ConsultasBaseDados consultas = new ConsultasBaseDados();

        public IList<Tarefa> Tarefas()
        {
            return consultas.TodasTarefas();
        }

        public void Gravar(Tarefa tarefa)
        {
            consultas.Gravar(tarefa);
        }

        public Tarefa SelecionarId(int tarefaID)
        {
            return consultas.SelecionarID(tarefaID);
        }

        public Tarefa DeletarId(int tarefaID)
        {
            return consultas.DeletarID(tarefaID);
        }

        public Tarefa AtualizarId(int tarefaID,Tarefa tarefa)
        {
            return consultas.Atualizar(tarefaID,tarefa);
        }



    }
}
