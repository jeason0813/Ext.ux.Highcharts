using System.Collections.Generic;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.PyramidSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    public partial class BasePyramidSerie : FunnelSeries
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BasePyramidSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.PyramidSerie.js", "Resources/Chart/ux/Highcharts/PyramidSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.PyramidSerie";
            }
        }


    }
}