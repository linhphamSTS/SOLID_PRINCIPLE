namespace SingleReponsibilityPrinciple
{
    internal class ClassA
    {
    }

    internal class ClassB
    {
    }

    internal class Sample // High Level
    {
        private ClassA a = new ClassA(); // Low level
        private ClassB b = new ClassB(); //Low level

        public Sample()
        {
        }
    }
}