using AWS.Jsii.Runtime.Deputy;

namespace AWS.Jsii.Tests.Calculator
{
    /// <summary>Properties for Calculator.</summary>
    [JsiiInterfaceProxy("jsii-calc", "jsii$jsii_calc$.CalculatorProps")]
    internal class CalculatorPropsProxy : DeputyBase, ICalculatorProps
    {
        private CalculatorPropsProxy(ByRefValue reference): base(reference)
        {
        }

        [JsiiProperty("initialValue", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? InitialValue
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }

        [JsiiProperty("maximumValue", "{\"primitive\":\"number\",\"optional\":true}")]
        public virtual double? MaximumValue
        {
            get => GetProperty<double? >();
            set => SetProperty(value);
        }
    }
}