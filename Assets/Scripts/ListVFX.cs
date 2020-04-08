using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "VFXData", menuName = "Data/VFXData")]
    public sealed class ListVFX : ScriptableObject
    {
        [SerializeField] private VFXData[] _vfxsData;

        public void StartParticleSystem(VFXType type, Vector3 position, Quaternion rotation, Transform root)
        {
            foreach (var vfxData in _vfxsData)
            {
                if (vfxData.Type == type)
                {
                    var particleSystemInstance = Instantiate(vfxData.Prefab, position, rotation, root);
                    particleSystemInstance.Play();
                    Destroy(particleSystemInstance.gameObject, particleSystemInstance.main.duration);
                }
            }
        }
    }
}
