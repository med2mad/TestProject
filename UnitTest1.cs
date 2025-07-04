
using Moq;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Mock<IT> mock1 = new();

        //mock1.Setup(x => x.F(It.IsAny<int>())).Returns(5);
        //Assert.Equal(5, mock1.Object.F(1));

        //mock1.Setup(x => x.F(It.IsAny<int>())).Throws<Exception>();
        //Assert.Throws<Exception>(()=>mock1.Object.F(0));

        mock1.Object.F(4);
        mock1.Verify(x => x.F(It.IsAny<int>()), Times.AtLeast(2));


    }
}


public class IT
{
    public virtual int F(int a)
    {
        Console.WriteLine("ewq");
        return a;
    }
}