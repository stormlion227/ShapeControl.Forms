using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stormlion.ShapeControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SSPicker : Picker
	{
		public SSPicker ()
		{
			InitializeComponent ();
		}
	}
}