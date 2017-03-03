using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.form
{
    class DialogLayerSelect
    {
        public static String showDialog(String title, List<String> layers) 
        {
            FormLayerSelect form = new FormLayerSelect(layers);
            form.Text = title;
            form.ShowDialog();
            return form.getSelectedValue();
        }
    }
}
