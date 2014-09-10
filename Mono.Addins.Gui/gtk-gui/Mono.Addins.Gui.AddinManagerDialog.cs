
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Addins.Gui
{
	internal partial class AddinManagerDialog
	{
		private global::Gtk.VBox vbox93;
		private global::Gtk.HBox hbox65;
		private global::Gtk.HBox hbox72;
		private global::Gtk.Notebook notebook;
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox6;
		private global::Gtk.ScrolledWindow scrolledwindow13;
		private global::Gtk.TreeView addinTree;
		private global::Gtk.EventBox eventbox2;
		private global::Mono.Addins.Gui.AddinInfoView addininfoInstalled;
		private global::Gtk.Label label7;
		private global::Gtk.HBox boxUpdates;
		private global::Gtk.VBox vboxUpdates;
		private global::Gtk.EventBox eboxRepoUpdates;
		private global::Gtk.HBox hbox67;
		private global::Gtk.Label labelUpdates;
		private global::Gtk.Button buttonRefreshUpdates;
		private global::Gtk.Button buttonUpdateAll;
		private global::Gtk.ScrolledWindow scrolledUpdates;
		private global::Gtk.TreeView updatesTreeView;
		private global::Gtk.EventBox eventbox3;
		private global::Mono.Addins.Gui.AddinInfoView addininfoUpdates;
		private global::Gtk.Label label4;
		private global::Gtk.HBox hbox8;
		private global::Gtk.VBox vboxGallery;
		private global::Gtk.EventBox eboxRepo;
		private global::Gtk.HBox hbox66;
		private global::Gtk.Label label112;
		private global::Gtk.ComboBox repoCombo;
		private global::Gtk.Button buttonRefresh;
		private global::Gtk.ScrolledWindow scrolledGallery;
		private global::Gtk.TreeView galleryTreeView;
		private global::Gtk.EventBox eventbox1;
		private global::Mono.Addins.Gui.AddinInfoView addininfoGallery;
		private global::Gtk.Label label8;
		private global::Gtk.Button buttonInstallFromFile;
		private global::Gtk.Button btnClose;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Addins.Gui.AddinManagerDialog
			this.Name = "Mono.Addins.Gui.AddinManagerDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add-in Manager");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.BorderWidth = ((uint)(6));
			this.DefaultWidth = 700;
			this.DefaultHeight = 550;
			// Internal child Mono.Addins.Gui.AddinManagerDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog-vbox8";
			w1.Spacing = 3;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog-vbox8.Gtk.Box+BoxChild
			this.vbox93 = new global::Gtk.VBox ();
			this.vbox93.Name = "vbox93";
			this.vbox93.Spacing = 6;
			this.vbox93.BorderWidth = ((uint)(6));
			// Container child vbox93.Gtk.Box+BoxChild
			this.hbox65 = new global::Gtk.HBox ();
			this.hbox65.Name = "hbox65";
			this.hbox65.Spacing = 12;
			// Container child hbox65.Gtk.Box+BoxChild
			this.hbox72 = new global::Gtk.HBox ();
			this.hbox72.Name = "hbox72";
			this.hbox72.Spacing = 12;
			// Container child hbox72.Gtk.Box+BoxChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			this.notebook.ShowBorder = false;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 9;
			this.hbox2.BorderWidth = ((uint)(9));
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.scrolledwindow13 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow13.CanFocus = true;
			this.scrolledwindow13.Name = "scrolledwindow13";
			this.scrolledwindow13.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow13.Gtk.Container+ContainerChild
			this.addinTree = new global::Gtk.TreeView ();
			this.addinTree.CanFocus = true;
			this.addinTree.Name = "addinTree";
			this.scrolledwindow13.Add (this.addinTree);
			this.vbox6.Add (this.scrolledwindow13);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.scrolledwindow13]));
			w3.Position = 0;
			this.hbox2.Add (this.vbox6);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox6]));
			w4.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.eventbox2 = new global::Gtk.EventBox ();
			this.eventbox2.Name = "eventbox2";
			// Container child eventbox2.Gtk.Container+ContainerChild
			this.addininfoInstalled = new global::Mono.Addins.Gui.AddinInfoView ();
			this.addininfoInstalled.Events = ((global::Gdk.EventMask)(256));
			this.addininfoInstalled.Name = "addininfoInstalled";
			this.addininfoInstalled.AllowInstall = false;
			this.eventbox2.Add (this.addininfoInstalled);
			this.hbox2.Add (this.eventbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.eventbox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.notebook.Add (this.hbox2);
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Installed");
			this.notebook.SetTabLabel (this.hbox2, this.label7);
			this.label7.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.boxUpdates = new global::Gtk.HBox ();
			this.boxUpdates.Name = "boxUpdates";
			this.boxUpdates.Spacing = 9;
			this.boxUpdates.BorderWidth = ((uint)(9));
			// Container child boxUpdates.Gtk.Box+BoxChild
			this.vboxUpdates = new global::Gtk.VBox ();
			this.vboxUpdates.Name = "vboxUpdates";
			// Container child vboxUpdates.Gtk.Box+BoxChild
			this.eboxRepoUpdates = new global::Gtk.EventBox ();
			this.eboxRepoUpdates.Name = "eboxRepoUpdates";
			// Container child eboxRepoUpdates.Gtk.Container+ContainerChild
			this.hbox67 = new global::Gtk.HBox ();
			this.hbox67.Name = "hbox67";
			this.hbox67.Spacing = 6;
			// Container child hbox67.Gtk.Box+BoxChild
			this.labelUpdates = new global::Gtk.Label ();
			this.labelUpdates.Name = "labelUpdates";
			this.labelUpdates.LabelProp = global::Mono.Unix.Catalog.GetString ("No updates found");
			this.hbox67.Add (this.labelUpdates);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox67 [this.labelUpdates]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox67.Gtk.Box+BoxChild
			this.buttonRefreshUpdates = new global::Gtk.Button ();
			this.buttonRefreshUpdates.CanFocus = true;
			this.buttonRefreshUpdates.Name = "buttonRefreshUpdates";
			this.buttonRefreshUpdates.UseUnderline = true;
			this.buttonRefreshUpdates.Relief = ((global::Gtk.ReliefStyle)(2));
			this.buttonRefreshUpdates.Label = global::Mono.Unix.Catalog.GetString ("Refresh");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.buttonRefreshUpdates.Image = w9;
			this.hbox67.Add (this.buttonRefreshUpdates);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox67 [this.buttonRefreshUpdates]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox67.Gtk.Box+BoxChild
			this.buttonUpdateAll = new global::Gtk.Button ();
			this.buttonUpdateAll.CanFocus = true;
			this.buttonUpdateAll.Name = "buttonUpdateAll";
			this.buttonUpdateAll.UseUnderline = true;
			this.buttonUpdateAll.Relief = ((global::Gtk.ReliefStyle)(2));
			this.buttonUpdateAll.Label = global::Mono.Unix.Catalog.GetString ("Update All");
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("download.png");
			this.buttonUpdateAll.Image = w11;
			this.hbox67.Add (this.buttonUpdateAll);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox67 [this.buttonUpdateAll]));
			w12.PackType = ((global::Gtk.PackType)(1));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.eboxRepoUpdates.Add (this.hbox67);
			this.vboxUpdates.Add (this.eboxRepoUpdates);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxUpdates [this.eboxRepoUpdates]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxUpdates.Gtk.Box+BoxChild
			this.scrolledUpdates = new global::Gtk.ScrolledWindow ();
			this.scrolledUpdates.CanFocus = true;
			this.scrolledUpdates.Name = "scrolledUpdates";
			this.scrolledUpdates.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledUpdates.Gtk.Container+ContainerChild
			this.updatesTreeView = new global::Gtk.TreeView ();
			this.updatesTreeView.CanFocus = true;
			this.updatesTreeView.Name = "updatesTreeView";
			this.scrolledUpdates.Add (this.updatesTreeView);
			this.vboxUpdates.Add (this.scrolledUpdates);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxUpdates [this.scrolledUpdates]));
			w16.Position = 1;
			this.boxUpdates.Add (this.vboxUpdates);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.boxUpdates [this.vboxUpdates]));
			w17.Position = 0;
			// Container child boxUpdates.Gtk.Box+BoxChild
			this.eventbox3 = new global::Gtk.EventBox ();
			this.eventbox3.Name = "eventbox3";
			// Container child eventbox3.Gtk.Container+ContainerChild
			this.addininfoUpdates = new global::Mono.Addins.Gui.AddinInfoView ();
			this.addininfoUpdates.Events = ((global::Gdk.EventMask)(256));
			this.addininfoUpdates.Name = "addininfoUpdates";
			this.addininfoUpdates.AllowInstall = false;
			this.eventbox3.Add (this.addininfoUpdates);
			this.boxUpdates.Add (this.eventbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.boxUpdates [this.eventbox3]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.notebook.Add (this.boxUpdates);
			global::Gtk.Notebook.NotebookChild w20 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.boxUpdates]));
			w20.Position = 1;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Updates");
			this.notebook.SetTabLabel (this.boxUpdates, this.label4);
			this.label4.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 9;
			this.hbox8.BorderWidth = ((uint)(9));
			// Container child hbox8.Gtk.Box+BoxChild
			this.vboxGallery = new global::Gtk.VBox ();
			this.vboxGallery.Name = "vboxGallery";
			// Container child vboxGallery.Gtk.Box+BoxChild
			this.eboxRepo = new global::Gtk.EventBox ();
			this.eboxRepo.Name = "eboxRepo";
			// Container child eboxRepo.Gtk.Container+ContainerChild
			this.hbox66 = new global::Gtk.HBox ();
			this.hbox66.Name = "hbox66";
			this.hbox66.Spacing = 6;
			// Container child hbox66.Gtk.Box+BoxChild
			this.label112 = new global::Gtk.Label ();
			this.label112.Name = "label112";
			this.label112.LabelProp = global::Mono.Unix.Catalog.GetString ("Repository:");
			this.hbox66.Add (this.label112);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox66 [this.label112]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox66.Gtk.Box+BoxChild
			this.repoCombo = new global::Gtk.ComboBox ();
			this.repoCombo.Name = "repoCombo";
			this.hbox66.Add (this.repoCombo);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox66 [this.repoCombo]));
			w22.Position = 1;
			// Container child hbox66.Gtk.Box+BoxChild
			this.buttonRefresh = new global::Gtk.Button ();
			this.buttonRefresh.CanFocus = true;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.UseUnderline = true;
			this.buttonRefresh.Relief = ((global::Gtk.ReliefStyle)(2));
			this.buttonRefresh.Label = global::Mono.Unix.Catalog.GetString ("Refresh");
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.buttonRefresh.Image = w23;
			this.hbox66.Add (this.buttonRefresh);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox66 [this.buttonRefresh]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.eboxRepo.Add (this.hbox66);
			this.vboxGallery.Add (this.eboxRepo);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vboxGallery [this.eboxRepo]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vboxGallery.Gtk.Box+BoxChild
			this.scrolledGallery = new global::Gtk.ScrolledWindow ();
			this.scrolledGallery.CanFocus = true;
			this.scrolledGallery.Name = "scrolledGallery";
			this.scrolledGallery.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledGallery.Gtk.Container+ContainerChild
			this.galleryTreeView = new global::Gtk.TreeView ();
			this.galleryTreeView.CanFocus = true;
			this.galleryTreeView.Name = "galleryTreeView";
			this.scrolledGallery.Add (this.galleryTreeView);
			this.vboxGallery.Add (this.scrolledGallery);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vboxGallery [this.scrolledGallery]));
			w28.Position = 1;
			this.hbox8.Add (this.vboxGallery);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.vboxGallery]));
			w29.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.eventbox1 = new global::Gtk.EventBox ();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.addininfoGallery = new global::Mono.Addins.Gui.AddinInfoView ();
			this.addininfoGallery.Events = ((global::Gdk.EventMask)(256));
			this.addininfoGallery.Name = "addininfoGallery";
			this.addininfoGallery.AllowInstall = false;
			this.eventbox1.Add (this.addininfoGallery);
			this.hbox8.Add (this.eventbox1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.eventbox1]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.notebook.Add (this.hbox8);
			global::Gtk.Notebook.NotebookChild w32 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.hbox8]));
			w32.Position = 2;
			// Notebook tab
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Gallery");
			this.notebook.SetTabLabel (this.hbox8, this.label8);
			this.label8.ShowAll ();
			this.hbox72.Add (this.notebook);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox72 [this.notebook]));
			w33.Position = 0;
			this.hbox65.Add (this.hbox72);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox65 [this.hbox72]));
			w34.Position = 0;
			this.vbox93.Add (this.hbox65);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox93 [this.hbox65]));
			w35.Position = 0;
			w1.Add (this.vbox93);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox93]));
			w36.Position = 0;
			// Internal child Mono.Addins.Gui.AddinManagerDialog.ActionArea
			global::Gtk.HButtonBox w37 = this.ActionArea;
			w37.Name = "dialog-action_area8";
			w37.Spacing = 6;
			w37.BorderWidth = ((uint)(5));
			w37.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(2));
			// Container child dialog-action_area8.Gtk.ButtonBox+ButtonBoxChild
			this.buttonInstallFromFile = new global::Gtk.Button ();
			this.buttonInstallFromFile.CanFocus = true;
			this.buttonInstallFromFile.Name = "buttonInstallFromFile";
			this.buttonInstallFromFile.UseUnderline = true;
			this.buttonInstallFromFile.Label = global::Mono.Unix.Catalog.GetString ("Install from file...");
			w37.Add (this.buttonInstallFromFile);
			global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37 [this.buttonInstallFromFile]));
			w38.Expand = false;
			w38.Fill = false;
			// Container child dialog-action_area8.Gtk.ButtonBox+ButtonBoxChild
			this.btnClose = new global::Gtk.Button ();
			this.btnClose.CanDefault = true;
			this.btnClose.CanFocus = true;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseStock = true;
			this.btnClose.UseUnderline = true;
			this.btnClose.Label = "gtk-close";
			this.AddActionWidget (this.btnClose, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37 [this.btnClose]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.notebook.SwitchPage += new global::Gtk.SwitchPageHandler (this.OnNotebookSwitchPage);
			this.addininfoInstalled.InstallClicked += new global::System.EventHandler (this.OnInstallClicked);
			this.addininfoInstalled.UninstallClicked += new global::System.EventHandler (this.OnUninstallClicked);
			this.addininfoInstalled.UpdateClicked += new global::System.EventHandler (this.OnUpdateClicked);
			this.addininfoInstalled.EnableDisableClicked += new global::System.EventHandler (this.OnEnableDisableClicked);
			this.buttonUpdateAll.Clicked += new global::System.EventHandler (this.OnUpdateAll);
			this.buttonRefreshUpdates.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
			this.addininfoUpdates.InstallClicked += new global::System.EventHandler (this.OnInstallClicked);
			this.addininfoUpdates.UninstallClicked += new global::System.EventHandler (this.OnUninstallClicked);
			this.addininfoUpdates.UpdateClicked += new global::System.EventHandler (this.OnUpdateClicked);
			this.addininfoUpdates.EnableDisableClicked += new global::System.EventHandler (this.OnEnableDisableClicked);
			this.repoCombo.Changed += new global::System.EventHandler (this.OnRepoComboChanged);
			this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
			this.addininfoGallery.InstallClicked += new global::System.EventHandler (this.OnInstallClicked);
			this.addininfoGallery.UninstallClicked += new global::System.EventHandler (this.OnUninstallClicked);
			this.addininfoGallery.UpdateClicked += new global::System.EventHandler (this.OnUpdateClicked);
			this.addininfoGallery.EnableDisableClicked += new global::System.EventHandler (this.OnEnableDisableClicked);
			this.buttonInstallFromFile.Clicked += new global::System.EventHandler (this.OnButtonInstallFromFileClicked);
		}
	}
}
