using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace To_Do_List
{
    public class Todo
    {
        public int Id { get; set; }
        
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")] //ErrorMessage serve para que ele sobreescreva a mensagem em inglês
        public string Title { get; set; }
        
        [DisplayName("Conluído")]
        public bool Done { get; set; }
        
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; }
    }
}