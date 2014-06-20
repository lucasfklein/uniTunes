using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using uniTunes.Models;

namespace uniTunes.UI.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "É necessário preencher o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "É necessário preencher a senha")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "É necessário preencher o email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "É necessário preencher o vínculo acadêmico.")]
        public LinkType Link { get; set; }
        [Required(ErrorMessage="É necessário preencher a pergunta.")]
        public string Question { get; set; }
        [Required(ErrorMessage = "É necessário preencher a resposta.")]
        public string Answer { get; set; }
    }
}