using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FileParcerTask;

namespace FileParcerView
{
    class Analyzer
    {
        #region =========-------- PRIVATE DATA ---------==========

        private int _countWords = 0;
        private int _countReplacetext = 0;
        private readonly Parcer _fileParcer;

        #endregion

        #region =======-------- CTOR -------=========

        public Analyzer(Parcer fileParcer)
        {
            _fileParcer = fileParcer;

            _fileParcer.CountOccurrence += GetCountWords;
            _fileParcer.ReplaceTextInFile += GetCountTextReplace;
        }

        #endregion

        #region ======------ PROPERTIES ------=====

        public int CountWords
        {
            get
            {
                return _countWords;
            }
        }

        public int CountTextReplace
        {
            get
            {
                return _countReplacetext;
            }
        }

        #endregion

        private void GetCountWords(object sender, CountWordsEventArgs args)
        {
            _countWords++;
        }

        private void GetCountTextReplace(object sender, ReplaceTextEventArgs args)
        {
            _countReplacetext++;
        }
    }
}
