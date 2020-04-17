namespace PerfectNumberGeneratorUI
{
    public partial class MainWindow
    {
        class SplitXML
        {
            public event ProgressBarEventHandler ProgressBarEvent;
            public void SplitFile(string filename)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (ProgressBarEvent != null)
                        ProgressBarEvent(i, 100);
                    Thread.Sleep(500);
                }
            }
        }

   
    }
}
