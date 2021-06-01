﻿using System.Collections.Generic;

namespace TauCode.Xml.Unbound
{
    public interface IUnboundSchema
    {
        IReadOnlyDictionary<string, bool> UnboundAttributes { get; }
        bool AllowsUnknownAttributes { get; }
        IReadOnlyList<UnboundChildElementDescriptor> UnboundChildElementDescriptors { get; }
        bool AllowsUnknownChildElements { get; }
    }
}
