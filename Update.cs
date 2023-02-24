using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    static extern int UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll")]
    static extern IntPtr GetModuleHandle(string lpModuleName);

    const int WH_KEYBOARD_LL = 13;
    const int VK_SPACE = 0x20;
    const int WM_KEYDOWN = 0x0100;

    delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);

    static IntPtr hookHandle = IntPtr.Zero;

    static void Main()
    {
        hookHandle = SetHook(KeyboardProc);
        Console.ReadKey();
        UnhookWindowsHookEx(hookHandle);
    }

    static IntPtr SetHook(HookProc proc)
    {
        IntPtr hModule = GetModuleHandle(null);
        return SetWindowsHookEx(WH_KEYBOARD_LL, proc, hModule, 0);
    }

    static int KeyboardProc(int code, IntPtr wParam, IntPtr lParam)
    {
        if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            if (vkCode == VK_SPACE)
            {
                Console.WriteLine("Space bar is pressed");
            }
        }
        return CallNextHookEx(hookHandle, code, wParam, lParam);
    }
}