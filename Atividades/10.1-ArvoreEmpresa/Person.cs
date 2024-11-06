namespace _10._1_ArvoreEmpresa
{
    public class Person(int id, string name, string role)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Role { get; set; } = role;
    }
}