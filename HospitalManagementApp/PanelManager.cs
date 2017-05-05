using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementApp
{
    class PanelManager
    {
        List<Panel> panels;
        public PanelManager(List<Panel> panels)
        {
            this.panels = panels;
            foreach (Panel panel in panels){
                panel.Hide();
                panel.Dock = DockStyle.Fill;
            }
        }
        public void HideAllPanel()
        {
            foreach (Panel panel in panels)
            {
                panel.Hide();
            }
        }
        public void ShowPanel(int index)
        {
            for(int i = 0; i < panels.Count; i++)
            {
                if (i == index) panels[i].Show();
                else panels[i].Hide();
            }
        }

    }
}
