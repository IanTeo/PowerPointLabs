﻿using System.Drawing;
using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Image
{
    [ExportImageRibbonId(
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuShape,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuLine,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuFreeform,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuPicture,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuGroup,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuInk,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuVideo,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuTextEdit,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuChart,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuTable,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuTableCell,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuSmartArt,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuEditSmartArt,
        TextCollection.HideSelectedShapeMenuId + TextCollection.MenuEditSmartArtText)]
    class HideImageHandler : ImageHandler
    {
        protected override Bitmap GetImage(string ribbonId)
        {
            return new Bitmap(Properties.Resources.HideShape);
        }
    }
}
