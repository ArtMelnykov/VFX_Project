using UnityEngine;

namespace CodeBase.SlashLogic
{
    public class SlashMover : MonoBehaviour
    {
        [SerializeField]
        private float _speed;
        private Rigidbody _rigidbody;

        private void Start() => 
            _rigidbody = GetComponent<Rigidbody>();

        private void Update() => 
            MoveForward();

        private void MoveForward() => 
            _rigidbody.AddForce(transform.forward * _speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}