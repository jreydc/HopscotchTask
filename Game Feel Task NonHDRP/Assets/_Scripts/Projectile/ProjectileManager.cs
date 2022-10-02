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
    public Transform gameStartSpawningPosition1;
    public Transform gameStartSpawningPosition2;
    public Transform gameStartSpawningPosition3;
    [SerializeField]private Transform _spawnPosition;

    public void GameStartSpawn(){
        ObjectPooler._Instance.FillThePoolCollection();
        var yellowProjectile = ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", gameStartSpawningPosition1.position, ObjectPooler._Instance.pools[0].prefab.transform.localScale);
        var blueProjectile = ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", gameStartSpawningPosition2.position, ObjectPooler._Instance.pools[1].prefab.transform.localScale);
        var redProjectile = ObjectPooler._Instance.GetObjectFromPool("RedProjectile", gameStartSpawningPosition3.position, ObjectPooler._Instance.pools[2].prefab.transform.localScale);

        yellowProjectile.transform.SetParent(gameStartSpawningParent);
        blueProjectile.transform.SetParent(gameStartSpawningParent);
        redProjectile.transform.SetParent(gameStartSpawningParent);
    }

    public Projectile YellowProjectileSpawner(){
        var yellowProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", _spawnPosition.position, transform.localScale);
        Projectile yellowProjectile = yellowProjectileOBJ.GetComponent<Projectile>();

        return yellowProjectile;
    }

    public Projectile BlueProjectileSpawner(){
        var yellowProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", _spawnPosition.position, transform.localScale);
        Projectile yellowProjectile = yellowProjectileOBJ.GetComponent<Projectile>();

        return yellowProjectile;
    }

    public Projectile YRedProjectileSpawner(){
        var yellowProjectileOBJ = ObjectPooler._Instance.GetObjectFromPool("RedProjectile", _spawnPosition.position, transform.localScale);
        Projectile yellowProjectile = yellowProjectileOBJ.GetComponent<Projectile>();

        return yellowProjectile;
    }
}
