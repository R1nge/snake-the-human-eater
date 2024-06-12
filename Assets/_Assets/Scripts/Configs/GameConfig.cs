using UnityEngine;

namespace _Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "Game Config", menuName = "Configs/Game Config")]
    public class GameConfig : ScriptableObject
    {
        [SerializeField] private GameObject playerPrefab;
        public GameObject PlayerPrefab => playerPrefab;
    }
}