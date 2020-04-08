using UnityEngine;


namespace DefaultNamespace
{
    public sealed class PlayerHP : MonoBehaviour, IInteractable
    {
        [SerializeField] private float _hp;

        public void SetValue(float value)
        {
            _hp += value; // сделать доп проверки
        }
    }
}
