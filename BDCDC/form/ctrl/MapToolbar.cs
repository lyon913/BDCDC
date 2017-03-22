using BDCDC.Properties;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDCDC.form.ctrl
{
    public partial class MapToolbar : ToolStrip
    {
        private AxMapControl mapControl;

        public MapToolbar()
        {
            InitializeComponent();
            init();
        }

        public void setMapControl(AxMapControl mapControl)
        {
            this.mapControl = mapControl;
        }

        private void init()
        {
            addButton("放    大", Resources.arcgis_ZoomInTool_B_32, zoomIn_click);
            addButton("缩    小", Resources.arcgis_ZoomOutTool_B_32, zoomOut_click);
            addButton("显示全图", Resources.ZoomFullExtentCross32, fullExtend_click);
            addButton("移    动", Resources.arcgis_PanTool32, pan_click);
            addSeparator();
            addButton("清空选择", Resources.arcgis_SelectionClearSelection_B_32, clearSelection_click);
            addButton("缩放到选择", Resources.arcgis_SelectionZoomToHighlighted32, zoomToSelection_click);
            addButton("选择图形", Resources.arcgis_SelectionSelectTool32, selectFeature_click);
            addSeparator();
            this.ImageScalingSize = new Size(32, 32);
        }

        public void addButton(String text, Image image, EventHandler handler)
        {
            this.Items.Add(generateButton(text, image, handler));
        }

        public void addSeparator()
        {
            this.Items.Add(new ToolStripSeparator());
        }

        private ToolStripButton generateButton(String text,Image image,EventHandler handler)
        {
            ToolStripButton button = new ToolStripButton(text, image,handler);
            button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            button.TextImageRelation = TextImageRelation.ImageAboveText;

            return button;
        }

        private void zoomIn_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }

        private void zoomOut_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomOutTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }

        private void fullExtend_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapFullExtentCommand();
            cmd.OnCreate(this.mapControl.Object);
            cmd.OnClick();
        }

        private void pan_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapPanTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }

        private void selectFeature_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsSelectFeaturesTool();
            cmd.OnCreate(this.mapControl.Object);
            this.mapControl.CurrentTool = cmd as ITool;
        }

        private void clearSelection_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsClearSelectionCommand();
            cmd.OnCreate(this.mapControl.Object);
            cmd.OnClick();
        }

        private void zoomToSelection_click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsZoomToSelectedCommand();
            cmd.OnCreate(this.mapControl.Object);
            cmd.OnClick();
        }
    }
}
