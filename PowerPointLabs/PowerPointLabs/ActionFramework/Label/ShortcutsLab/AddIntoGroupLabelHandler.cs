﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Label
{
    [ExportLabelRibbonId(TextCollection.AddIntoGroupMenuId + TextCollection.MenuGroup)]
    class MergeIntoGroupLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection.AddIntoGroup;
        }
    }
}