using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParcerTask
{
    public abstract class Parcer
    {
        #region ========------- PROTECTED DATA ---------========

        protected CountOccurrence _countOccurrence;
        protected ReplaceTextInFile _replaceTextInFile;

        #endregion

        #region =======------- EVENT'S -----=========

        public event CountOccurrence CountOccurrence
        {
            add
            {
                _countOccurrence += value;
            }
            remove
            {
                _countOccurrence -= value;
            }
        }

        public event ReplaceTextInFile ReplaceTextInFile
        {
            add
            {
                _replaceTextInFile += value;
            }
            remove
            {
                _replaceTextInFile -= value;
            }
        }

        #endregion

        public abstract void CountOccurrenceString(string filePath, string countingLine);

        public abstract void ChangeStringInFile(string filePath, string searchString, string replaceString);

        protected virtual void OnCountOccurance(string firstWord, string secondWord)
        {
            if (_countOccurrence != null)
            {
                _countOccurrence(this, new CountWordsEventArgs(firstWord, secondWord));
            }
        }

        protected virtual void OnCountReplaceString(string searchString, string replaceString)
        {
            if (_replaceTextInFile != null)
            {
                _replaceTextInFile(this, new ReplaceTextEventArgs(searchString, replaceString));
            }
        }
    }
}
