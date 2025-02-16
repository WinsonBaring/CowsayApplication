using System.Xml.Serialization;
using Cowsay.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cowsay.Core.Base;
public static class OptionBase
{
    public static List<string> GetAnimalTypes()
    {
        return Enum.GetValues(typeof(AnimalType))
                  .Cast<AnimalType>()
                  .Select(type => type.ToString())
                  .ToList();
    }
}