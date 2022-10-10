namespace dining_room
{
    public interface ISnPtoString<out T> // Приводить фамилию, имя и отчество в одну строку
    {
        T SnPtoString();
    }
}