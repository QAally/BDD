using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using EAAutoFramework.Helpers;
using EAAutoFramework.Config;

namespace EAEmployeeTest.Hooks
{

    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }


        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

    }
}
