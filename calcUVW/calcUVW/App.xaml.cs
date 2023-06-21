using calcUVW.pages;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            /*
             * Usando como "preferência" as cores para cada parte do layout
             * Ao invés de usar como recurso do aplicativo, use o método Get
             * No método Get, é buscado o nome da variável, junto com o valor padrão (pré-definido)
             * Se a variável ainda não existe, vai usar o valor padrão
             * Considere usar tema claro ou tema escuro como um padrão
             * Depois o usuário pode escolher como quiser
             */
            string ButtonBackgroundColor = Preferences.Get("ButtonBackgroundColor", "#58B8F9");

            /*
             * Salvando como "preferência" as cores para cada parte do layout
             * Ao invés de usar como recurso do aplicativo, use o método Set
             * No método Set, é informado o nome da variável e seu valor
             * Quando for usado o método Get, retornará o último valor salvo
             * O método Set será usado quando o usuário trocar de tema
             * AppShell.themeChanged_Clicked (linha 27)
             */
            Preferences.Set("ButtonBackgroundColor", "#0E76BC");
            
            if ((int)Current.Properties["tema"] == 2)
            {
                Current.UserAppTheme = OSAppTheme.Dark;
            }
            else if ((int)Current.Properties["tema"] == 1)
            {
                Current.UserAppTheme = OSAppTheme.Light;
            }
            else
            {
                Current.UserAppTheme = OSAppTheme.Unspecified;
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
