using System.ComponentModel.DataAnnotations;



namespace TodoApi.Models
{
    public class Tarefa
    {
        [Key]
        public int idTarefa { get; set; }   


        [Required]
        public string? NomeTarefa { get; set; }


        [Required]
        public string? DescricaoTarefa { get; set; }

        public DateTime DataTarefa { get; set; } = DateTime.Now;

    }
}
