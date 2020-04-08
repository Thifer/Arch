using System;
using Cinemachine;
using UnityEngine;


namespace DefaultNamespace
{
    public sealed class TestCinemachine : MonoBehaviour
    {
        [SerializeField] private CinemachineImpulseSource _objectToCheck;
        [SerializeField] private CinemachineVirtualCameraBase _switchCameraTo;
        private CinemachineBrain _cinemachineBrain;
        private float _distanceToObject;
        [SerializeField] private CinemachineTargetGroup _targetGroup;
        
        private void Start()
        {
            _distanceToObject = _objectToCheck.m_ImpulseDefinition.m_DissipationDistance;
            foreach (var targetGroupMTarget in _targetGroup.m_Targets)
            {
                Debug.Log(targetGroupMTarget.target.name);
            }

            // _targetGroup.m_Targets.Add(target);
            
            _cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();
            if (!_cinemachineBrain.ActiveVirtualCamera.Name.Equals(_switchCameraTo.Name))
            {
                --_cinemachineBrain.ActiveVirtualCamera.Priority; 
            }

            
        }
        
        public class A
        {
            public void OnDoWork()
            {
                if ( DoWork != null )
                    DoWork(this, EventArgs.Empty);
            }

            public event EventHandler DoWork;
        }
    }
}
