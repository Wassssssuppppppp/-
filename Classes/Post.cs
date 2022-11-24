using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Post
    {
        [Key]
        public int PostionCode { get; set; }

        public string TitleOfThePosition { get; set; }

    }
}
