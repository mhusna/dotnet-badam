using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GaleriBLL
    {
        //Context _context;
        public GaleriBLL()
        {
            // Tightly Coupling
            // _context = new Context();

            ArabaManager = new ArabaManager();
            MarkaManager = new MarkaManager();
            ModelManager = new ModelManager();
        }
        public ArabaManager ArabaManager { get; set; }
        public MarkaManager MarkaManager { get; set; }
        public ModelManager ModelManager { get; set; }
    }
}
