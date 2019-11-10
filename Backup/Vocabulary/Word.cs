using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vocabulary
{
    class Word
    {
        public string En, CN;
        public Word(string En, string CN)
        {
            this.En = En;
            this.CN = CN;
        }
        public override bool Equals(object obj)
        {
            Word word2=(Word) obj;
            return this.En.Equals(word2.En);
        }
        public override int GetHashCode()
        {
            return this.En.GetHashCode();
        }
    }
}
