using UnityEngine;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject projectile1ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile1ImpactVFXExplosion2;
    
    [SerializeField]private GameObject projectile3ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile3ImpactVFXExplosion2;
    [SerializeField]private GameObject projectile3ImpactVFXExplosion3;
     
    public void CameraShakeFX(){
        //CameraShaker.Instance.ShakeOnce(4f, 4f, 0f, 0.5f);
        CameraShaker._Instance.CameraShakeFunc();
    }

    public void Projectile1VFXExplosionPlay(Vector3 position){
        Instantiate(projectile1ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile1ImpactVFXExplosion2, position, Quaternion.identity);
    }

    public void Projectile3VFXExplosionPlay(Vector3 position){
        Instantiate(projectile3ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile3ImpactVFXExplosion2, position, Quaternion.identity);
    }

    
}
