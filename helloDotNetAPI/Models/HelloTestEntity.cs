namespace helloDotNetAPI.Models
{
    public class HelloTestEntity
    {
        public string TestProperty { get; set; }

        public string ReturnTestPropertyForUnitTest()
        {
            return TestProperty;
        }
    }
}