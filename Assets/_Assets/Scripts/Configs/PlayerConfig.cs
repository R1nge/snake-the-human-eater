using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "Player Config", menuName = "Configs/Player Config")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private float speed;
        public float Speed => speed;
    }
}