// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.WspTS
{
    using Microsoft.Protocols.TestTools;
    using Microsoft.Protocols.TestTools.Messages.Runtime;

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TestCaseGetRowsOutFor_E_Fail : WspModelTestBase
    {
        public TestCaseGetRowsOutFor_E_Fail()
        {
            this.SetSwitch("generatedtestpath", "..\\\\TestSuite");
            this.SetSwitch("generatedtestnamespace", "Microsoft.Protocols.TestSuites.WspTS");
            this.SetSwitch("graphtimeout", "1000");
            this.SetSwitch("statebound", "-1");
            this.SetSwitch("stepbound", "6000");
            this.SetSwitch("pathbound", "32");
            this.SetSwitch("stepsperstatebound", "1024");
        }

        #region Expect Delegates
        public delegate void CPMConnectOutResponseDelegate1(uint errorCode);

        public delegate void CPMCreateQueryOutResponseDelegate1(uint errorCode);

        public delegate void CPMSetBindingsInResponseDelegate1(uint errorCode);

        public delegate void CPMGetRowsOutResponseDelegate1(uint errorCode);

        public delegate void CPMFreeCursorOutResponseDelegate1(uint errorCode);

        public delegate void GetServerPlatformDelegate1(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.SkuOsVersion platform, bool @return);

        public delegate void CPMGetQueryStatusOutResponseDelegate1(uint errorCode);

        public delegate void CPMGetQueryStatusExOutResponseDelegate1(uint errorCode);

        public delegate void CPMRatioFinishedOutResponseDelegate1(uint errorCode);

        public delegate void CPMFetchValueOutResponseDelegate1(uint errorCode);

        public delegate void CPMCiStateInOutResponseDelegate1(uint errorCode);

        public delegate void CPMSendNotifyOutResponseDelegate1(uint errorCode);

        public delegate void CPMFindIndicesOutResponseDelegate1(uint errorCode);

        public delegate void CPMGetRowsetNotifyOutResponseDelegate1(uint errorCode);

        public delegate void CPMGetScopeStatisticsOutResponseDelegate1(uint errorCode);

        public delegate void CPMSetScopePrioritizationOutResponseDelegate1(uint errorCode);

        public delegate void CPMUpdateDocumentsOutResponseDelegate1(uint errorCode);
        #endregion

        #region Event Metadata
        static System.Reflection.MethodBase CPMConnectInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMConnectIn");

        static System.Reflection.EventInfo CPMConnectOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMConnectOutResponse");

        static System.Reflection.MethodBase CPMCreateQueryInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMCreateQueryIn", typeof(bool));

        static System.Reflection.EventInfo CPMCreateQueryOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMCreateQueryOutResponse");

        static System.Reflection.MethodBase CPMSetBindingsInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMSetBindingsIn", typeof(bool), typeof(bool));

        static System.Reflection.EventInfo CPMSetBindingsInResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMSetBindingsInResponse");

        static System.Reflection.MethodBase CPMGetRowsInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetRowsIn", typeof(bool));

        static System.Reflection.EventInfo CPMGetRowsOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetRowsOutResponse");

        static System.Reflection.MethodBase CPMFreeCursorInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFreeCursorIn", typeof(bool));

        static System.Reflection.EventInfo CPMFreeCursorOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFreeCursorOutResponse");

        static System.Reflection.MethodBase CPMDisconnectInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMDisconnect");

        static System.Reflection.MethodBase GetServerPlatformInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "GetServerPlatform", typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.SkuOsVersion).MakeByRefType());

        static System.Reflection.MethodBase CPMGetQueryStatusInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetQueryStatusIn", typeof(bool));

        static System.Reflection.MethodBase CPMGetQueryStatusExInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetQueryStatusExIn", typeof(bool));

        static System.Reflection.MethodBase CPMRatioFinishedInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMRatioFinishedIn", typeof(bool));

        static System.Reflection.MethodBase CPMFetchValueInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFetchValueIn", typeof(bool));

        static System.Reflection.MethodBase CPMCiStateInOutInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMCiStateInOut");

        static System.Reflection.MethodBase CPMGetNotifyInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetNotify", typeof(bool));

        static System.Reflection.MethodBase CPMFindIndicesInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFindIndicesIn", typeof(bool));

        static System.Reflection.MethodBase CPMGetRowsetNotifyInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetRowsetNotifyIn", typeof(int), typeof(bool));

        static System.Reflection.MethodBase CPMSetScopePrioritizationInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMSetScopePrioritizationIn", typeof(uint));

        static System.Reflection.MethodBase CPMGetScopeStatisticsInInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetScopeStatisticsIn");

        static System.Reflection.EventInfo CPMGetQueryStatusOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetQueryStatusOutResponse");

        static System.Reflection.EventInfo CPMGetQueryStatusExOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetQueryStatusExOutResponse");

        static System.Reflection.EventInfo CPMRatioFinishedOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMRatioFinishedOutResponse");

        static System.Reflection.EventInfo CPMFetchValueOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFetchValueOutResponse");

        static System.Reflection.EventInfo CPMCiStateInOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMCiStateInOutResponse");

        static System.Reflection.EventInfo CPMSendNotifyOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMSendNotifyOutResponse");

        static System.Reflection.EventInfo CPMFindIndicesOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMFindIndicesOutResponse");

        static System.Reflection.EventInfo CPMGetRowsetNotifyOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetRowsetNotifyOutResponse");

        static System.Reflection.EventInfo CPMGetScopeStatisticsOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMGetScopeStatisticsOutResponse");

        static System.Reflection.EventInfo CPMSetScopePrioritizationOutResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter), "CPMSetScopePrioritizationOutResponse");

        #endregion

        #region Adapter Instances
        private Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter IWspAdapterInstance;
        #endregion

        #region Variables
        private IVariable<uint> returnCode3;
        #endregion

        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context)
        {
            PtfTestClassBase.Initialize(context);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup()
        {
            PtfTestClassBase.Cleanup();
        }
        #endregion

        #region Test Initialization and Cleanup
        protected override void TestInitialize()
        {
            this.InitializeTestManager();
            this.IWspAdapterInstance = ((Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter)(this.GetAdapter(typeof(Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Wsp.Adapter.IWspAdapter))));
            this.Subscribe(CPMConnectOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMCreateQueryOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMSetBindingsInResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMGetRowsOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMFreeCursorOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMGetQueryStatusOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMGetQueryStatusExOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMRatioFinishedOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMFetchValueOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMCiStateInOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMSendNotifyOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMFindIndicesOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMGetRowsetNotifyOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMGetScopeStatisticsOutResponseInfo, this.IWspAdapterInstance);
            this.Subscribe(CPMSetScopePrioritizationOutResponseInfo, this.IWspAdapterInstance);
            this.returnCode3 = this.Manager.CreateVariable<uint>("returnCode3");
        }

        protected override void TestCleanup()
        {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion

        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("MS-WSP_R592, MS-WSP_R599, MS-WSP_R647, MS-WSP_R651, MS-WSP_R653, MS-WSP_R654, MS-" +
            "WSP_R655, MS-WSP_R657, MS-WSP_R703, MS-WSP_R705, MS-WSP_R707, MS-WSP_R723, MS-WS" +
            "P_R742, MS-WSP_R744, MS-WSP_R746, MS-WSP_R791, MS-WSP_R793")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CPMGetRows")]
        public virtual void TestCaseGetRowsOutFor_E_FailS0()
        {
            this.Manager.BeginTest("TestCaseGetRowsOutFor_E_FailS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call CPMConnectIn()\'");
            this.IWspAdapterInstance.CPMConnectIn();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return CPMConnectIn\'");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(TestCaseGetRowsOutFor_E_Fail.CPMConnectOutResponseInfo, null, new CPMConnectOutResponseDelegate1(this.TestCaseGetRowsOutFor_E_FailS0CPMConnectOutResponseChecker)));
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call CPMCreateQueryIn(True)\'");
            this.IWspAdapterInstance.CPMCreateQueryIn(true);
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("checking step \'return CPMCreateQueryIn\'");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(TestCaseGetRowsOutFor_E_Fail.CPMCreateQueryOutResponseInfo, null, new CPMCreateQueryOutResponseDelegate1(this.TestCaseGetRowsOutFor_E_FailS0CPMCreateQueryOutResponseChecker)));
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call CPMSetBindingsIn(True,True)\'");
            this.IWspAdapterInstance.CPMSetBindingsIn(true, true);
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("checking step \'return CPMSetBindingsIn\'");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(TestCaseGetRowsOutFor_E_Fail.CPMSetBindingsInResponseInfo, null, new CPMSetBindingsInResponseDelegate1(this.TestCaseGetRowsOutFor_E_FailS0CPMSetBindingsInResponseChecker)));
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("executing step \'call CPMGetRowsIn(True)\'");
            this.IWspAdapterInstance.CPMGetRowsIn(true);
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("checking step \'return CPMGetRowsIn\'");
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(TestCaseGetRowsOutFor_E_Fail.CPMGetRowsOutResponseInfo, null, new CPMGetRowsOutResponseDelegate1(this.TestCaseGetRowsOutFor_E_FailS0CPMGetRowsOutResponseChecker)));
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("executing step \'call CPMFreeCursorIn(True)\'");
            this.IWspAdapterInstance.CPMFreeCursorIn(true);
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("checking step \'return CPMFreeCursorIn\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(TestCaseGetRowsOutFor_E_Fail.CPMFreeCursorOutResponseInfo, null, new CPMFreeCursorOutResponseDelegate1(this.TestCaseGetRowsOutFor_E_FailS0CPMFreeCursorOutResponseChecker)));
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("executing step \'call CPMDisconnect()\'");
            this.IWspAdapterInstance.CPMDisconnect();
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.Comment("checking step \'return CPMDisconnect\'");
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.EndTest();
        }

        private void TestCaseGetRowsOutFor_E_FailS0CPMConnectOutResponseChecker(uint errorCode)
        {
            this.Manager.Comment("checking step \'event CPMConnectOutResponse(0)\'");
            this.Manager.Assert((errorCode == 0), string.Format("expected \'0\', actual \'{0}\' (errorCode of CPMConnectOutResponse, state S4)", errorCode));
            this.Manager.Checkpoint("MS-WSP_R592");
            this.Manager.Checkpoint("MS-WSP_R647");
            this.Manager.Checkpoint("MS-WSP_R651");
            this.Manager.Checkpoint("MS-WSP_R653");
            this.Manager.Checkpoint("MS-WSP_R654");
        }

        private void TestCaseGetRowsOutFor_E_FailS0CPMCreateQueryOutResponseChecker(uint errorCode)
        {
            this.Manager.Comment("checking step \'event CPMCreateQueryOutResponse(0)\'");
            this.Manager.Assert((errorCode == 0), string.Format("expected \'0\', actual \'{0}\' (errorCode of CPMCreateQueryOutResponse, state S10)", errorCode));
            this.Manager.Checkpoint("MS-WSP_R592");
            this.Manager.Checkpoint("MS-WSP_R599");
            this.Manager.Checkpoint("MS-WSP_R655");
            this.Manager.Checkpoint("MS-WSP_R657");
        }

        private void TestCaseGetRowsOutFor_E_FailS0CPMSetBindingsInResponseChecker(uint errorCode)
        {
            this.Manager.Comment("checking step \'event CPMSetBindingsInResponse(0)\'");
            this.Manager.Assert((errorCode == 0), string.Format("expected \'0\', actual \'{0}\' (errorCode of CPMSetBindingsInResponse, state S16)", errorCode));
            this.Manager.Checkpoint("MS-WSP_R592");
            this.Manager.Checkpoint("MS-WSP_R742");
            this.Manager.Checkpoint("MS-WSP_R744");
            this.Manager.Checkpoint("MS-WSP_R746");
            this.Manager.Checkpoint("MS-WSP_R599");
        }

        private void TestCaseGetRowsOutFor_E_FailS0CPMGetRowsOutResponseChecker(uint errorCode)
        {
            this.Manager.Comment("checking step \'event CPMGetRowsOutResponse(returnCode)\'");
            this.returnCode3.Value = errorCode;
            this.Manager.Checkpoint("MS-WSP_R592");
            this.Manager.Checkpoint("MS-WSP_R703");
            this.Manager.Checkpoint("MS-WSP_R705");
            this.Manager.Checkpoint("MS-WSP_R707");
            this.Manager.Checkpoint("MS-WSP_R723");
            this.Manager.Checkpoint("MS-WSP_R599");
        }

        private void TestCaseGetRowsOutFor_E_FailS0CPMFreeCursorOutResponseChecker(uint errorCode)
        {
            this.Manager.Comment("checking step \'event CPMFreeCursorOutResponse(0)\'");
            this.Manager.Assert((errorCode == 0), string.Format("expected \'0\', actual \'{0}\' (errorCode of CPMFreeCursorOutResponse, state S28)", errorCode));
            this.Manager.Checkpoint("MS-WSP_R592");
            this.Manager.Checkpoint("MS-WSP_R599");
            this.Manager.Checkpoint("MS-WSP_R791");
            this.Manager.Checkpoint("MS-WSP_R793");
        }
        #endregion

    }
}
