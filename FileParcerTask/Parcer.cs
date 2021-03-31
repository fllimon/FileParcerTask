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

        #endregion

        public abstract void CountOccurrenceString(string filePath, string countingLine);

        public abstract bool ChangeStringInFile(string filePath, string searchString, string replaceString);

        protected virtual bool OnCountOccurance(string firstWord, string secondWord)
        {
            if (_countOccurrence != null)
            {
                _countOccurrence(this, new CountWordsEventArgs(firstWord, secondWord));
            }

            return firstWord.Equals(secondWord);
        }
    }
}
