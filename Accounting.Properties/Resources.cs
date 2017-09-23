using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using System.Drawing;
using System;
using System.ComponentModel;

namespace Accounting.Properties
{
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal class Resources
{
	private static CultureInfo resourceCulture;

	private static ResourceManager resourceMan;

	internal static Bitmap Add
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Add", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Browse
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Browse", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Calculator2
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Calculator2", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Contacts
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Contacts", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Create
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Create", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Resources.resourceCulture;
		}
		set
		{
			Resources.resourceCulture = value;
		}
	}

	internal static Bitmap Delete
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Delete", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Deposit
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Deposit", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Edit
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Edit", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Exit
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Exit", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Journal
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Journal", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap NotesALT
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("NotesALT", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Print
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Print", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap PrintPreview
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("PrintPreview", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(Resources.resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("Accounting.Properties.Resources", typeof(Resources).Assembly);
				Resources.resourceMan = resourceManager;
			}
			return Resources.resourceMan;
		}
	}

	internal static Bitmap Save
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Save", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Save1
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Save1", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Search
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Search", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Wothdrawal
	{
		get
		{
			object obj = Resources.ResourceManager.GetObject("Wothdrawal", Resources.resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
	}
}
}