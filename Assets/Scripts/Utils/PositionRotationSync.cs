using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Utils
{
    public class PositionRotationSync : MonoBehaviour
    {
        public Vector3Variable positionVariable;
        public Vector3Variable rotationVariable;

        private void Update()
        {
            positionVariable.SetValue(transform.position);
            rotationVariable.SetValue(transform.rotation.eulerAngles);
        }
    }
}
