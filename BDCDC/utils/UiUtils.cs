using BDCDC.model;
using BDCDC.service;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BDCDC.utils
{
    class UiUtils
    {
        public static void comboboxDataItems(ComboBox cb,string itemType,bool formated)
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

        public static void comboboxDataItems(ComboBox cb, List<DataItems> items, bool formated)
        {
            if (formated)
            {
                formatItemName(items);
            }
            cb.DataSource = items;
            cb.DisplayMember = "itemName";
            cb.ValueMember = "itemCode";
        }

        public static void dataGridComboboxDataItems(DataGridViewComboBoxColumn cb, string itemType, bool formated)
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

        public static void dgvValidateAndEndEdit(DataGridView dgv)
        {
            DataGridViewCell cell = dgv.CurrentCell;
            dgv.CurrentCell = null;
            dgv.CurrentCell = cell;
            dgv.EndEdit();
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

        public static void alertException(IWin32Window owner, Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string cbSelectedValueToString(ComboBox cb)
        {
            if(cb.SelectedValue == null)
            {
                return null;
            }
            else
            {
                return cb.SelectedValue.ToString();
            }
        }


        public static void dgvAddHeaderCheckBox(DataGridView dgv)
        {

        }
    }
}
