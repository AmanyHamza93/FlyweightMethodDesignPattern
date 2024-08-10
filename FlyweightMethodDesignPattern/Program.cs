using FlyweightMethodDesignPattern;


for (int i = 0; i < 10; i++)
{
    var y = ConterStrike.GetRandPlayerType();

    IPlayer player = PlayerFactory.GetPlayer(y);
    var x = ConterStrike.GetRandWeapon();
    player.AssignWeapon(x);
    player.Mession();
}