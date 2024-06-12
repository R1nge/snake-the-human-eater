using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace _Assets.Scripts.Services.Factories
{
    public class EnemyFactory
    {
        private readonly IObjectResolver _objectResolver;
        private readonly ConfigProvider _configProvider;

        private EnemyFactory(IObjectResolver objectResolver,ConfigProvider configProvider)
        {
            _objectResolver = objectResolver;
            _configProvider = configProvider;
        }

        public EnemyController Create(Vector3 position)
        {
            return _objectResolver.Instantiate(_configProvider.EnemyController, position, Quaternion.identity);
        }
    }
}