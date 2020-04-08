using UnityEngine;


namespace DefaultNamespace
{
    public sealed class Interactable : MonoBehaviour
    {
        [SerializeField] private VFXType _vfxType;
        [SerializeField] private float _hp;
        private ListVFX _listVfx;

        private void Awake()
        {
            _listVfx = Resources.Load<ListVFX>("VFXData");
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<IInteractable>(out var playerHp))
            {
                _listVfx.StartParticleSystem(_vfxType, transform.position, Quaternion.identity, transform);
                playerHp.SetValue(_hp);
            }
        }
    }
}
