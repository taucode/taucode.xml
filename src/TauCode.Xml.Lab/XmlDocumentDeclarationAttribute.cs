﻿using System;

namespace TauCode.Xml.Lab
{
    [AttributeUsage(AttributeTargets.Class)]
    public class XmlDocumentDeclarationAttribute : Attribute
    {
        public string Encoding { get; set; } = "utf-8";
        public string Standalone { get; set; } = "yes";
    }
}
