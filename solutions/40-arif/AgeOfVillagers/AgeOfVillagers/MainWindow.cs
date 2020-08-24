using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnHomeClicked(object sender, EventArgs e)
    {
        Console.WriteLine("ok");
    }

    protected void OnUndo(object o, ChangedArgs args)
    {
        Console.WriteLine("undo");
    }

    protected void OnUndoActivate(object sender, EventArgs e)
    {
        Console.WriteLine("undo Activated");
    }

    protected void OnUndoToggled(object sender, EventArgs e)
    {
        Console.WriteLine("undo toggled");
    }
}
