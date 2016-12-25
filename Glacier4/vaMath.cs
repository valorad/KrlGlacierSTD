using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.SpatialAnalyst;

namespace Glacier4
{ 
    public static class vaMath
    {
        //public static IGeoDataset result;
        public static IMathOp mathOp = new RasterMathOps() as IMathOp;
        public static void ShowResult(IGeoDataset2 geoDataset, string interType, AxMapControl map)
        {
            IRasterLayer rasterLayer = new RasterLayer();
            IRaster raster = new Raster();
            raster = geoDataset as IRaster;
            rasterLayer.CreateFromRaster(raster);
            rasterLayer.Name = interType;

            map.AddLayer(rasterLayer, 0);
            map.ActiveView.Refresh();
        }

        public static IGeoDataset2 vaPlus(IGeoDataset2 a, IGeoDataset2 b)
        {
            IGeoDataset2 result;
            result = mathOp.Plus(a, b) as IGeoDataset2;
            return result;
        }

        public static IGeoDataset2 vaMinus(IGeoDataset2 a, IGeoDataset2 b)
        {
            IGeoDataset2 result;
            result = mathOp.Minus(a, b) as IGeoDataset2;
            return result;
        }
        public static IGeoDataset2 vaDevide(IGeoDataset2 a, IGeoDataset2 b)
        {
            IGeoDataset2 result;
            result = mathOp.Divide(a, b) as IGeoDataset2;
            return result;
        }

    }
}
