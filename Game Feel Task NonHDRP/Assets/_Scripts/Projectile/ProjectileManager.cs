using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    #region ProjectileManager SingleInstance
    private static ProjectileManager _instance;
    public static ProjectileManager _Instance{ 
        get { return _instance; }
        private set{}
    }
    private void Awake() => _instance = this;
    #endregion
    
    public Transform gameStartSpawningParent;
    public Transform projectileSpawningPosition1;
    public Transform projectileSpawningPosition2;
    public Transform projectileSpawningPosition3;  


    public void GameStartSpawn(){
        ObjectPooler._Instance.FillThePoolCollection();

        var yellowProjectile = ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", projectileSpawningPosition1.position, ObjectPooler._Instance.pools[0].prefab.transform.localScale);
        var blueProjectile = ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", projectileSpawningPosition2.position, ObjectPooler._Instance.pools[1].prefab.transform.localScale);
        var redProjectile = ObjectPooler._Instance.GetObjectFromPool("RedProjectile", projectileSpawningPosition3.position, ObjectPooler._Instance.pools[2].prefab.transform.localScale);

        yellowProjectile.transform.SetParent(gameStartSpawningParent);
        blueProjectile.transform.SetParent(gameStartSpawningParent);
        redProjectile.transform.SetParent(gameStartSpawningParent);
    }

    public Projectile YellowProjectileSpawner(){
        ObjectPooler._Instance.poolDictionary["YellowProjectile"].Dequeue();
        var yellowProjectileScale = ObjectPooler._Instance.pools[0].prefab.transform.localScale;
        var yellowProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", projectileSpawningPosition1.position, yellowProjectileScale);
        Projectile yellowProjectile = yellowProjectileOBJ.GetComponent<Projectile>();

        return yellowProjectile;
    }

    public Projectile BlueProjectileSpawner(){
        var blueProjectileScale = ObjectPooler._Instance.pools[1].prefab.transform.localScale;
        var blueProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", projectileSpawningPosition2.position, blueProjectileScale);
        Projectile yellowProjectile = blueProjectileOBJ.GetComponent<Projectile>();

        return yellowProjectile;
    }

    public Projectile RedProjectileSpawner(){
        var redProjectileScale = ObjectPooler._Instance.pools[2].prefab.transform.localScale;
        var redProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("RedProjectile", projectileSpawningPosition3.position, redProjectileScale);
        Projectile redProjectile = redProjectileOBJ.GetComponent<Projectile>();

        return redProjectile;
    }
}
