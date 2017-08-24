﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSAndBasic.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RecommendationOfHIsWithoutAudiogram recording.
    /// </summary>
    [TestModule("6a2b939e-1bcd-4b67-b01b-dadd27ccdbac", ModuleType.Recording, 1)]
    public partial class RecommendationOfHIsWithoutAudiogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static RecommendationOfHIsWithoutAudiogram instance = new RecommendationOfHIsWithoutAudiogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecommendationOfHIsWithoutAudiogram()
        {
            LastName = "RunP";
            FirstName = "WithAudi";
            HIName = "Run P";
            Coupling = "Tip";
            Cluster = "P1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecommendationOfHIsWithoutAudiogram Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("a22486a8-deeb-4fbd-82cb-69375d81f835")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("d764c29f-70a3-4da8-b892-d76b26096f9d")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _HIName;

        /// <summary>
        /// Gets or sets the value of variable HIName.
        /// </summary>
        [TestVariable("b9d37d63-9c70-4826-8cad-abbaad178da5")]
        public string HIName
        {
            get { return _HIName; }
            set { _HIName = value; }
        }

        string _Coupling;

        /// <summary>
        /// Gets or sets the value of variable Coupling.
        /// </summary>
        [TestVariable("3bd3c252-1dd7-44e2-a3cc-1e5f91a0a678")]
        public string Coupling
        {
            get { return _Coupling; }
            set { _Coupling = value; }
        }

        string _Cluster;

        /// <summary>
        /// Gets or sets the value of variable Cluster.
        /// </summary>
        [TestVariable("abceb781-8aec-4cf9-bdbe-7916183fb39d")]
        public string Cluster
        {
            get { return _Cluster; }
            set { _Cluster = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //CreatePatient("abc", "xyz");
            //Delay.Milliseconds(0);
            
            //SwitchAudiogramAvailableinEditScreen(ValueConverter.ArgumentFromString<bool>("on", "False"), ValueConverter.ArgumentFromString<bool>("alert", "False"));
            //Delay.Milliseconds(0);
            
            //SelectCustomerContinue();
            //Delay.Milliseconds(0);
            
            //CloseApp();
            //Delay.Milliseconds(0);
            
            // Step## Open the app, goto List. Select the existing customer
            //Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List. Select the existing customer", new RecordItemIndex(4));
            
            //StartApp();
            //Delay.Milliseconds(0);
            
            //SearchCustomer("xyz");
            //Delay.Milliseconds(0);
            
            SelectCustomer("abc", "xyz");
            Delay.Milliseconds(0);
            
            //TapOn("Pure Tone Estimation");
            //Delay.Milliseconds(0);
            
            //SkipInstructions();
            //Delay.Milliseconds(0);
            
            //DrawPTEAudiogramPoints("Right", "45;45;60;95");
            //Delay.Milliseconds(0);
            
            //DrawPTEAudiogramPoints("Left", "45;45;60;95");
            //Delay.Milliseconds(0);
            
            //PTEDone();
            //Delay.Milliseconds(0);
            
            //TapOn("Continue With Fitting");
            //Delay.Milliseconds(0);
            
            //TapOn("Select Hearing Aid");
            //Delay.Milliseconds(0);
            
            TapOnMonauralHearingSystem();
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            TapOnObject("Run Click ITC");
            Delay.Milliseconds(0);
            
            TapOnCoupling("Click Sleeve");
            Delay.Milliseconds(0);
            
            ValidateMonauralHISelected("Run Click ITC", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Right");
            Delay.Milliseconds(0);
            
            TapOnMonauralHearingSystem();
            Delay.Milliseconds(0);
            
            TapOn("Fit left ear with hearing aid");
            Delay.Milliseconds(0);
            
            TapOnObject("Run Click ITC");
            Delay.Milliseconds(0);
            
            TapOnCoupling("Click Sleeve");
            Delay.Milliseconds(0);
            
            ValidateMonauralHISelected("Run Click ITC", "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Left");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
