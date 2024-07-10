using WindowsProject.view; // 引入WindowsProject视图命名空间

namespace WindowsProject.implement // 定义实现命名空间
{
    internal static class Main1 // 定义一个内部静态类Main1
    {
        /// <summary>
        /// The main entry point for the application.
        /// 应用程序的主要入口点。
        /// </summary>
        [STAThread] // 属性，指示该方法是单线程单元（STA），允许使用Windows窗体等
        static void Main() // 主方法，程序执行的起点
        {
            ApplicationConfiguration.Initialize(); // 初始化应用程序配置

            Application.Run(new MainFrame()); // 运行应用程序，并传入主窗体MainFrame作为参数
        }
    }
}