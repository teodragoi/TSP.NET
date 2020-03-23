namespace Lab1
{
    public class Counter
    {
        private int limit;
        private int totalCount = 0;

        public Counter(int _limit)
        {
            limit = _limit;
        }

        public void Increase()
        {
            totalCount++;
        }
    }
}
