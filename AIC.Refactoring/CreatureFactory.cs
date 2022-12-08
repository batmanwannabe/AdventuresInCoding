using AIC.Data.Enums;
using AIC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Refactoring
{
    public static class CreatureFactory
    {
        public static object? AdoptACreature(string creatureName)
        {
            switch (creatureName)
            {
                case null:
                    return default;
                case nameof(CreatureEnum.dragon):
                    return new Dragon();
                case nameof(CreatureEnum.unicorn):
                    return new Unicorn();
                default:
                    return new Creature();
            }
        }
    }
}
