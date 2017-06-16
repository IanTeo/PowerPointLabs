﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Label.CropLab
{
    [ExportLabelRibbonId(TextCollection.CropToSlideTag + TextCollection.RibbonButton)]
    class CropToSlideLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection.CropToSlideButtonLabel;
        }
    }
}
