using System.Text;

namespace aplication
{
    public class Serie : Base
    {
        public Gender Gender { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool Excluded { get; set; }

        public Serie(Gender gender, string title, string description, int year, int id) : base(id)
        {
            Gender = gender;
            Title = title;
            Description = description;
            Year = year;
            Id = id;
            Excluded = false;
        }

        public string TitleReturn()
        {
            return Title;
        }

        public int IdReturn()
        {
            return Id;
        }

        public bool ExcludeReturn()
        {
            return Excluded;
        }

        public void Exclude()
        {
            Excluded = true;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Gênero: " + Gender);
            text.AppendLine("Título: " + Title);
            text.AppendLine("Descrição: " + Description);
            text.AppendLine("Ano: " + Year);
            text.AppendLine("Excluído: " + Excluded);

            return text.ToString();
        }
    }
}