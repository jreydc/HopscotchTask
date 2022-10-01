using EZCameraShake;

public class VFXManager : Singleton<VFXManager>
{
    public void CameraShakeFX(){
        CameraShaker.Instance.ShakeOnce(4f, 4f, 0f, 0.5f);
    }
}
