using System;
using System.Data;
using System.Windows.Forms;

namespace Glacier4
{
    public partial class FormCharts : Form
    {
        /// <summary>
        /// 初始化图表。包括绑定数据、设置图形系列。
        /// </summary>
        private void initChart()
        {

            DataTable dtable = new DataTable();
            dtable.Columns.Add("Years");
            dtable.Columns.Add("Area");

            //load 加载数据
            loadData(dtable);

            //Display on chart 数据绑定，显示在图表中
            chart1.DataSource = dtable;

            chart1.Series[0].Name = "Area";
            chart1.Series[0].AxisLabel = "axis";
            chart1.Series[0].XValueMember = "Years";
            chart1.Series[0].YValueMembers = "Area";

            chart1.DataBind();
        }

        /// <summary>
        /// 往指定数据表中加载数据
        /// </summary>
        /// <param name="dtable"></param>
        private void loadData(DataTable dtable)
        {
            for (int i = 0; i < Form1.yearCount; i++)
            {
                object[] data = {Form1.getDictKey(Form1.idata, i), FormCmp.area[i]};
                DataRow drow = dtable.NewRow();
                drow.ItemArray = data;
                dtable.Rows.Add(drow);
            }
            
        }

        public FormCharts()
        {
            InitializeComponent();
        }

        private void FormCharts_Load(object sender, EventArgs e)
        {
            initChart();
            labelGenTime.Text = DateTime.Now.ToString();
        }
    }
}
