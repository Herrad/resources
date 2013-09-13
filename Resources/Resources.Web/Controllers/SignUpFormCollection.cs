using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Resources.Web.Controllers
{
    public class SignUpFormCollection
    {
        [DisplayName("player-name")]
        [Required(ErrorMessage = "Player name required")]
        public string Name { get; set; }

        [DisplayName("city-name")]
        [Required(ErrorMessage = "City name required")]
        public string City { get; set; }
    }
}