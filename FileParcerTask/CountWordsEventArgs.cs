using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParcerTask
{
    public class CountWordsEventArgs : EventArgs
    {
        #region =======-------- PRIVATE DATA ---------=========

        private string _firstString;
        private string _secondString;

        #endregion

        public CountWordsEventArgs(string firstString, string secondString)
        {
            _firstString = firstString;
            _secondString = secondString;
        }
    }
}
