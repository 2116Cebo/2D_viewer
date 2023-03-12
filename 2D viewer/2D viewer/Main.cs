using _2D_viewer;
Console.Title = "2D-VIEWER";
Maker maker = new Maker();
while (true)
{
    try
    {
        Console.Write("x1 > ");
        maker.x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y1 > ");
        maker.y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("z1 > ");
        maker.z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("x2 > ");
        maker.x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y2 > ");
        maker.y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("z2 > ");
        maker.z2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR : " + ex);
    }
    maker.Write_C(maker.x1, maker.x2, maker.y1, maker.y2, maker.z1, maker.z2);
    try
    {
        Console.WriteLine("Restart ?");
        string choose = Console.ReadLine();
        if (choose == "yes")
        {
            Console.Clear();
        }
        else
        {
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR : " + ex);
        break;
    }
}
Console.Read();
