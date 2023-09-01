using System.Drawing;
using System.Threading;

using System;

// External DLLS
using System.Runtime.InteropServices;
// process
using System.Diagnostics;


public class bas
{


    // basic implementacion
    // Screen change fc and bc 
    static public void Screen(ConsoleColor fore, ConsoleColor back)
    {
        Console.BackgroundColor = fore;
        Console.ForegroundColor = back;

    }

    static public void ForeColor(int value)
    {
        Console.ForegroundColor = (ConsoleColor)value;
    }

    static public void BackColor(int value)
    {
        Console.BackgroundColor = (ConsoleColor)value;
    }

    // Change console windows size
    static void ScreenSize(int width, int height)
    {
        if (height > Console.WindowHeight) return;
        if (width > Console.WindowWidth) return;

        Console.SetWindowSize(width, height);

    }

    // get Rows
    static int ScreenHeight()
    {
        int x = Console.WindowHeight;
        if (x < 1) x = 1;
        return x;
    }

    // get Cols
    static int ScreenWidth()
    {
        return Console.WindowWidth;
    }

    // Windows Title
    static public void ScreenTitle(string data)
    {
        Console.Title = data;
    }

    // Clear Screen
    static public void Cls()
    {
        Console.Clear();
    }

    // Locate cursor
    static public void Locate(int x, int y)
    {
        try
        {
            Console.SetCursorPosition(y, x);
        }
        catch
        {
            return;
        }
    }

    // Print
    static public void Print(string txt)
    {
        Console.Write(txt);
    }
    static public void Print(int txt)
    {
        Console.Write(txt);
    }

    // Wait
    static public void Wait()
    {
        //Locate(ScreenHeight(), 1);
        Console.Read();
    }

    // String functiones


        static public char Chr(int c)
    {
        return (char)c;
    }

    static public string Left(string txt, int c)
    {
        return txt.Substring(0, c);
    }

    static public string Right(string txt, int c)
    {
        return txt.Substring(txt.Length - c, c);
    }

    static public string Mid(string txt, int index, int c)
    {
        return txt.Substring(index, c);
    }

    static public string Replace(string txt, string oldstring, string newstring)
    {
        return txt.Replace(oldstring, newstring);
    }


}