namespace Game.Specs;

public class Ship_Should
{
    /*
Ship_Should
    - Construct_With_Length
    - Construct_With_Location
    - Construct_With_Default_Status_Undamaged
    */
}
public class ShipProfile_Should
{
    /*
    ShipProfile_Should
    - 
    - 
    - Construct_As_Not_Placed_On_A_Grid
    */
    [Fact]
    public void Construct_With_Undamaged_ShipStatus_By_Default()
    {
        ShipProfile sut = new("Sub", 3);
        sut.Status.Should().Be(ShipStatus.Undamaged);
    }
    [Fact]
    public void Construct_Without_A_Placed_Ship()
    {
        ShipProfile sut = new("Sub", 3);
        sut.Ship.Should().BeNull();
    }
}
