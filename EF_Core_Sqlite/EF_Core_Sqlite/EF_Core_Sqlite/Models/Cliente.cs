namespace EF_Core_Sqlite.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
