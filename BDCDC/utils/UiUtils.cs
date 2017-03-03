using BDCDC.model;
using BDCDC.service;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.utils
{
    class UiUtils
    {
        public static void comboboxDataItems(ComboBox cb,String itemType,bool formated)
        {
            DataItemsService service = new DataItemsService();
            List<DataItems> items = service.getItemsByType(itemType);
            if (formated)
            {
                formatItemName(items);
            }
            cb.DataSource = items;
            cb.DisplayMember = "itemName";
            cb.ValueMember = "itemCode";
        }

        //格式化标准项下拉列表
        public static void formatItemName(List<DataItems> list)
        {
            foreach (DataItems item in list)
            {
                item.itemName = item.itemName + "(" + item.itemCode + ")";
            }
        }

        public static void initArcgisToolbar(AxToolbarControl toolbar)
        {
            toolbar.AddItem("esriControls.ControlsMapZoomInTool", -1, -1, true, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapZoomOutTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapFullExtentCommand", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapPanTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsFeatureSelectionToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapIdentifyTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
        }

        public static void initArcgisEditToolbar(AxToolbarControl toolbar)
        {
            toolbar.AddItem("esriControls.ControlsMapZoomInTool", -1, -1, true, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapZoomOutTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapFullExtentCommand", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapPanTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsFeatureSelectionToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsMapIdentifyTool", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
            toolbar.AddItem("esriControls.ControlsEditingToolbar", -1, -1, false, 0, esriCommandStyles.esriCommandStyleIconOnly);
        }
    }
}
