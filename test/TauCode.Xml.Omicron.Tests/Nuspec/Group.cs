﻿using System.Collections.Generic;
using TauCode.Xml.Omicron.Attributes;

namespace TauCode.Xml.Omicron.Tests.Nuspec
{
    public class Group
    {
        [XmlAttributeProperty(IsCamelCase = true)]
        public string TargetFramework { get; set; }

        [XmlElementProperty(XmlName = "dependency")]
        public IList<Dependency> Dependencies { get; } = new List<Dependency>();
    }
}