﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk3.Interop
{
    class GObject : SafeHandle
    {
        public GObject() : base(IntPtr.Zero, true)
        {
        }

        public GObject(IntPtr handle, bool owned = true) : base(IntPtr.Zero, owned)
        {
            this.handle = handle;
        }

        protected override bool ReleaseHandle()
        {
            if (handle != IntPtr.Zero)
            {
                Debug.Assert(Native.GTypeCheckInstanceIsFundamentallyA(handle, new IntPtr(Native.G_TYPE_OBJECT)),
                    "Handle is not a GObject");
                Native.GObjectUnref(handle);
            }

            handle = IntPtr.Zero;
            return true;
        }

        public override bool IsInvalid => handle == IntPtr.Zero;
    }

    class GInputStream : GObject
    {

    }

    class GtkWidget : GObject
    {

    }
    enum GtkResizeMode
    {
        GTK_RESIZE_PARENT,
        GTK_RESIZE_QUEUE,
        GTK_RESIZE_IMMEDIATE
    }
    class GtkContainer : GtkWidget
    {
        public int borderWidth { get; set; }
        public GtkWidget child { set { } }
        public GtkResizeMode resizeMode { get; set; }
    }
    class GtkHeaderBar : GtkContainer
    {
        public GtkWidget customTitle { get; set; }
        public String decorationLayout { get; set; }
        public bool decorationLayoutSet { get; set; }
        public bool hasSubtitle { get; set; }
        public bool showCloseButton { get; set; }
        public int spacing { get; set; }
        public String subtitle { get; set; }
        public String title { get; set; }
    }
    class GtkWindow : GtkWidget
    {
        public static GtkWindow Null { get; } = new GtkWindow();
    }

    class GtkImContext : GObject
    {
    }

    class GdkScreen : GObject
    {
        public GdkScreen() : base(IntPtr.Zero, false)
        {
        }

        public GdkScreen(IntPtr handle, bool owned = true) : base(handle, owned)
        {
            this.handle = handle;
        }
    }

    class UnownedGdkScreen : GdkScreen
    {
        public UnownedGdkScreen() : base(IntPtr.Zero, false)
        {
        }

        public UnownedGdkScreen(IntPtr handle, bool owned = true) : base(IntPtr.Zero, false)
        {
            this.handle = handle;
        }
    }

    class GtkDialog : GtkWindow
    {

    }

    class GtkFileChooser : GtkDialog
    {

    }
}

