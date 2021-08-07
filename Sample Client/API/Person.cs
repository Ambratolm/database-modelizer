using DatabaseModelizer;

namespace SampleClient
{
    class Person : Model
    {
        [Column("id")]
        public object Id { get; set; }

        [Column("full_name")]
        public object Name { get; set; }

        [Column("gender")]
        public object Gender { get; set; }

        [Column("birth_date")]
        public object BirthDate { get; set; }

        public override string ToString()
        {
            return string.Format("#{0} {1} ({2}) {3}", Id, Name, Gender, BirthDate);
        }
    }
}
