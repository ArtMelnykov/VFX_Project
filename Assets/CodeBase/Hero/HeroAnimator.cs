using UnityEngine;

namespace CodeBase.Hero
{
    [RequireComponent(typeof(Animator))]
    public class HeroAnimator : MonoBehaviour
    {
        [Header("Parameters")]
        private static readonly int Attack = Animator.StringToHash("Attack01");
        private Animator _animator;

        private void Awake() => 
            _animator = GetComponent<Animator>();

        public void PlayAttack() => 
            _animator.SetTrigger(Attack);
    }
}