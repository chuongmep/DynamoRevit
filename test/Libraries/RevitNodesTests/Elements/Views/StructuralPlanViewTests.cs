using System;

using NUnit.Framework;

using Revit.Elements;
using Revit.Elements.Views;

using RevitTestServices;

using RTF.Framework;

namespace RevitNodesTests.Elements.Views
{
    [TestFixture]
    class StructuralPlanViewTests : RevitNodeTestBase
    {
        [Test]
        [TestModel(@".\Empty.rvt")]
        public void ByLevel_ValidArgs()
        {
            var elevation = 100;
            var level = Level.ByElevation(elevation);
            Assert.NotNull(level);

            var view = StructuralPlanView.ByLevel(level);

            Assert.NotNull(view);
        }

        [Test]
        [TestModel(@".\Empty.rvt")]
        public void ByLevel_BadArgs()
        {
            Assert.Throws(typeof(ArgumentNullException), () => StructuralPlanView.ByLevel(null));
        }
    }
}
