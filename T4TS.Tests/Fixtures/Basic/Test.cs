﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Basic
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void BasicModelHasExpectedOutputAttribute()
        {
            // Expect
            new OutputForAttributeBuilder(
                typeof(BasicModel)
            ).ToEqual(ExpectedOutputAttribute);
        }
        [TestMethod]
        public void BasicModelHasExpectedOutputDirect()
        {
            // Expect
            new OutputForDirectBuilder(
                typeof(BasicModel)
            ).ToEqual(ExpectedOutputDirect);
        }

        [TestMethod]
        public void BasicModelHasExpectedOutputNamespaceMap()
        {
            // Expect
            new OutputForDirectBuilder(
                typeof(BasicModel))
                .With(new Builders.DirectSettings()
                {
                    NamespaceToModuleMap =
                    {
                        { typeof(BasicModel).Namespace, "Bar" }
                    }
                })
                .ToEqual(ExpectedOutputDirectMapped);
        }

        const string ExpectedOutputAttribute = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
        SomeDateTime: string;
    }
}
";
        const string ExpectedOutputDirect = @"/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS.Tests.Fixtures.Basic {
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
        SomeDateTime: string;
    }
}";

        const string ExpectedOutputDirectMapped = @"/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module Bar {
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
        SomeDateTime: string;
    }
}";
    }
}
