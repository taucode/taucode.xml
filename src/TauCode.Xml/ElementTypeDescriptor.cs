﻿using System;
using TauCode.Xml.Bound;
using TauCode.Xml.Unbound;

namespace TauCode.Xml
{
    internal class ElementTypeDescriptor : IElementTypeDescriptor
    {
        #region ctor

        internal ElementTypeDescriptor(Type elementType)
        {
            this.ElementType = elementType;
            this.BoundSchemaInternal = new BoundSchemaBase();
        }

        #endregion

        #region Internal

        internal BoundSchemaBase BoundSchemaInternal { get; }

        internal UnboundSchemaBase UnboundSchemaInternal { get; set; }

        #endregion

        #region IElementTypeDescriptor Members

        public Type ElementType { get; }

        public IBoundSchema BoundSchema => this.BoundSchemaInternal;

        public IUnboundSchema UnboundSchema => this.UnboundSchemaInternal;

        #endregion
    }
}
