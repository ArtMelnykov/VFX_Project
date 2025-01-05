using UnityEngine;

namespace CodeBase.Hero
{
    public class HeroAnimator : MonoBehaviour
    {
        private static readonly int Attack = Animator.StringToHash("Attack01");
        
        private Animator _animator;

        private void Awake() => 
            _animator = GetComponent<Animator>();

        public void PlayAttack() => 
            _animator.SetTrigger(Attack);
    }
}