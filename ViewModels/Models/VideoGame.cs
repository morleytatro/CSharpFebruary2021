using System.ComponentModel.DataAnnotations;

namespace ViewModels.Models
{
    public class VideoGame
    {
        [Required(ErrorMessage="You must supply a title.")]
        [MinLength(5, ErrorMessage="The title must be at least 5 characters.")]
        public string Title {get;set;}

        [Display(Name="Release Date")]
        public string ReleaseDate {get;set;}

        [Display(Name="Is this multiplayer?")]
        public bool MultiPlayer {get;set;}
        public string Developer {get;set;}
        public int Rating {get;set;}
    }
}