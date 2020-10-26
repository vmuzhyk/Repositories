namespace Exam_9_Packman.Models.Abstract
{
    public interface IPlayer
    {
        string Name { get; }
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }
        int Score { get; set; }
        int CherryCount { get; set; }
    }
}
