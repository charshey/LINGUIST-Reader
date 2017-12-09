using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// Class DBFlowLayoutPanel is custom class inheriting from FlowLayoutPanel in order to implement DoubleBuffered property.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.FlowLayoutPanel" />
    class DBFlowLayoutPanel : FlowLayoutPanel 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBFlowLayoutPanel"/> class.
        /// </summary>
        public DBFlowLayoutPanel()
        {
            // set doublebuffered to true
            this.DoubleBuffered = true;
        }
    }
}
