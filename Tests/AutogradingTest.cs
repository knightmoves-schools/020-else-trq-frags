namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Create_A_Method_Named_CalculateAward_That_Takes_One_Parameter_Points_And_Returns_The_String_First_Place_When_Points_Are_Over_99(){
        var awarder = new Awarder();
        Assert.Equal("First Place", awarder.CalculateAward(100));
    }

    [Fact]
    public void Should_Return_The_String_Second_Place_From_CalculateAward_When_Points_Are_Over_49_And_Under_100(){
        var awarder = new Awarder();
        Assert.Equal("Second Place", awarder.CalculateAward(50));
        Assert.Equal("Second Place", awarder.CalculateAward(99));
    }

    [Fact]
    public void Should_Return_The_String_Participation_Award_From_CalculateAward_For_Everything_Else(){
        var awarder = new Awarder();
        Assert.Equal("Participation Award", awarder.CalculateAward(49));
        Assert.Equal("Participation Award", awarder.CalculateAward(1));
        Assert.Equal("Participation Award", awarder.CalculateAward(-1));
    }
}