using System.ComponentModel.DataAnnotations;


namespace AMS23_CAROUSEL
{
    // class RequiredAttribute;
    public class LoginModel
    {
        [Required(ErrorMessage ="Informe o e-mail do usuário")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é inválido")]
        // [Required(ErrorMessage ="Informe a senha")]
        
        public string Email{get;set;}
        public string Password{get;set;}
        

    }
}