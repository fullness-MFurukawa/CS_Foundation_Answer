using Ex_03_11.Mosules;
namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        FlashMemory flashMemory = new FlashMemory();
        flashMemory.SendData();
        flashMemory.ReciveData();
        Mouse mouse = new Mouse();
        mouse.SendData();
        Display display = new Display();
        display.ReciveData();
    }
}
