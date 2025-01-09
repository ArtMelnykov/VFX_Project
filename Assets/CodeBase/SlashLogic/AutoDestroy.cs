using UnityEngine;

namespace CodeBase.SlashLogic
{
    public class AutoDestroy : MonoBehaviour
    {
        [SerializeField]
        private float _lifeTime;

        private void Update() => 
            Destroy(gameObject, _lifeTime);
    }
}