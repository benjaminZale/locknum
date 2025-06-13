using System.Runtime.InteropServices;

[DllImport("user32.dll")]
static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
static extern short GetKeyState(int keyCode);

const int VK_NUMLOCK = 0x90;

if(GetKeyState(VK_NUMLOCK) == 0)
{
    keybd_event(VK_NUMLOCK, 0, 0, 0);
}