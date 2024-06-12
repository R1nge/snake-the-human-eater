using UnityEngine;

namespace _Assets.Scripts.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private UIConfig uiConfig;
        [SerializeField] private GameConfig gameConfig;
        [SerializeField] private PlayerConfig playerConfig;
        public UIConfig UIConfig => uiConfig;
        public GameConfig GameConfig => gameConfig;
        public PlayerConfig PlayerConfig => playerConfig;
    }
}