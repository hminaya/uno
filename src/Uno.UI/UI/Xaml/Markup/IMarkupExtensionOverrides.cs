using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno.UI.Xaml.Markup.MarkupExtension
{
	public partial interface IMarkupExtensionOverrides
	{
		object ProvideValue();
	}
}
