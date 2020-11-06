using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BigMamaUML3
{
    class Beverage : MenuItem
    {
        int Number { get; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        MenuType Type { get; set; }
        bool IsVegan { get; set; }
        bool IsOrganic { get; set; }

        public override string PrintInfo()
        {
            return $"#{Number} \nName: {Name} \nDescription: {Description} \nPrice: {Price} DKK \nType: {Type} \nVegan: {IsVegan} \nOrganic: {IsOrganic}";
        }

        public Beverage(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = menuType;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }
    }
}