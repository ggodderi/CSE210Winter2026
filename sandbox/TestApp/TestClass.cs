
class TestClass
{
    private double _data;
    public TestClass()
    {
        _data = 0;
    }
    public TestClass(double data)
    {
        _data = data;
    }

    public TestClass(float data2)
    {
        _data = data2;
    }

    public double GetData()
    {
        return _data;
    }
}