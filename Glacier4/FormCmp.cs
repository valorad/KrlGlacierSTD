using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesFile;

namespace Glacier4
{
    public partial class FormCmp : Form
    {

        string datadir = Form1.datadir;
        int count = Form1.idata.Count;

        public static double[] area = new double[Form1.yearCount];

        #region functions
        /*-------------------------Functions Start-------------------------*/
        /// <summary>
        /// 加载数据
        /// </summary>
        private void loadData()
        {
            try
            {
                AxMapControl[] maps = new AxMapControl[count];
                string[] years = new string[count];
                int j = 0;
                //把dictionary里所有key(即所有年份)提取出来存到字符串数组keys中
                foreach (KeyValuePair<string, string> key in Form1.idata)
                {
                    years[j] = key.Key;
                    j++;
                }

                //让每个动态生成的AxMapControl地图控件加载其对应年份的冰川图层，并顺便计算出其面积
                for (int i = 0; i < count; i++)
                {
                    maps[i] = new AxMapControl();
                    //动态生成的ActiveX控件必须写以下这三句话，感谢喻亮老师的指导233333 虽然其实我是自己找谷哥哥解决的:)
                    ((System.ComponentModel.ISupportInitialize)(maps[i])).BeginInit(); 
                    Controls.Add(maps[i]);
                    ((System.ComponentModel.ISupportInitialize)(maps[i])).EndInit();

                    PanelMaps.Controls.Add(maps[i]);
                    loadShp(Form1.idata[years[i]], maps[i]);
                    area[i] = Form1.getArea(maps[i].get_Layer(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("一个文件未找到或已损坏，图层加载未成功。以下是详细信息：\n" + ex.ToString(), "图层加载未成功", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 往指定map控件中加载ShapeFile
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="map"></param>
        public void loadShp(string fileName, AxMapControl map)
        {

            //声明Shape文件工作空间工厂，并获取要素工作空间，加载要素类  
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactory();
            IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(datadir, 0);
            IFeatureWorkspace pFeatureWorkspace;
            pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
            IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(fileName);
            IDataset pDataset = pFeatureClass as IDataset;

            //声明要素图层，设置相应属性  
            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
            pFeatureLayer.FeatureClass = pFeatureClass;
            pFeatureLayer.Name = pDataset.Name;

            //将要素图层转为图层，Add to MapControl   
            ILayer pLayer = pFeatureLayer as ILayer;
            map.Map.AddLayer(pLayer);
        }
        /*-------------------------Functions End-------------------------*/
        #endregion
        public FormCmp()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Engine);
            InitializeComponent();
        }

        private void FormCmp_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //打开图表
        private void btnShowDiag_Click(object sender, EventArgs e)
        {
            FormCharts charts = new FormCharts();
            charts.Show();
        }
    }
}
