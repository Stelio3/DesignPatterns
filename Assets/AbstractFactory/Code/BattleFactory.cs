using Heroes;
using Weapons;

public class BattleFactory
{
    private readonly HeroFactory heroFactory;
    private readonly WeaponFactory weaponFactory;

    public BattleFactory(HeroFactory heroFactory, WeaponFactory weaponFactory)
    {
        this.heroFactory = heroFactory;
        this.weaponFactory = weaponFactory;
    }

    public Hero CreateHero(string heroId)
    {
        return heroFactory.Create(heroId);
    }

    public Weapon CreateWeapon(string weaponId)
    {
        return weaponFactory.Create(weaponId);
    }
}