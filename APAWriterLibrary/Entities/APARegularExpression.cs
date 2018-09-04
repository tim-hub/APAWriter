

namespace APAWriterLibrary.Entities
{
    abstract class APARegularExpression
    {
        protected string re;

        public APARegularExpression(string re)
        {
            this.re = re;
        }
        public abstract string Replace(string content);

    }
}
