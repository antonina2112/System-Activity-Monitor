using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpz2.AbstractFactory;

namespace trpz2.Models
{
    public class MouseHook : Hook, IProduct
    {
        private enum MouseEventType
        {
            None,
            MouseDown,
            MouseUp,
            DoubleClick,
            MouseWheel,
            MouseMove
        }

        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseWheel;

        public event EventHandler Click;
        public event EventHandler DoubleClick;

        public MouseHook()
        {
            _hookType = WH_MOUSE_LL;
        }

        protected override int HookCallbackProcedure(int nCode, int wParam, IntPtr lParam)
        {

            if (nCode > -1 && (MouseDown != null || MouseUp != null || MouseMove != null))
            {

                MouseLLHookStruct mouseHookStruct =
                    (MouseLLHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseLLHookStruct));

                MouseButtons button = GetButton(wParam);
                MouseEventType eventType = GetEventType(wParam);

                MouseEventArgs e = new MouseEventArgs(
                    button,
                    (eventType == MouseEventType.DoubleClick ? 2 : 1),
                    mouseHookStruct.pt.x,
                    mouseHookStruct.pt.y,
                    (eventType == MouseEventType.MouseWheel ? (short)((mouseHookStruct.mouseData >> 16) & 0xffff) : 0));

                // Prevent multiple Right Click events (this probably happens for popup menus)
                if (button == MouseButtons.Right && mouseHookStruct.flags != 0)
                {
                    eventType = MouseEventType.None;
                }

                switch (eventType)
                {
                    case MouseEventType.MouseDown:
                        MouseDown?.Invoke(this, e);
                        break;
                    case MouseEventType.MouseUp:
                        Click?.Invoke(this, new EventArgs());
                        MouseUp?.Invoke(this, e);
                        break;
                    case MouseEventType.DoubleClick:
                        DoubleClick?.Invoke(this, new EventArgs());
                        break;
                    case MouseEventType.MouseWheel:
                        MouseWheel?.Invoke(this, e);
                        break;
                    case MouseEventType.MouseMove:
                        MouseMove?.Invoke(this, e);
                        break;
                    default:
                        break;
                }

            }

            return CallNextHookEx(_handleToHook, nCode, wParam, lParam);

        }

        private MouseButtons GetButton(int wParam)
        {

            switch (wParam)
            {

                case WM_LBUTTONDOWN:
                case WM_LBUTTONUP:
                case WM_LBUTTONDBLCLK:
                    return MouseButtons.Left;
                case WM_RBUTTONDOWN:
                case WM_RBUTTONUP:
                case WM_RBUTTONDBLCLK:
                    return MouseButtons.Right;
                case WM_MBUTTONDOWN:
                case WM_MBUTTONUP:
                case WM_MBUTTONDBLCLK:
                    return MouseButtons.Middle;
                default:
                    return MouseButtons.None;

            }

        }

        private MouseEventType GetEventType(Int32 wParam)
        {

            switch (wParam)
            {

                case WM_LBUTTONDOWN:
                case WM_RBUTTONDOWN:
                case WM_MBUTTONDOWN:
                    return MouseEventType.MouseDown;
                case WM_LBUTTONUP:
                case WM_RBUTTONUP:
                case WM_MBUTTONUP:
                    return MouseEventType.MouseUp;
                case WM_LBUTTONDBLCLK:
                case WM_RBUTTONDBLCLK:
                case WM_MBUTTONDBLCLK:
                    return MouseEventType.DoubleClick;
                case WM_MOUSEWHEEL:
                    return MouseEventType.MouseWheel;
                case WM_MOUSEMOVE:
                    return MouseEventType.MouseMove;
                default:
                    return MouseEventType.None;

            }
        }
    }

}
