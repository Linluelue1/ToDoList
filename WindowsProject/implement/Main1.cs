using WindowsProject.view; // ����WindowsProject��ͼ�����ռ�

namespace WindowsProject.implement // ����ʵ�������ռ�
{
    internal static class Main1 // ����һ���ڲ���̬��Main1
    {
        /// <summary>
        /// The main entry point for the application.
        /// Ӧ�ó������Ҫ��ڵ㡣
        /// </summary>
        [STAThread] // ���ԣ�ָʾ�÷����ǵ��̵߳�Ԫ��STA��������ʹ��Windows�����
        static void Main() // ������������ִ�е����
        {
            ApplicationConfiguration.Initialize(); // ��ʼ��Ӧ�ó�������

            Application.Run(new MainFrame()); // ����Ӧ�ó��򣬲�����������MainFrame��Ϊ����
        }
    }
}