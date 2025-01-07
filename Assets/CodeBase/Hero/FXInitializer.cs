using UnityEngine;

namespace CodeBase.Hero
{
    public class FXInitializer : MonoBehaviour
    {
        private const float SlashRotation = 220f;

        [SerializeField]
        private GameObject _fxSlash;
        [SerializeField]
        private GameObject _sword;

        public void OnAttackLast() => 
            PlaySlashAttack();

        private void PlaySlashAttack()
        {
            Quaternion swordRotation = _sword.transform.rotation;
            
            Quaternion adjustedRotation = Quaternion.Euler(0, swordRotation.eulerAngles.y + SlashRotation, 0);
            
            Instantiate(_fxSlash, _sword.transform.position, adjustedRotation);
        }
    }
}