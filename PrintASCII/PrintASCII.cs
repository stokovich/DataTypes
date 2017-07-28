using System;

class PrintASCII
{
    static void Main()
    {
        char asciimember;
        int pornumber = 33;

        for (int i = 0; i < 94; i++)
        {
            asciimember = (char)pornumber;
            Console.Write(asciimember);
            pornumber++;
        }
    }
}
