namespace Laboratory_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var part_2_4 = new Part_2_4(4, 4);
            
            part_2_4.Do();
            
            var part_3_4 = new Part_3_4("язык", "C# - объектно-ориентированный язык программирования общего назначения.\nРазработан в 1998–2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework и .NET Core.");
            
            part_3_4.Do();
            
            var part_4_4 = new Part_4_4("Настало утро. Начинался очередной день.");
            
            part_4_4.Do();
        }
    }
}