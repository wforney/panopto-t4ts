﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Options.Override
{
    [TestClass]
    public class OverrideTests
    {
        [TestMethod]
        public void OverrideModelsHaveExpectedOutput()
        {
            // Expect
            new OutputForAttributeBuilder(
                typeof(InterfaceNamePrefixModel),
                typeof(InterfaceNameOverrideModel),
                typeof(ModuleNameOverrideModel),
                typeof(MemberNameOverrideModel),
                typeof(MemberOptionalModel),
                typeof(MemberCamelCaseModel),
                typeof(MemberTypeModel),
                typeof(MemberIgnoreModel)
            ).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput =
@"/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module SomeModule {
    /** Generated from T4TS.Tests.Fixtures.Options.Override.ModuleNameOverrideModel */
    export interface ModuleNameOverrideModel {
        SomeThirdProp: string;
    }
}

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Options.Override.InterfaceNameOverrideModel */
    export interface Bar {
        SomeOtherProp: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.InterfaceNamePrefixModel */
    export interface FooInterfaceNamePrefixModel {
        SomeProp: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.MemberCamelCaseModel */
    export interface MemberCamelCaseModel {
        memberName: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.MemberIgnoreModel */
    export interface MemberIgnoreModel {
        NotIgnored: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.MemberNameOverrideModel */
    export interface MemberNameOverrideModel {
        OverriddenName: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.MemberOptionalModel */
    export interface MemberOptionalModel {
        Member?: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Options.Override.MemberTypeModel */
    export interface MemberTypeModel {
        NotANumber: number;
    }
}
";
    }
}
