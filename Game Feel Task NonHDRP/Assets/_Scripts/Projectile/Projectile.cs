using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Projectile : MonoBehaviour
{
    public ProjectileStats _projectileStats;
    public System.Action<Projectile> IsDestroyed;
    public Rigidbody _RB;
    public MeshFilter _meshFilter;    
    public virtual void Awake(){
        _RB = GetComponent<Rigidbody>();
        _meshFilter = GetComponent<MeshFilter>();
    }
    public virtual void OnDisable() {
        if(IsDestroyed != null) IsDestroyed?.Invoke(this);
    }
    public virtual void OnEnable(){
        Debug.Log("Projectile is Spawned!");
    }

    public virtual void OnDestroy() {
        if(IsDestroyed != null) IsDestroyed?.Invoke(this);
    }

    public virtual void ProjectileMovement(){
        _RB.velocity = new Vector3(0, 0, -_projectileStats.speed);
    }
}
