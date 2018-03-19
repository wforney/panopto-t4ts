﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Example.Models;
using T4TS.Tests.Fixtures.Basic;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.ExtendsExplicit
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ExtendsExplicitModelHasExpectedOutput()
        {
            // Expect
            new OutputForAttributeBuilder(
                typeof(ExtendsExplicitModel),
                typeof(BasicModel)
            ).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.ExtendsExplicit.ExtendsExplicitModel **/
    export interface ExtendsExplicitModel extends SomeFooBar {
        Basic: T4TS.BasicModel;
    }
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
        SomeDateTime: string;
    }
}
";

    }
}
