using Services;
using Services.Input;
using UnityEngine;

namespace Zenject
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInput();
        }

        private void BindInput()
        {
            if (AppStaticData.IsMobilePlatform)
            {
                Container.Bind<IInputControlService>().To<MobileControlInput>().AsSingle().NonLazy();
            }
            else
            {
                Container.Bind<IInputControlService>().To<StandaloneControlInput>().AsSingle().NonLazy();
            }
        }
    }
}