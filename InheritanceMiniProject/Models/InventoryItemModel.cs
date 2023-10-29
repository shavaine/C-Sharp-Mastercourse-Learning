using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject
{
    public class InventoryItemModel: IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
}
