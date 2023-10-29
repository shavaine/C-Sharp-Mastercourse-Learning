﻿using InheritanceMiniProject.Interfaces;

namespace InheritanceMiniProject
{
    public interface IRentable: IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
