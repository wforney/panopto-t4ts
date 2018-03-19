﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Nullable
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void NullableModelHasExpectedOutput()
        {
            // Expect
            new OutputForAttributeBuilder(
                typeof(NullableModel)
            ).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Nullable.NullableModel **/
    export interface NullableModel {
        NullableInt: number;
        NullableDouble: number;
    }
}
";
    }
}
