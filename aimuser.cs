using LowLevelInput.Hooks;
using System;
using System.Windows.Forms;
using VoidSharp.Other;
using VoidSharp.Cheat;
using System.Drawing;
using System.Threading;

namespace VoidSharp
{
    public partial class aimuser : UserControl
    {
        private static readonly InputManager InputManager = new InputManager();
        public aimuser()
        {
            InitializeComponent();
        }

        private void aimuser_Load(object sender, EventArgs e)
        {
            InputManager.Initialize();
            InputManager.OnKeyboardEvent += InputManager_OnKeyboardEvent;
            if (hodnoty.SelectedChamp != null)
            {
                championnamelbl.Text = hodnoty.SelectedChamp;
            }
            else
            {
                championnamelbl.Text = "Champion isn´t selected";
            }
        }

        private void labeltimer_Tick(object sender, EventArgs e)
        {
             if(hodnoty.SelectedChamp != null)
             championnamelbl.Text = hodnoty.SelectedChamp;
        }
        public void InputManager_OnKeyboardEvent(VirtualKeyCode key, KeyState state)
        {
            if (key == VirtualKeyCode.Q && cbQ.Checked == true)
            {
                switch (state)
                {
                    case KeyState.Down:
                        InputKeys.Keyboard.KeyDown((ushort)DirectInputKeys.DIK_1);
                        break;
                    case KeyState.Up:
                        Point p = Cursor.Position;
                        calls.DoThing("FindEnemy", hodnoty.XerathQ, new Point(0, 0));
                        InputKeys.Keyboard.KeyUp((ushort)DirectInputKeys.DIK_1);
                        calls.Wait(5);
                        Cursor.Position = p;
                        calls.Wait(20);
                        break;
                }
            }
            if (key == VirtualKeyCode.W && cbW.Checked == true)
            {
                switch (state)
                {
                    case KeyState.Down:
                        Point p = Cursor.Position;
                        calls.DoThing("FindEnemy", hodnoty.XerathW, new Point(0, 0));
                        InputKeys.Keyboard.KeyDown((ushort)DirectInputKeys.DIK_2);
                        calls.Wait(5);
                        Cursor.Position = p;
                        calls.Wait(20);
                        break;
                    case KeyState.Up:
                        InputKeys.Keyboard.KeyUp((ushort)DirectInputKeys.DIK_2);
                        break;
                }
            }
            if (key == VirtualKeyCode.E && cbE.Checked == true)
            {
                switch (state)
                {
                    case KeyState.Down:
                        Point p = Cursor.Position;
                        calls.DoThing("FindEnemy", hodnoty.XerathE, new Point(0, 0));
                        InputKeys.Keyboard.KeyDown((ushort)DirectInputKeys.DIK_3);
                        calls.Wait(5);
                        Cursor.Position = p;
                        calls.Wait(20);
                        break;
                    case KeyState.Up:
                        InputKeys.Keyboard.KeyUp((ushort)DirectInputKeys.DIK_3);
                        break;
                }
            }
            if (key == VirtualKeyCode.R && cbR.Checked == true)
            {
                switch (state)
                {
                    case KeyState.Down:
                        Point p = Cursor.Position;
                        calls.DoThing("FindEnemy", hodnoty.XerathR, new Point(0, -29));

                        InputKeys.Keyboard.KeyDown((ushort)DirectInputKeys.DIK_4);
                        calls.Wait(5);
                        Cursor.Position = p;
                        calls.Wait(20);
                        break;
                    case KeyState.Up:
                        InputKeys.Keyboard.KeyUp((ushort)DirectInputKeys.DIK_4);
                        break;
                }
            }
        }
    }
}
