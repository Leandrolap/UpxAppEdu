using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpxAppEdu.Service
{
    public class DBLocal
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string Email
        {
            get => AppSettings.GetValueOrDefault(nameof(Email), "");

            set => AppSettings.AddOrUpdateValue(nameof(Email), value);

        }

        public static string NomedoUsuario
        {
            get => AppSettings.GetValueOrDefault(nameof(NomedoUsuario), "");

            set => AppSettings.AddOrUpdateValue(nameof(NomedoUsuario), value);

        }

        public static string NomeImagem
        {
            get => AppSettings.GetValueOrDefault(nameof(NomeImagem), "");

            set => AppSettings.AddOrUpdateValue(nameof(NomeImagem), value);
        }

        public static string Senha
        {
            get => AppSettings.GetValueOrDefault(nameof(Senha), "");

            set => AppSettings.AddOrUpdateValue(nameof(Senha), value);
        }

        public static string Contato02
        {
            get => AppSettings.GetValueOrDefault(nameof(Contato02), "");

            set => AppSettings.AddOrUpdateValue(nameof(Contato02), value);
        }
    }
}
