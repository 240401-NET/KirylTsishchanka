using BusinessLayer;
using ModelsLayer;
using RepoLayer;

namespace tests.api;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        
        // Arrange - create the enviromnent
        IRepositoryClass i = new MockRepoLayer();
        BusinessLayerClass bl = new BusinessLayerClass(i);

        //ACT
        List<Student> list = bl.GetStudentList();

        //Assert
        //Assert.Equal(list[0].FirstName, "m1");
        Assert.Equal(list[0].UserName, "m1");

    }
}