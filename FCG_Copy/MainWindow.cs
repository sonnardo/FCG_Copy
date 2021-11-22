using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        CreatingListColumn();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void clickedCopy(object sender, EventArgs e)
    {

    }

    protected void CreatingListColumn()
    {
        TreeViewColumn titleColumn = new TreeViewColumn();
        titleColumn.Title = "Title";

        TreeViewColumn datumColumn = new TreeViewColumn();
        datumColumn.Title = "Datum";

        treeview5.AppendColumn(titleColumn);
        treeview5.AppendColumn(datumColumn);

        // Create a model that will hold two strings - Artist Name and Song Title
        ListStore musicListStore = new Gtk.ListStore(typeof(string), typeof(string));


        // Assign the model to the TreeView
        treeview5.Model = musicListStore;
    }

    protected void dateiExit(object sender, EventArgs e)
    {
        Application.Quit();
    }
}
