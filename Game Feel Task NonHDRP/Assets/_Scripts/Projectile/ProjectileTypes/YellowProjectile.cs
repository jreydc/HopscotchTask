using UnityEngine;

public class YellowProjectile : Projectile
{
    [SerializeField]private Transform _spawnPosition;
    public override void Awake()
    {
        base.Awake();
    }
    
    public override void OnDisable() {
        base.OnDisable();
        DestroyedProjectile();
    }

    void Update()
    {
        ProjectileMovement();    
    }

    private void OnTriggerEnter(Collider other) {
        ObjectPooler._Instance.ReturnToPool(gameObject);
        ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", _spawnPosition.position, transform.localScale);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
