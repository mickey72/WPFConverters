using Xunit;
using Kent.Boogaart.Converters.Expressions.Nodes;

namespace Kent.Boogaart.Converters.UnitTest.Expressions.Nodes
{
	public sealed class AddNodeTest : WideningBinaryNodeTestBase
	{
		private AddNode _addNode;

		protected override void SetUpCore()
		{
			base.SetUpCore();
			_addNode = new AddNode(new ConstantNode<int>(0), new ConstantNode<int>(0));
		}

		[Fact]
		public void OperatorSymbols_ShouldYieldCorrectOperatorSymbols()
		{
			Assert.Equal("+", GetPrivateMemberValue<string>(_addNode, "OperatorSymbols"));
		}

		[Fact]
		public void DoString_ShouldDoConcatenation()
		{
            Assert.Equal("onetwo", InvokeDoMethod<string>(_addNode, "DoString", "one", "two"));
		}

		[Fact]
		public void DoByte_ShouldDoAddition()
		{
            Assert.Equal(3, InvokeDoMethod<int>(_addNode, "DoByte", (byte)1, (byte)2));
		}

		[Fact]
		public void DoInt16_ShouldDoAddition()
		{
            Assert.Equal(3, InvokeDoMethod<int>(_addNode, "DoInt16", (short)1, (short)2));
		}

		[Fact]
		public void DoInt32_ShouldDoAddition()
		{
            Assert.Equal(3, InvokeDoMethod<int>(_addNode, "DoInt32", 1, 2));
		}

		[Fact]
		public void DoInt64_ShouldDoAddition()
		{
            Assert.Equal(3L, InvokeDoMethod<long>(_addNode, "DoInt64", 1L, 2L));
		}

		[Fact]
		public void DoSingle_ShouldDoAddition()
		{
            Assert.Equal(3f, InvokeDoMethod<float>(_addNode, "DoSingle", 1f, 2f));
		}

		[Fact]
		public void DoDouble_ShouldDoAddition()
		{
            Assert.Equal(3d, InvokeDoMethod<double>(_addNode, "DoDouble", 1d, 2d));
		}

		[Fact]
		public void DoDecimal_ShouldDoAddition()
		{
            Assert.Equal(3m, InvokeDoMethod<decimal>(_addNode, "DoDecimal", 1m, 2m));
		}
	}
}
