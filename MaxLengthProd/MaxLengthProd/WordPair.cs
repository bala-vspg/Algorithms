namespace MaxLengthProd
{
    public class WordPair
    {
        private string _word1;
        string _word2;

        public string Word1
        {
            get { return _word1; }
            set { _word1 = value; }
        }

        public string Word2
        {
            get { return _word2; }
            set { _word2 = value; }
        }

        public int Lengthprod { get; set; }

        public WordPair(string w1, string w2)
        {
            _word1 = w1;
            _word2 = w2;
            if(_word1!=null && _word2!=null)
            Lengthprod = _word1.Length*_word2.Length;
            else
            {
                Lengthprod = 0;
            }
        }
    }
}