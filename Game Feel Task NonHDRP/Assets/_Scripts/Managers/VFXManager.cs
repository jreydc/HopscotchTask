using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject projectile1ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile1ImpactVFXExplosion2;

    [SerializeField]private GameObject projectile2ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile2ImpactVFXExplosion2;
    
    [SerializeField]private GameObject projectile3ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile3ImpactVFXExplosion2;
    
     
    public void CameraShakeFX(){
        CameraShaker._Instance.CameraShakeFunc();
    }

    public void Projectile1VFXExplosionPlay(Vector3 position){
        Instantiate(projectile1ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile1ImpactVFXExplosion2, position, Quaternion.identity);
    }

    public void Projectile2VFXExplosionPlay(Vector3 position){
        Instantiate(projectile2ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile2ImpactVFXExplosion2, position, Quaternion.identity);
    }

    public void Projectile3VFXExplosionPlay(Vector3 position){
        Instantiate(projectile3ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile3ImpactVFXExplosion2, position, Quaternion.identity);
    }

    
}
