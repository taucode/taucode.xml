﻿using System.Collections.Generic;
using TauCode.Xml.Attributes;

namespace TauCode.Xml.Tests.Nuspec
{
    [TauXmlElement(IsCamelCase = true)]
    public class Group : TauXmlElement
    {
        [TauXmlAttribute(IsCamelCase = true)]
        public string TargetFramework { get; set; }

        public IList<Dependency> Dependencies { get; set; } = new List<Dependency>();
    }
}