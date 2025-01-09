using UnityEngine;

namespace CodeBase.Hero
{
    public class FXInitializer : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private GameObject _fxSlash;
        [SerializeField]
        private GameObject _fxSlashProjectile;
        [SerializeField]
        private GameObject _sword;

        private const float SlashRotation = 220f;
        private const float OffSetPosition = 2.5f;
        
        public void OnAttack() => 
            PlayFxAttack();

        private void OnAttackProjectile() => 
            InstantiateSlashProjectile();

        private void PlayFxAttack() => 
            InstantiatePrefab(_sword, _fxSlash, SlashRotation, 0f);

        private void InstantiateSlashProjectile() => 
            InstantiatePrefab(_fxSlash, _fxSlashProjectile, 0f, OffSetPosition);

        private void InstantiatePrefab(GameObject rotation, GameObject prefab, float slashRotation, float offSetPosition)
        {
            Quaternion rotationToInstantiate = rotation.transform.rotation;
            
            Quaternion adjustedRotation = Quaternion.Euler(0, rotationToInstantiate.eulerAngles.y + slashRotation, 0);
            
            Instantiate(prefab, rotation.transform.position + transform.forward * offSetPosition, adjustedRotation);
        }
    }
}