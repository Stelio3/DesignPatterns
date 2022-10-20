using System;
using Heroes;
using UnityEngine;
using Weapons;

public class GameInstaller : MonoBehaviour
{
    [SerializeField] private HeroesConfiguration heroesConfiguration;
    [SerializeField] private WeaponsConfiguration weaponsConfiguration;
    [SerializeField] private WeaponsConfiguration halloweenWeaponsConfiguration;
    private Consumer consumer;
    private BattleFactory battleFactory;
    private BattleFactory halloweenBattleFactory;

    private void Start()
    {
        var heroFactory = new HeroFactory(Instantiate(heroesConfiguration));
        var weaponFactory = new WeaponFactory(Instantiate(weaponsConfiguration));
        var halloweenWeaponFactory = new WeaponFactory(Instantiate(halloweenWeaponsConfiguration));
        
        var consumerGameObject = new GameObject();
        consumer = consumerGameObject.AddComponent<Consumer>();
        
        battleFactory = new BattleFactory(heroFactory, weaponFactory);
        halloweenBattleFactory = new BattleFactory(heroFactory, halloweenWeaponFactory);
        consumer.Configure(battleFactory);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            consumer.Configure(halloweenBattleFactory);
        }
    }
}
