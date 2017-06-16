﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Label.CropLab
{
    [ExportLabelRibbonId(TextCollection.CropToShapeTag + TextCollection.RibbonButton)]
    class CropToShapeLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection.MoveCropShapeButtonLabel;
        }
    }
}
