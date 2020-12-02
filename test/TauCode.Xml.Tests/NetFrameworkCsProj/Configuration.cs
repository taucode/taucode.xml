﻿using TauCode.Xml.Attributes;

namespace TauCode.Xml.Tests.NetFrameworkCsProj
{
    public class Configuration
    {
        [XmlAttributeProperty]
        public string Condition { get; set; }

        [XmlInnerText]
        public string Value { get; set; }
    }
}