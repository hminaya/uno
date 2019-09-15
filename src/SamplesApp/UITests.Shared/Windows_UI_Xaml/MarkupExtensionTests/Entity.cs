using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;

namespace UITests.Shared.Windows_UI_Xaml.MarkupExtension
{
	[MarkupExtensionReturnType(ReturnType = typeof(EntityObject))]
	public class Entity : Windows.UI.Xaml.Markup.MarkupExtension
	{
		public string TextValue { get; set; }

		public int IntValue { get; set; }

		protected override object ProvideValue()
		{
			return new EntityObject()
			{
				StringProperty = TextValue,
				IntProperty = IntValue
			};
		}
	}

	public class EntityObject
	{
		public string StringProperty { get; set; } = string.Empty;

		public int IntProperty { get; set; }

		//public string StringProperty
		//{
		//	get => (string)GetValue(StringPropertyProperty);
		//	set => SetValue(StringPropertyProperty, value);
		//}

		//public static readonly DependencyProperty StringPropertyProperty =
		//	DependencyProperty.Register(
		//		nameof(StringProperty),
		//		typeof(string),
		//		typeof(EntityObject),
		//		new PropertyMetadata(string.Empty));

		//public int IntProperty
		//{
		//	get => (int)GetValue(IntPropertyProperty);
		//	set => SetValue(IntPropertyProperty, value);
		//}

		//public static readonly DependencyProperty IntPropertyProperty =
		//	DependencyProperty.Register(
		//		nameof(IntProperty),
		//		typeof(int),
		//		typeof(EntityObject),
		//		new PropertyMetadata(0));
	}
}
