using Sample.Interfaces;

namespace Sample.Implementations
{
    public class SampleController:ISampleController
    {
        public string[] Get()
        {
            return Get(6);
        }

        public string[] Get(int id)
        {
            return new []{"Sample", "Sample2", id.ToString()};
        }
    }
}