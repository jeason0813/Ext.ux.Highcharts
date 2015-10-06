
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the 	chart is inverted this is the vertical axis. In case of multiple axes, the xAxis	node is an array of configuration objects.	See the Axis object for programmatic	access to the axis.
        /// </summary>
        public partial class XAxis : Observable
        {

    
            /// <summary>
            /// Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.")]
            public bool? AllowDecimals
            {
                get
                {
                    return this.State.Get<bool?>("AllowDecimals", true);
                }
                set
                {
                    this.State.Set("AllowDecimals", value);
                }
            }

            /// <summary>
            /// When using an alternate grid color, a band is painted across the plot area between every other grid line.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using an alternate grid color, a band is painted across the plot area between every other grid line.")]
            public string AlternateGridColor
            {
                get
                {
                    return this.State.Get<string>("AlternateGridColor", "");
                }
                set
                {
                    this.State.Set("AlternateGridColor", value);
                }
            }

            /// <summary>
            /// If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a name and setting axis type to category. However, if you have multiple series, best practice remains defining the categories array.Example:categories: ['Apples', 'Bananas', 'Oranges']		 Defaults to null
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a name and setting axis type to category. However, if you have multiple series, best practice remains defining the categories array.Example:categories: ['Apples', 'Bananas', 'Oranges']		 Defaults to null")]
            public string[] Categories
            {
                get
                {
                    return this.State.Get<string[]>("Categories", null);
                }
                set
                {
                    this.State.Set("Categories", value);
                }
            }

            /// <summary>
            /// The highest allowed value for automatically computed axis extremes.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The highest allowed value for automatically computed axis extremes.")]
            public double? Ceiling
            {
                get
                {
                    return this.State.Get<double?>("Ceiling", null);
                }
                set
                {
                    this.State.Set("Ceiling", value);
                }
            }

            /// <summary>
            /// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:{	millisecond: '%H:%M:%S.%L',	second: '%H:%M:%S',	minute: '%H:%M',	hour: '%H:%M',	day: '%e. %b',	week: '%e. %b',	month: '%b \'%y',	year: '%Y'}
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:{	millisecond: '%H:%M:%S.%L',	second: '%H:%M:%S',	minute: '%H:%M',	hour: '%H:%M',	day: '%e. %b',	week: '%e. %b',	month: '%b \'%y',	year: '%Y'}")]
            public object DateTimeLabelFormats
            {
                get
                {
                    return this.State.Get<object>("DateTimeLabelFormats", null);
                }
                set
                {
                    this.State.Set("DateTimeLabelFormats", value);
                }
            }

            /// <summary>
            /// Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end.")]
            public bool? EndOnTick
            {
                get
                {
                    return this.State.Get<bool?>("EndOnTick", false);
                }
                set
                {
                    this.State.Set("EndOnTick", value);
                }
            }

            /// <summary>
            /// The lowest allowed value for automatically computed axis extremes.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The lowest allowed value for automatically computed axis extremes.")]
            public double? Floor
            {
                get
                {
                    return this.State.Get<double?>("Floor", null);
                }
                set
                {
                    this.State.Set("Floor", value);
                }
            }

            /// <summary>
            /// Color of the grid lines extending the ticks across the plot area.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#D8D8D8")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color of the grid lines extending the ticks across the plot area.")]
            public string GridLineColor
            {
                get
                {
                    return this.State.Get<string>("GridLineColor", @"#D8D8D8");
                }
                set
                {
                    this.State.Set("GridLineColor", value);
                }
            }

            /// <summary>
            /// The dash or dot style of the grid lines. For possible values, see this demonstration.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dash or dot style of the grid lines. For possible values, see this demonstration.")]
            public string GridLineDashStyle
            {
                get
                {
                    return this.State.Get<string>("GridLineDashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("GridLineDashStyle", value);
                }
            }

            /// <summary>
            /// The width of the grid lines extending the ticks across the plot area.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the grid lines extending the ticks across the plot area.")]
            public double? GridLineWidth
            {
                get
                {
                    return this.State.Get<double?>("GridLineWidth", 0);
                }
                set
                {
                    this.State.Set("GridLineWidth", value);
                }
            }

            /// <summary>
            /// The Z index of the grid lines.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Z index of the grid lines.")]
            public double? GridZIndex
            {
                get
                {
                    return this.State.Get<double?>("GridZIndex", 1);
                }
                set
                {
                    this.State.Set("GridZIndex", value);
                }
            }

            /// <summary>
            /// An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get().")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The color of the line marking the axis itself.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#C0D0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the line marking the axis itself.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#C0D0E0");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the line marking the axis itself.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the line marking the axis itself.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 1);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.")]
            public double? LinkedTo
            {
                get
                {
                    return this.State.Get<double?>("LinkedTo", null);
                }
                set
                {
                    this.State.Set("LinkedTo", value);
                }
            }

            /// <summary>
            /// The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up. The actual maximum value is also influenced by  chart.alignTicks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up. The actual maximum value is also influenced by  chart.alignTicks.")]
            public double? Max
            {
                get
                {
                    return this.State.Get<double?>("Max", null);
                }
                set
                {
                    this.State.Set("Max", value);
                }
            }

            /// <summary>
            /// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' max option is set or a max extreme is set using axis.setExtremes(), the maxPadding will be ignored.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.01)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' max option is set or a max extreme is set using axis.setExtremes(), the maxPadding will be ignored.")]
            public double? MaxPadding
            {
                get
                {
                    return this.State.Get<double?>("MaxPadding", 0.01);
                }
                set
                {
                    this.State.Set("MaxPadding", value);
                }
            }

            /// <summary>
            /// Deprecated. Renamed to minRange as of Highcharts 2.2.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Deprecated. Renamed to minRange as of Highcharts 2.2.")]
            public double? MaxZoom
            {
                get
                {
                    return this.State.Get<double?>("MaxZoom", null);
                }
                set
                {
                    this.State.Set("MaxZoom", value);
                }
            }

            /// <summary>
            /// The minimum value of the axis. If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum value of the axis. If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down.")]
            public double? Min
            {
                get
                {
                    return this.State.Get<double?>("Min", null);
                }
                set
                {
                    this.State.Set("Min", value);
                }
            }

            /// <summary>
            /// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' min option is set or a min extreme is set using axis.setExtremes(), the minPadding will be ignored.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.01)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' min option is set or a min extreme is set using axis.setExtremes(), the minPadding will be ignored.")]
            public double? MinPadding
            {
                get
                {
                    return this.State.Get<double?>("MinPadding", 0.01);
                }
                set
                {
                    this.State.Set("MinPadding", value);
                }
            }

            /// <summary>
            /// The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour. The default minRange for the x axis is five times the smallest interval between any of the data points. On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 	1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.Note that the minPadding, maxPadding, startOnTick and endOnTick settings also affect how the extremes of the axis are computed.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour. The default minRange for the x axis is five times the smallest interval between any of the data points. On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 	1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.Note that the minPadding, maxPadding, startOnTick and endOnTick settings also affect how the extremes of the axis are computed.")]
            public double? MinRange
            {
                get
                {
                    return this.State.Get<double?>("MinRange", null);
                }
                set
                {
                    this.State.Set("MinRange", value);
                }
            }

            /// <summary>
            /// The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to the closest distance between two points on the axis.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to the closest distance between two points on the axis.")]
            public double? MinTickInterval
            {
                get
                {
                    return this.State.Get<double?>("MinTickInterval", null);
                }
                set
                {
                    this.State.Set("MinTickInterval", value);
                }
            }

            /// <summary>
            /// Color of the minor, secondary grid lines.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#E0E0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color of the minor, secondary grid lines.")]
            public string MinorGridLineColor
            {
                get
                {
                    return this.State.Get<string>("MinorGridLineColor", @"#E0E0E0");
                }
                set
                {
                    this.State.Set("MinorGridLineColor", value);
                }
            }

            /// <summary>
            /// The dash or dot style of the minor grid lines. For possible values, see this demonstration.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dash or dot style of the minor grid lines. For possible values, see this demonstration.")]
            public string MinorGridLineDashStyle
            {
                get
                {
                    return this.State.Get<string>("MinorGridLineDashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("MinorGridLineDashStyle", value);
                }
            }

            /// <summary>
            /// Width of the minor, secondary grid lines.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Width of the minor, secondary grid lines.")]
            public double? MinorGridLineWidth
            {
                get
                {
                    return this.State.Get<double?>("MinorGridLineWidth", 1);
                }
                set
                {
                    this.State.Set("MinorGridLineWidth", value);
                }
            }

            /// <summary>
            /// Color for the minor tick marks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#A0A0A0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color for the minor tick marks.")]
            public string MinorTickColor
            {
                get
                {
                    return this.State.Get<string>("MinorTickColor", @"#A0A0A0");
                }
                set
                {
                    this.State.Set("MinorTickColor", value);
                }
            }

            /// <summary>
            /// Tick interval in scale units for the minor ticks. On a linear axis, if ""auto"",  the minor tick interval is calculated as a fifth of the tickInterval. If null, minor ticks are not shown. On logarithmic axes, the unit is the power of the value. For example, setting 	the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting 	the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  	10 and 100 etc. A minorTickInterval of ""auto"" on a log axis results in a best guess, 	attempting to enter approximately 5 minor ticks between each major tick.If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.On axes using categories, minor ticks are not supported.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Tick interval in scale units for the minor ticks. On a linear axis, if ""auto"",  the minor tick interval is calculated as a fifth of the tickInterval. If null, minor ticks are not shown. On logarithmic axes, the unit is the power of the value. For example, setting 	the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting 	the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  	10 and 100 etc. A minorTickInterval of ""auto"" on a log axis results in a best guess, 	attempting to enter approximately 5 minor ticks between each major tick.If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.On axes using categories, minor ticks are not supported.")]
            public object MinorTickInterval
            {
                get
                {
                    return this.State.Get<object>("MinorTickInterval", null);
                }
                set
                {
                    this.State.Set("MinorTickInterval", value);
                }
            }

            /// <summary>
            /// The pixel length of the minor tick marks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel length of the minor tick marks.")]
            public double? MinorTickLength
            {
                get
                {
                    return this.State.Get<double?>("MinorTickLength", 2);
                }
                set
                {
                    this.State.Set("MinorTickLength", value);
                }
            }

            /// <summary>
            /// The position of the minor tick marks relative to the axis line. Can be one of inside and outside.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"outside")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the minor tick marks relative to the axis line. Can be one of inside and outside.")]
            public string MinorTickPosition
            {
                get
                {
                    return this.State.Get<string>("MinorTickPosition", @"outside");
                }
                set
                {
                    this.State.Set("MinorTickPosition", value);
                }
            }

            /// <summary>
            /// The pixel width of the minor tick mark.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the minor tick mark.")]
            public double? MinorTickWidth
            {
                get
                {
                    return this.State.Get<double?>("MinorTickWidth", 0);
                }
                set
                {
                    this.State.Set("MinorTickWidth", value);
                }
            }

            /// <summary>
            /// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.")]
            public double? Offset
            {
                get
                {
                    return this.State.Get<double?>("Offset", 0);
                }
                set
                {
                    this.State.Set("Offset", value);
                }
            }

            /// <summary>
            /// Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.")]
            public bool? Opposite
            {
                get
                {
                    return this.State.Get<bool?>("Opposite", false);
                }
                set
                {
                    this.State.Set("Opposite", value);
                }
            }

            /// <summary>
            /// Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.")]
            public bool? Reversed
            {
                get
                {
                    return this.State.Get<bool?>("Reversed", false);
                }
                set
                {
                    this.State.Set("Reversed", value);
                }
            }

            /// <summary>
            /// Whether to show the axis line and title when the axis has no data.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the axis line and title when the axis has no data.")]
            public bool? ShowEmpty
            {
                get
                {
                    return this.State.Get<bool?>("ShowEmpty", true);
                }
                set
                {
                    this.State.Set("ShowEmpty", value);
                }
            }

            /// <summary>
            /// Whether to show the first tick label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the first tick label.")]
            public bool? ShowFirstLabel
            {
                get
                {
                    return this.State.Get<bool?>("ShowFirstLabel", true);
                }
                set
                {
                    this.State.Set("ShowFirstLabel", value);
                }
            }

            /// <summary>
            /// Whether to show the last tick label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the last tick label.")]
            public bool? ShowLastLabel
            {
                get
                {
                    return this.State.Get<bool?>("ShowLastLabel", true);
                }
                set
                {
                    this.State.Set("ShowLastLabel", value);
                }
            }

            /// <summary>
            /// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.")]
            public double? StartOfWeek
            {
                get
                {
                    return this.State.Get<double?>("StartOfWeek", 1);
                }
                set
                {
                    this.State.Set("StartOfWeek", value);
                }
            }

            /// <summary>
            /// Whether to force the axis to start on a tick. Use this option with the minPadding option to control the axis start.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to force the axis to start on a tick. Use this option with the minPadding option to control the axis start.")]
            public bool? StartOnTick
            {
                get
                {
                    return this.State.Get<bool?>("StartOnTick", false);
                }
                set
                {
                    this.State.Set("StartOnTick", value);
                }
            }

            /// <summary>
            /// The amount of ticks to draw on the axis. This opens up for aligning the ticks of multiple charts or panes within a chart. This option overrides the tickPixelInterval option.This option only has an effect on linear axes. Datetime, logarithmic or category axes are not affected.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The amount of ticks to draw on the axis. This opens up for aligning the ticks of multiple charts or panes within a chart. This option overrides the tickPixelInterval option.This option only has an effect on linear axes. Datetime, logarithmic or category axes are not affected.")]
            public double? TickAmount
            {
                get
                {
                    return this.State.Get<double?>("TickAmount", null);
                }
                set
                {
                    this.State.Set("TickAmount", value);
                }
            }

            /// <summary>
            /// Color for the main tick marks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#C0D0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color for the main tick marks.")]
            public string TickColor
            {
                get
                {
                    return this.State.Get<string>("TickColor", @"#C0D0E0");
                }
                set
                {
                    this.State.Set("TickColor", value);
                }
            }

            /// <summary>
            /// The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes. On categorized axes, a null tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as 24 * 3600 * 1000. On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means 	one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. 	A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highcharts may remove ticks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes. On categorized axes, a null tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as 24 * 3600 * 1000. On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means 	one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. 	A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highcharts may remove ticks.")]
            public double? TickInterval
            {
                get
                {
                    return this.State.Get<double?>("TickInterval", null);
                }
                set
                {
                    this.State.Set("TickInterval", value);
                }
            }

            /// <summary>
            /// The pixel length of the main tick marks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel length of the main tick marks.")]
            public double? TickLength
            {
                get
                {
                    return this.State.Get<double?>("TickLength", 10);
                }
                set
                {
                    this.State.Set("TickLength", value);
                }
            }

            /// <summary>
            /// If tickInterval is null this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to 72  for the Y axis and 100 for	the X axis.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If tickInterval is null this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to 72  for the Y axis and 100 for	the X axis.")]
            public double? TickPixelInterval
            {
                get
                {
                    return this.State.Get<double?>("TickPixelInterval", null);
                }
                set
                {
                    this.State.Set("TickPixelInterval", value);
                }
            }

            /// <summary>
            /// The position of the major tick marks relative to the axis line. Can be one of inside and outside.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"outside")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the major tick marks relative to the axis line. Can be one of inside and outside.")]
            public string TickPosition
            {
                get
                {
                    return this.State.Get<string>("TickPosition", @"outside");
                }
                set
                {
                    this.State.Set("TickPosition", value);
                }
            }

            /// <summary>
            /// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval. The automatic tick positions are accessible through this.tickPositions and can be modified by the callback.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval. The automatic tick positions are accessible through this.tickPositions and can be modified by the callback.")]
            public string TickPositioner
            {
                get
                {
                    return this.State.Get<string>("TickPositioner", "");
                }
                set
                {
                    this.State.Set("TickPositioner", value);
                }
            }

            /// <summary>
            /// An array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval.")]
            public double[] TickPositions
            {
                get
                {
                    return this.State.Get<double[]>("TickPositions", null);
                }
                set
                {
                    this.State.Set("TickPositions", value);
                }
            }

            /// <summary>
            /// The pixel width of the major tick marks.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the major tick marks.")]
            public double? TickWidth
            {
                get
                {
                    return this.State.Get<double?>("TickWidth", 1);
                }
                set
                {
                    this.State.Set("TickWidth", value);
                }
            }

            /// <summary>
            /// For categorized axes only. If on the tick mark is placed in the center of  the category, if between the tick mark is placed between categories. The default is between if the tickInterval is 1, else on.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For categorized axes only. If on the tick mark is placed in the center of  the category, if between the tick mark is placed between categories. The default is between if the tickInterval is 1, else on.")]
            public string TickmarkPlacement
            {
                get
                {
                    return this.State.Get<string>("TickmarkPlacement", @"null");
                }
                set
                {
                    this.State.Set("TickmarkPlacement", value);
                }
            }

            /// <summary>
            /// The type of axis. Can be one of ""linear"", ""logarithmic"", ""datetime"" or ""category"". In a datetime axis, the numbers are given in milliseconds, and tick marks are placed 		on appropriate values like full hours or days. In a category axis, the point names of the chart's series are used for categories, if not a categories array is defined.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"linear")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The type of axis. Can be one of ""linear"", ""logarithmic"", ""datetime"" or ""category"". In a datetime axis, the numbers are given in milliseconds, and tick marks are placed 		on appropriate values like full hours or days. In a category axis, the point names of the chart's series are used for categories, if not a categories array is defined.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", @"linear");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// Datetime axis only. An array determining what time intervals the ticks are allowed to fall on. Each array item is an array where the first value is the time unit and the  second value another array of allowed multiples. Defaults to:units: [[	'millisecond', // unit name	[1, 2, 5, 10, 20, 25, 50, 100, 200, 500] // allowed multiples], [	'second',	[1, 2, 5, 10, 15, 30]], [	'minute',	[1, 2, 5, 10, 15, 30]], [	'hour',	[1, 2, 3, 4, 6, 8, 12]], [	'day',	[1]], [	'week',	[1]], [	'month',	[1, 3, 6]], [	'year',	null]]
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Datetime axis only. An array determining what time intervals the ticks are allowed to fall on. Each array item is an array where the first value is the time unit and the  second value another array of allowed multiples. Defaults to:units: [[	'millisecond', // unit name	[1, 2, 5, 10, 20, 25, 50, 100, 200, 500] // allowed multiples], [	'second',	[1, 2, 5, 10, 15, 30]], [	'minute',	[1, 2, 5, 10, 15, 30]], [	'hour',	[1, 2, 3, 4, 6, 8, 12]], [	'day',	[1]], [	'week',	[1]], [	'month',	[1, 3, 6]], [	'year',	null]]")]
            public string Units
            {
                get
                {
                    return this.State.Get<string>("Units", "");
                }
                set
                {
                    this.State.Set("Units", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("allowDecimals", new ConfigOption("allowDecimals", null, true, this.AllowDecimals));

                list.Add("alternateGridColor", new ConfigOption("alternateGridColor", null, "", this.AlternateGridColor));

                list.Add("categories", new ConfigOption("categories", null, null, this.Categories));

                list.Add("ceiling", new ConfigOption("ceiling", null, null, this.Ceiling));

                list.Add("dateTimeLabelFormats", new ConfigOption("dateTimeLabelFormats", null, null, this.DateTimeLabelFormats));

                list.Add("endOnTick", new ConfigOption("endOnTick", null, false, this.EndOnTick));

                list.Add("floor", new ConfigOption("floor", null, null, this.Floor));

                list.Add("gridLineColor", new ConfigOption("gridLineColor", null, @"#D8D8D8", this.GridLineColor));

                list.Add("gridLineDashStyle", new ConfigOption("gridLineDashStyle", null, @"Solid", this.GridLineDashStyle));

                list.Add("gridLineWidth", new ConfigOption("gridLineWidth", null, 0, this.GridLineWidth));

                list.Add("gridZIndex", new ConfigOption("gridZIndex", null, 1, this.GridZIndex));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#C0D0E0", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 1, this.LineWidth));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, null, this.LinkedTo));

                list.Add("max", new ConfigOption("max", null, null, this.Max));

                list.Add("maxPadding", new ConfigOption("maxPadding", null, 0.01, this.MaxPadding));

                list.Add("maxZoom", new ConfigOption("maxZoom", null, null, this.MaxZoom));

                list.Add("min", new ConfigOption("min", null, null, this.Min));

                list.Add("minPadding", new ConfigOption("minPadding", null, 0.01, this.MinPadding));

                list.Add("minRange", new ConfigOption("minRange", null, null, this.MinRange));

                list.Add("minTickInterval", new ConfigOption("minTickInterval", null, null, this.MinTickInterval));

                list.Add("minorGridLineColor", new ConfigOption("minorGridLineColor", null, @"#E0E0E0", this.MinorGridLineColor));

                list.Add("minorGridLineDashStyle", new ConfigOption("minorGridLineDashStyle", null, @"Solid", this.MinorGridLineDashStyle));

                list.Add("minorGridLineWidth", new ConfigOption("minorGridLineWidth", null, 1, this.MinorGridLineWidth));

                list.Add("minorTickColor", new ConfigOption("minorTickColor", null, @"#A0A0A0", this.MinorTickColor));

                list.Add("minorTickInterval", new ConfigOption("minorTickInterval", null, null, this.MinorTickInterval));

                list.Add("minorTickLength", new ConfigOption("minorTickLength", null, 2, this.MinorTickLength));

                list.Add("minorTickPosition", new ConfigOption("minorTickPosition", null, @"outside", this.MinorTickPosition));

                list.Add("minorTickWidth", new ConfigOption("minorTickWidth", null, 0, this.MinorTickWidth));

                list.Add("offset", new ConfigOption("offset", null, 0, this.Offset));

                list.Add("opposite", new ConfigOption("opposite", null, false, this.Opposite));

                list.Add("reversed", new ConfigOption("reversed", null, false, this.Reversed));

                list.Add("showEmpty", new ConfigOption("showEmpty", null, true, this.ShowEmpty));

                list.Add("showFirstLabel", new ConfigOption("showFirstLabel", null, true, this.ShowFirstLabel));

                list.Add("showLastLabel", new ConfigOption("showLastLabel", null, true, this.ShowLastLabel));

                list.Add("startOfWeek", new ConfigOption("startOfWeek", null, 1, this.StartOfWeek));

                list.Add("startOnTick", new ConfigOption("startOnTick", null, false, this.StartOnTick));

                list.Add("tickAmount", new ConfigOption("tickAmount", null, null, this.TickAmount));

                list.Add("tickColor", new ConfigOption("tickColor", null, @"#C0D0E0", this.TickColor));

                list.Add("tickInterval", new ConfigOption("tickInterval", null, null, this.TickInterval));

                list.Add("tickLength", new ConfigOption("tickLength", null, 10, this.TickLength));

                list.Add("tickPixelInterval", new ConfigOption("tickPixelInterval", null, null, this.TickPixelInterval));

                list.Add("tickPosition", new ConfigOption("tickPosition", null, @"outside", this.TickPosition));

                list.Add("tickPositioner", new ConfigOption("tickPositioner", null, "", this.TickPositioner));

                list.Add("tickPositions", new ConfigOption("tickPositions", null, null, this.TickPositions));

                list.Add("tickWidth", new ConfigOption("tickWidth", null, 1, this.TickWidth));

                list.Add("tickmarkPlacement", new ConfigOption("tickmarkPlacement", null, @"null", this.TickmarkPlacement));

                list.Add("type", new ConfigOption("type", null, @"linear", this.Type));

                list.Add("units", new ConfigOption("units", null, "", this.Units));

                return list;
            }
        }


    

        /// <summary>
        /// An array defining breaks in the axis, the sections defined will be left out and all the points shifted closer to each other. Requires that the broken-axis.js module is loaded.
        /// </summary>
        public partial class Breaks : Observable
        {

    
            /// <summary>
            /// A number indicating how much space should be left between the start and the end of the break. The break size is given in axis units, so for instance on a datetime axis, a break size of 3600000 would indicate the equivalent of an hour.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A number indicating how much space should be left between the start and the end of the break. The break size is given in axis units, so for instance on a datetime axis, a break size of 3600000 would indicate the equivalent of an hour.")]
            public double? BreakSize
            {
                get
                {
                    return this.State.Get<double?>("BreakSize", 0);
                }
                set
                {
                    this.State.Set("BreakSize", value);
                }
            }

            /// <summary>
            /// The point where the break starts.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The point where the break starts.")]
            public double? From
            {
                get
                {
                    return this.State.Get<double?>("From", null);
                }
                set
                {
                    this.State.Set("From", value);
                }
            }

            /// <summary>
            /// Defines an interval after which the break appears again. By default the breaks do not repeat.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines an interval after which the break appears again. By default the breaks do not repeat.")]
            public double? Repeat
            {
                get
                {
                    return this.State.Get<double?>("Repeat", 0);
                }
                set
                {
                    this.State.Set("Repeat", value);
                }
            }

            /// <summary>
            /// The point where the break ends.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The point where the break ends.")]
            public double? To
            {
                get
                {
                    return this.State.Get<double?>("To", null);
                }
                set
                {
                    this.State.Set("To", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("breakSize", new ConfigOption("breakSize", null, 0, this.BreakSize));

                list.Add("from", new ConfigOption("from", null, null, this.From));

                list.Add("repeat", new ConfigOption("repeat", null, 0, this.Repeat));

                list.Add("to", new ConfigOption("to", null, null, this.To));

                return list;
            }
        }


    

        }


        /// <summary>
        /// Event handlers for the axis.
        /// </summary>
        public partial class Events : Observable
        {

    
            /// <summary>
            /// An event fired after the breaks have rendered.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An event fired after the breaks have rendered.")]
            public string AfterBreaks
            {
                get
                {
                    return this.State.Get<string>("AfterBreaks", "");
                }
                set
                {
                    this.State.Set("AfterBreaks", value);
                }
            }

            /// <summary>
            /// As opposed to the setExtremes event, this event fires after the final min and max values are computed and corrected for minRange.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"As opposed to the setExtremes event, this event fires after the final min and max values are computed and corrected for minRange.")]
            public string AfterSetExtremes
            {
                get
                {
                    return this.State.Get<string>("AfterSetExtremes", "");
                }
                set
                {
                    this.State.Set("AfterSetExtremes", value);
                }
            }

            /// <summary>
            /// An event fired when a break from this axis occurs on a point.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An event fired when a break from this axis occurs on a point.")]
            public string PointBreak
            {
                get
                {
                    return this.State.Get<string>("PointBreak", "");
                }
                set
                {
                    this.State.Set("PointBreak", value);
                }
            }

            /// <summary>
            /// Fires when the minimum and maximum is set for the axis, either by calling the .setExtremes() method or by selecting an area in the chart. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.The new user set minimum and maximum values can be found by event.min and event.max. When an axis is zoomed all the way out from the ""Reset zoom"" button, event.min and event.max are null, and the new extremes are set based on this.dataMin and this.dataMax.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the minimum and maximum is set for the axis, either by calling the .setExtremes() method or by selecting an area in the chart. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.The new user set minimum and maximum values can be found by event.min and event.max. When an axis is zoomed all the way out from the ""Reset zoom"" button, event.min and event.max are null, and the new extremes are set based on this.dataMin and this.dataMax.")]
            public string SetExtremes
            {
                get
                {
                    return this.State.Get<string>("SetExtremes", "");
                }
                set
                {
                    this.State.Set("SetExtremes", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("afterBreaks", new ConfigOption("afterBreaks", null, "", this.AfterBreaks));

                list.Add("afterSetExtremes", new ConfigOption("afterSetExtremes", null, "", this.AfterSetExtremes));

                list.Add("pointBreak", new ConfigOption("pointBreak", null, "", this.PointBreak));

                list.Add("setExtremes", new ConfigOption("setExtremes", null, "", this.SetExtremes));

                return list;
            }
        }


    

        }


        /// <summary>
        /// The axis labels show the number or category for each tick.
        /// </summary>
        public partial class Labels : Observable
        {

    
            /// <summary>
            /// What part of the string the given position is anchored to. Can be one of ""left"", ""center"" or ""right"". Defaults to an intelligent guess based on which side of the chart the axis is on and the rotation of the label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"What part of the string the given position is anchored to. Can be one of ""left"", ""center"" or ""right"". Defaults to an intelligent guess based on which side of the chart the axis is on and the rotation of the label.")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"center");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// For horizontal axes, the allowed degrees of label rotation to prevent overlapping labels. If there is enough space, labels are not rotated. As the chart gets narrower, it will start rotating the labels -45 degrees, then remove every second label and try again with rotations 0 and -45 etc. Set it to false to disable rotation, which will cause the labels to word-wrap if possible.
            /// </summary>
            [ConfigOption]
            [DefaultValue(new double[] { -45})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For horizontal axes, the allowed degrees of label rotation to prevent overlapping labels. If there is enough space, labels are not rotated. As the chart gets narrower, it will start rotating the labels -45 degrees, then remove every second label and try again with rotations 0 and -45 etc. Set it to false to disable rotation, which will cause the labels to word-wrap if possible.")]
            public double[] AutoRotation
            {
                get
                {
                    return this.State.Get<double[]>("AutoRotation", new double[] { -45});
                }
                set
                {
                    this.State.Set("AutoRotation", value);
                }
            }

            /// <summary>
            /// When each category width is more than this many pixels, we don't apply auto rotation. Instead, we lay out the axis label with word wrap. A lower limit makes sense when the label contains multiple short words that don't extend the available horizontal space for each label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(80)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When each category width is more than this many pixels, we don't apply auto rotation. Instead, we lay out the axis label with word wrap. A lower limit makes sense when the label contains multiple short words that don't extend the available horizontal space for each label.")]
            public double? AutoRotationLimit
            {
                get
                {
                    return this.State.Get<double?>("AutoRotationLimit", 80);
                }
                set
                {
                    this.State.Set("AutoRotationLimit", value);
                }
            }

            /// <summary>
            /// Polar charts only. The label's pixel distance from the perimeter of the plot area.
            /// </summary>
            [ConfigOption]
            [DefaultValue(15)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Polar charts only. The label's pixel distance from the perimeter of the plot area.")]
            public double? Distance
            {
                get
                {
                    return this.State.Get<double?>("Distance", 15);
                }
                set
                {
                    this.State.Set("Distance", value);
                }
            }

            /// <summary>
            /// Enable or disable the axis labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the axis labels.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", true);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// A format string for the axis label. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"{value}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A format string for the axis label. ")]
            public string Format
            {
                get
                {
                    return this.State.Get<string>("Format", @"{value}");
                }
                set
                {
                    this.State.Set("Format", value);
                }
            }

            /// <summary>
            /// Callback JavaScript function to format the label. The value is  given by this.value. Additional properties for this are axis, chart, isFirst and isLast. Defaults to: function() {	return this.value;}
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Callback JavaScript function to format the label. The value is  given by this.value. Additional properties for this are axis, chart, isFirst and isLast. Defaults to: function() {	return this.value;}")]
            public string Formatter
            {
                get
                {
                    return this.State.Get<string>("Formatter", "");
                }
                set
                {
                    this.State.Set("Formatter", value);
                }
            }

            /// <summary>
            /// Horizontal axis only. When staggerLines is not set, maxStaggerLines defines how many lines the axis is allowed to add to automatically avoid overlapping X labels. Set to 1 to disable overlap detection. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal axis only. When staggerLines is not set, maxStaggerLines defines how many lines the axis is allowed to add to automatically avoid overlapping X labels. Set to 1 to disable overlap detection. ")]
            public double? MaxStaggerLines
            {
                get
                {
                    return this.State.Get<double?>("MaxStaggerLines", 5);
                }
                set
                {
                    this.State.Set("MaxStaggerLines", value);
                }
            }

            /// <summary>
            /// How to handle overflowing labels on horizontal axis. Can be undefined, false or ""justify"". By default it aligns inside the chart area. If ""justify"", labels will not render outside the plot area. If false, it will not be aligned at all. If there is room to move it, it will be aligned to the edge, else it will be removed.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"How to handle overflowing labels on horizontal axis. Can be undefined, false or ""justify"". By default it aligns inside the chart area. If ""justify"", labels will not render outside the plot area. If false, it will not be aligned at all. If there is room to move it, it will be aligned to the edge, else it will be removed.")]
            public string Overflow
            {
                get
                {
                    return this.State.Get<string>("Overflow", "");
                }
                set
                {
                    this.State.Set("Overflow", value);
                }
            }

            /// <summary>
            /// The pixel padding for axis labels, to ensure white space between them.
            /// </summary>
            [ConfigOption]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel padding for axis labels, to ensure white space between them.")]
            public double? Padding
            {
                get
                {
                    return this.State.Get<double?>("Padding", 5);
                }
                set
                {
                    this.State.Set("Padding", value);
                }
            }

            /// <summary>
            /// Rotation of the labels in degrees.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Rotation of the labels in degrees.")]
            public double? Rotation
            {
                get
                {
                    return this.State.Get<double?>("Rotation", 0);
                }
                set
                {
                    this.State.Set("Rotation", value);
                }
            }

            /// <summary>
            /// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels.  .
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels.  .")]
            public double? StaggerLines
            {
                get
                {
                    return this.State.Get<double?>("StaggerLines", null);
                }
                set
                {
                    this.State.Set("StaggerLines", value);
                }
            }

            /// <summary>
            /// To show only every n'th label on the axis, set the step to n. Setting the step to 2 shows every other label.By default, the step is calculated automatically to avoid overlap. To prevent this, set it to 1. This usually only happens on a category axis, and is often a sign that you have chosen the wrong axis type. Read more at Axis docs => What axis should I use? 
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"To show only every n'th label on the axis, set the step to n. Setting the step to 2 shows every other label.By default, the step is calculated automatically to avoid overlap. To prevent this, set it to 1. This usually only happens on a category axis, and is often a sign that you have chosen the wrong axis type. Read more at Axis docs => What axis should I use? ")]
            public double? Step
            {
                get
                {
                    return this.State.Get<double?>("Step", null);
                }
                set
                {
                    this.State.Set("Step", value);
                }
            }

            /// <summary>
            /// CSS styles for the label. Use whiteSpace: 'nowrap' to prevent wrapping of category labels. Use textOverflow: 'none' to prevent ellipsis (dots).
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"{""color"":""#6D869F"",""fontWeight"":""bold""}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the label. Use whiteSpace: 'nowrap' to prevent wrapping of category labels. Use textOverflow: 'none' to prevent ellipsis (dots).")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{""color"":""#6D869F"",""fontWeight"":""bold""}");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the labels.")]
            public bool? UseHTML
            {
                get
                {
                    return this.State.Get<bool?>("UseHTML", false);
                }
                set
                {
                    this.State.Set("UseHTML", value);
                }
            }

            /// <summary>
            /// The x position offset of the label relative to the tick position on the axis.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x position offset of the label relative to the tick position on the axis.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", 0);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// The y position offset of the label relative to the tick position on the axis. The default makes it adapt to the font size on bottom axis.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y position offset of the label relative to the tick position on the axis. The default makes it adapt to the font size on bottom axis.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", null);
                }
                set
                {
                    this.State.Set("y", value);
                }
            }

            /// <summary>
            /// The Z index for the axis labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(7)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Z index for the axis labels.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", 7);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("align", new ConfigOption("align", null, @"center", this.Align));

                list.Add("autoRotation", new ConfigOption("autoRotation", null, new double[] { -45}, this.AutoRotation));

                list.Add("autoRotationLimit", new ConfigOption("autoRotationLimit", null, 80, this.AutoRotationLimit));

                list.Add("distance", new ConfigOption("distance", null, 15, this.Distance));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("format", new ConfigOption("format", null, @"{value}", this.Format));

                list.Add("formatter", new ConfigOption("formatter", null, "", this.Formatter));

                list.Add("maxStaggerLines", new ConfigOption("maxStaggerLines", null, 5, this.MaxStaggerLines));

                list.Add("overflow", new ConfigOption("overflow", null, "", this.Overflow));

                list.Add("padding", new ConfigOption("padding", null, 5, this.Padding));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("staggerLines", new ConfigOption("staggerLines", null, null, this.StaggerLines));

                list.Add("step", new ConfigOption("step", null, null, this.Step));

                list.Add("style", new ConfigOption("style", null, @"{""color"":""#6D869F"",""fontWeight"":""bold""}", this.Style));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                list.Add("zIndex", new ConfigOption("zIndex", null, 7, this.ZIndex));

                return list;
            }
        }


    

        }


        /// <summary>
        /// An array of colored bands stretching across the plot area marking an interval on the axis.In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.
        /// </summary>
        public partial class PlotBands : Observable
        {

    
            /// <summary>
            /// Border color for the plot band. Also requires borderWidth to be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Border color for the plot band. Also requires borderWidth to be set.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"null");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// Border width for the plot band.  Also requires borderColor to be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Border width for the plot band.  Also requires borderColor to be set.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 0);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// The color of the plot band.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the plot band.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", "");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// An object defining mouse events for the plot band. Supported properties are click, mouseover, mouseout, mousemove.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An object defining mouse events for the plot band. Supported properties are click, mouseover, mouseout, mousemove.")]
            public object Events
            {
                get
                {
                    return this.State.Get<object>("Events", null);
                }
                set
                {
                    this.State.Set("Events", value);
                }
            }

            /// <summary>
            /// The start position of the plot band in axis units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The start position of the plot band in axis units.")]
            public double? From
            {
                get
                {
                    return this.State.Get<double?>("From", null);
                }
                set
                {
                    this.State.Set("From", value);
                }
            }

            /// <summary>
            /// An id used for identifying the plot band in Axis.removePlotBand.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id used for identifying the plot band in Axis.removePlotBand.")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The end position of the plot band in axis units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The end position of the plot band in axis units.")]
            public double? To
            {
                get
                {
                    return this.State.Get<double?>("To", null);
                }
                set
                {
                    this.State.Set("To", value);
                }
            }

            /// <summary>
            /// The z index of the plot band within the chart, relative to other elements. Using the same z index as another element may give unpredictable results, as the last rendered element will be on top. Values from 0 to 20 make sense.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The z index of the plot band within the chart, relative to other elements. Using the same z index as another element may give unpredictable results, as the last rendered element will be on top. Values from 0 to 20 make sense.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", null);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("borderColor", new ConfigOption("borderColor", null, @"null", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("events", new ConfigOption("events", null, null, this.Events));

                list.Add("from", new ConfigOption("from", null, null, this.From));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("to", new ConfigOption("to", null, null, this.To));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                return list;
            }
        }


    

        /// <summary>
        /// Text labels for the plot bands
        /// </summary>
        public partial class Label : Observable
        {

    
            /// <summary>
            /// Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"center");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// Rotation of the text label in degrees .
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Rotation of the text label in degrees .")]
            public double? Rotation
            {
                get
                {
                    return this.State.Get<double?>("Rotation", 0);
                }
                set
                {
                    this.State.Set("Rotation", value);
                }
            }

            /// <summary>
            /// CSS styles for the text label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the text label.")]
            public object Style
            {
                get
                {
                    return this.State.Get<object>("Style", null);
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The string text itself. A subset of HTML is supported.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The string text itself. A subset of HTML is supported.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", "");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.")]
            public string TextAlign
            {
                get
                {
                    return this.State.Get<string>("TextAlign", "");
                }
                set
                {
                    this.State.Set("TextAlign", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the labels.")]
            public bool? UseHTML
            {
                get
                {
                    return this.State.Get<bool?>("UseHTML", false);
                }
                set
                {
                    this.State.Set("UseHTML", value);
                }
            }

            /// <summary>
            /// Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"top")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", @"top");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// Horizontal position relative the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal position relative the alignment. Default varies by orientation.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", null);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical position of the text baseline relative to the alignment. Default varies by orientation.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", null);
                }
                set
                {
                    this.State.Set("y", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("align", new ConfigOption("align", null, @"center", this.Align));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("style", new ConfigOption("style", null, null, this.Style));

                list.Add("text", new ConfigOption("text", null, "", this.Text));

                list.Add("textAlign", new ConfigOption("textAlign", null, "", this.TextAlign));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"top", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, null, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    

        }


        }


        /// <summary>
        /// An array of lines stretching across the plot area, marking a specific value on one of the axes.
        /// </summary>
        public partial class PlotLines : Observable
        {

    
            /// <summary>
            /// The color of the line.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the line.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", "");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// The dashing or dot style for the plot line. For possible values see this overview.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dashing or dot style for the plot line. For possible values see this overview.")]
            public string DashStyle
            {
                get
                {
                    return this.State.Get<string>("DashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("DashStyle", value);
                }
            }

            /// <summary>
            /// An object defining mouse events for the plot line. Supported properties are click, mouseover, mouseout, mousemove.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An object defining mouse events for the plot line. Supported properties are click, mouseover, mouseout, mousemove.")]
            public object Events
            {
                get
                {
                    return this.State.Get<object>("Events", null);
                }
                set
                {
                    this.State.Set("Events", value);
                }
            }

            /// <summary>
            /// An id used for identifying the plot line in Axis.removePlotLine.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id used for identifying the plot line in Axis.removePlotLine.")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The position of the line in axis units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the line in axis units.")]
            public double? Value
            {
                get
                {
                    return this.State.Get<double?>("Value", null);
                }
                set
                {
                    this.State.Set("Value", value);
                }
            }

            /// <summary>
            /// The width or thickness of the plot line.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width or thickness of the plot line.")]
            public double? Width
            {
                get
                {
                    return this.State.Get<double?>("Width", null);
                }
                set
                {
                    this.State.Set("Width", value);
                }
            }

            /// <summary>
            /// The z index of the plot line within the chart.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The z index of the plot line within the chart.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", null);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("dashStyle", new ConfigOption("dashStyle", null, @"Solid", this.DashStyle));

                list.Add("events", new ConfigOption("events", null, null, this.Events));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("value", new ConfigOption("value", null, null, this.Value));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                return list;
            }
        }


    

        /// <summary>
        /// Text labels for the plot bands
        /// </summary>
        public partial class Label : Observable
        {

    
            /// <summary>
            /// Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"left")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"left");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// Rotation of the text label in degrees. Defaults to 0 for horizontal plot lines and 90 for vertical lines.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Rotation of the text label in degrees. Defaults to 0 for horizontal plot lines and 90 for vertical lines.")]
            public double? Rotation
            {
                get
                {
                    return this.State.Get<double?>("Rotation", null);
                }
                set
                {
                    this.State.Set("Rotation", value);
                }
            }

            /// <summary>
            /// CSS styles for the text label.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the text label.")]
            public object Style
            {
                get
                {
                    return this.State.Get<object>("Style", null);
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The text itself. A subset of HTML is supported.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text itself. A subset of HTML is supported.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", "");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.")]
            public string TextAlign
            {
                get
                {
                    return this.State.Get<string>("TextAlign", "");
                }
                set
                {
                    this.State.Set("TextAlign", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the labels.")]
            public bool? UseHTML
            {
                get
                {
                    return this.State.Get<bool?>("UseHTML", false);
                }
                set
                {
                    this.State.Set("UseHTML", value);
                }
            }

            /// <summary>
            /// Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"top")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", @"top");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// Horizontal position relative the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal position relative the alignment. Default varies by orientation.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", null);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical position of the text baseline relative to the alignment. Default varies by orientation.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", null);
                }
                set
                {
                    this.State.Set("y", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("align", new ConfigOption("align", null, @"left", this.Align));

                list.Add("rotation", new ConfigOption("rotation", null, null, this.Rotation));

                list.Add("style", new ConfigOption("style", null, null, this.Style));

                list.Add("text", new ConfigOption("text", null, "", this.Text));

                list.Add("textAlign", new ConfigOption("textAlign", null, "", this.TextAlign));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"top", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, null, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    

        }


        }


        /// <summary>
        /// The axis title, showing next to the axis line.
        /// </summary>
        public partial class Title : Observable
        {

    
            /// <summary>
            /// Alignment of the title relative to the axis values. Possible values are ""low"", ""middle"" or ""high"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"middle")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Alignment of the title relative to the axis values. Possible values are ""low"", ""middle"" or ""high"".")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"middle");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// Deprecated. Set the text to null to disable the title.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"middle")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Deprecated. Set the text to null to disable the title.")]
            public string Enabled
            {
                get
                {
                    return this.State.Get<string>("Enabled", @"middle");
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical")]
            public double? Margin
            {
                get
                {
                    return this.State.Get<double?>("Margin", null);
                }
                set
                {
                    this.State.Set("Margin", value);
                }
            }

            /// <summary>
            /// The distance of the axis title from the axis line. By default, this distance is  computed from the offset width of the labels, the labels' distance from  the axis and the title's margin. However when the offset option is set, it overrides all this.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance of the axis title from the axis line. By default, this distance is  computed from the offset width of the labels, the labels' distance from  the axis and the title's margin. However when the offset option is set, it overrides all this.")]
            public double? Offset
            {
                get
                {
                    return this.State.Get<double?>("Offset", null);
                }
                set
                {
                    this.State.Set("Offset", value);
                }
            }

            /// <summary>
            /// The rotation of the text in degrees. 0 is horizontal, 270 is vertical reading from bottom to top.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The rotation of the text in degrees. 0 is horizontal, 270 is vertical reading from bottom to top.")]
            public double? Rotation
            {
                get
                {
                    return this.State.Get<double?>("Rotation", 0);
                }
                set
                {
                    this.State.Set("Rotation", value);
                }
            }

            /// <summary>
            /// CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"{ ""color"": ""#707070"", ""fontWeight"": ""bold"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{ ""color"": ""#707070"", ""fontWeight"": ""bold"" }");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The actual text of the axis title. It can contain basic HTML text markup like &lt;b&gt;, &lt;i&gt; and spans with style.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The actual text of the axis title. It can contain basic HTML text markup like &lt;b&gt;, &lt;i&gt; and spans with style.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", "");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// Horizontal pixel offset of the title position.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal pixel offset of the title position.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", 0);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// Vertical pixel offset of the title position.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical pixel offset of the title position.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", null);
                }
                set
                {
                    this.State.Set("y", value);
                }
            }


    
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;


                list.Add("align", new ConfigOption("align", null, @"middle", this.Align));

                list.Add("enabled", new ConfigOption("enabled", null, @"middle", this.Enabled));

                list.Add("margin", new ConfigOption("margin", null, null, this.Margin));

                list.Add("offset", new ConfigOption("offset", null, null, this.Offset));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("style", new ConfigOption("style", null, @"{ ""color"": ""#707070"", ""fontWeight"": ""bold"" }", this.Style));

                list.Add("text", new ConfigOption("text", null, "", this.Text));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    

        }


        }

        
}
            