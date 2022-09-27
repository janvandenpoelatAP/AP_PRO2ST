namespace UnitTestingDependencies
{
    public class DieMock : IDie
    {
        private readonly int result;

        public DieMock(int result)
        {
            this.result = result;
        }

        public int Roll()
        {
            return result;
        }
    }
}
