using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParcerTask
{
    public class ReplaceTextEventArgs : EventArgs
    {
        #region =======-------- PROPERTIES --------=========

        public string TextBeforeReplace { get; private set; }

        public string TextAfterReplace { get; private set; }

        #endregion

        #region =========----- CTOR -------=======

        public ReplaceTextEventArgs(string serchString, string replaceString)
        {
            TextBeforeReplace = serchString;
            TextAfterReplace = replaceString;
        }

        #endregion
    }
}
