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

namespace STSiOSMFApp.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RecommendationForDeviceSelection recording.
    /// </summary>
    [TestModule("966ae377-979c-45cd-a008-d228ad6eb3c1", ModuleType.Recording, 1)]
    public partial class RecommendationForDeviceSelection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static RecommendationForDeviceSelection instance = new RecommendationForDeviceSelection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecommendationForDeviceSelection()
        {
            LastName = "RunP";
            FirstName = "WithAudi";
            AUPoints = "500,40;1000,45;2000,50;4000,60";
            HIName = "Run P";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecommendationForDeviceSelection Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("0624e26c-24e8-469a-9a31-4efc0044385b")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("cee88636-374c-4054-b8c3-5e58f68c0c0d")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _AUPoints;

        /// <summary>
        /// Gets or sets the value of variable AUPoints.
        /// </summary>
        [TestVariable("cfe23311-974f-4cde-a966-15674f398742")]
        public string AUPoints
        {
            get { return _AUPoints; }
            set { _AUPoints = value; }
        }

        string _HIName;

        /// <summary>
        /// Gets or sets the value of variable HIName.
        /// </summary>
        [TestVariable("96d69a81-f27b-4b37-90e9-4d84982c8cf6")]
        public string HIName
        {
            get { return _HIName; }
            set { _HIName = value; }
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

            // Step## Customer created with audiogram configured. Custom molds is enabled.
            //Report.Log(ReportLevel.Info, "Section", "Step## Customer created with audiogram configured. Custom molds is enabled.", new RecordItemIndex(0));
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            TapOnLeftButton("Press the Back key");
            Delay.Milliseconds(0);
            
            CreatePatient(LastName, FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List. Select the existing customer
            //Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List. Select the existing customer", new RecordItemIndex(7));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer(FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomer(LastName, FirstName);
            Delay.Milliseconds(0);
            
            // Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done", new RecordItemIndex(11));
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", AUPoints);
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Audiogram is saved - Recommendation should be @HI
            Report.Log(ReportLevel.Info, "Section", "Validation## Audiogram is saved - Recommendation should be @HI", new RecordItemIndex(17));
            
            ValidateMonauralHISelected(HIName, "Right");
            Delay.Milliseconds(0);
            
            TapOnLeftButton("Press the \"Back Key\" ");
            Delay.Milliseconds(0);
            
            // Validation## Returns to Customer list screen
            //Report.Log(ReportLevel.Info, "Section", "Validation## Returns to Customer list screen", new RecordItemIndex(20));
            
            VerifyActionBarTitle("Client");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
