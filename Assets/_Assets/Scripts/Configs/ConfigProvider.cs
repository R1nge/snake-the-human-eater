using _Assets.Scripts.Gameplay;
using UnityEngine;

namespace _Assets.Scripts.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private UIConfig uiConfig;
        [SerializeField] private GameConfig gameConfig;
        [SerializeField] private PlayerConfig playerConfig;
        [SerializeField] private EnemyController enemyController;
        public UIConfig UIConfig => uiConfig;
        public GameConfig GameConfig => gameConfig;
        public PlayerConfig PlayerConfig => playerConfig;
        public EnemyController EnemyController => enemyController;
    }
}