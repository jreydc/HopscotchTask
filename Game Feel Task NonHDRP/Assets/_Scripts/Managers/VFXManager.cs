using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class VFXManager : Singleton<VFXManager>
{
    [SerializeField]private GameObject projectile3ImpactVFXExplosion1;
    [SerializeField]private GameObject projectile3ImpactVFXExplosion2;
    [SerializeField]private GameObject projectile3ImpactVFXExplosion3;
    [SerializeField]private GameObject playerImpactVFXExplosion; 
    public void CameraShakeFX(){
        CameraShaker.Instance.ShakeOnce(4f, 4f, 0f, 0.5f);
    }

    public void Projectile3VFXExplosionPlay(Vector3 position){
        Instantiate(projectile3ImpactVFXExplosion1, position, Quaternion.identity);
        Instantiate(projectile3ImpactVFXExplosion2, position, Quaternion.identity);
    }

    public void PlayerVFXExplosionPlay(Vector3 position){
        Instantiate(playerImpactVFXExplosion, position, Quaternion.identity);
    }
}
