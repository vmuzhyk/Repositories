namespace Exam_9_Packman.Models.Abstract
{
    public interface IItems
    {
        void InteractionWithPlayer(Player player);
        void CalcProbabilityToInteract(Player player);
    }
}
