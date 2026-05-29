using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using System.Linq;
using System.Collections.Generic;
using TodoApi.AppDbContext;



namespace TodoApi.Persistencia
{
    public class ConsultasBaseDados
    {

        public IList<Tarefa> TodasTarefas()
        {
            using (var context = new Context())
            {
                return context.Tarefas.ToList();
            }
        }


        public void Gravar(Tarefa tarefas)
        {
            using (var context = new Context())
            {
                context.Tarefas.Add(tarefas);
                context.SaveChanges();
            }
        }


        public Tarefa SelecionarID(int idTarefa)
        {
            using (var context = new Context())
            {
                return context.Tarefas.Find(idTarefa);
            }
        }


        public Tarefa DeletarID(int excluirTarefa)
        {
            using (var context = new Context())
            {
                var tarefa = context.Tarefas.Find(excluirTarefa);

                if (tarefa == null)
                {
                    return null;
                }

                context.Tarefas.Remove(tarefa);
                context.SaveChanges();

                return tarefa;
            }
        }


        public Tarefa Atualizar(int atualizarTarefa, Tarefa tarefas)
        {
            using (var context = new Context())
            {
                var tarefaAtualizada = context.Tarefas.Find(atualizarTarefa);

                if (tarefaAtualizada == null)
                {
                    return null;
                }

                tarefaAtualizada.NomeTarefa = tarefas.NomeTarefa;
                tarefaAtualizada.DescricaoTarefa = tarefas.DescricaoTarefa;


                context.SaveChanges();

                return tarefaAtualizada;
            }
        }

    }
}
