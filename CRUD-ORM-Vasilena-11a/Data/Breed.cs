using System.Collections.Generic;

namespace CRUD_ORM_Vasilena_11a.Data
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //1:M
        public ICollection<Cat> Cats { get; set; }
}
}