using UnityEngine;

namespace CodeBase.Skeleton
{
    public class SkeletonAnimator : MonoBehaviour
    {
        private static readonly int Attack = Animator.StringToHash("Attack");
        
        private Animator _animator;

        private void Awake() => 
            _animator = GetComponent<Animator>();

        public void PlayAttack() => 
            _animator.SetTrigger(Attack);
    }
}