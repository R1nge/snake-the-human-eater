using UnityEngine;

namespace _Assets.Scripts.Services
{
    public class CameraService : MonoBehaviour
    {
        [SerializeField] private new Camera camera;
        public Camera Camera => camera;
    }
}