namespace dining_room
{
    abstract class Employees // Информация о работнике (фамилия, имя, отчество, заработная плата)
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Salary { get; set; }
    }
}