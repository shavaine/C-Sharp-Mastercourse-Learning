using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject
{
    public interface IPurchasable : IInventoryItem
    {
        void Purchase();
    }
}
