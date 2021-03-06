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
    ///The HighCluster recording.
    /// </summary>
    [TestModule("276b177b-2936-4ace-8e4d-ec8d384aeccd", ModuleType.Recording, 1)]
    public partial class HighCluster : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static HighCluster instance = new HighCluster();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HighCluster()
        {
            H2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HighCluster Instance
        {
            get { return instance; }
        }

#region Variables

        string _H2;

        /// <summary>
        /// Gets or sets the value of variable H2.
        /// </summary>
        [TestVariable("f4ae7354-62af-4d87-8945-34f1ca20aaae")]
        public string H2
        {
            get { return _H2; }
            set { _H2 = value; }
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

            // Step## Pre-condition: Initial setup is done. Customer configured with audiogram exists. Disable Custom molds
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-condition: Initial setup is done. Customer configured with audiogram exists. Disable Custom molds", new RecordItemIndex(0));
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            TapOnLeftButton("Press the Back key");
            Delay.Milliseconds(0);
            
            CreatePatient("Higher", "Cluster");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app and select the customer from the list
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app and select the customer from the list", new RecordItemIndex(7));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("Cluster");
            Delay.Milliseconds(0);
            
            SelectCustomer("Higher", "Cluster");
            Delay.Milliseconds(0);
            
            // Step## Enter audiogram - Right 80 dB, 80 dB, 80 dB, 80 dB for the required frequencies
            Report.Log(ReportLevel.Info, "Section", "Step## Enter audiogram - Right 80 dB, 80 dB, 80 dB, 80 dB for the required frequencies", new RecordItemIndex(11));
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,80;1000,80;2000,80;4000,80");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Step## Check for the HI recommended & Coupling recommended
            Report.Log(ReportLevel.Info, "Section", "Step## Check for the HI recommended & Coupling recommended", new RecordItemIndex(17));
            
            // Validation## Run SP  & Custom Mold & P3 cluster is recommended
            Report.Log(ReportLevel.Info, "Section", "Validation## Run SP  & Custom Mold & P3 cluster is recommended", new RecordItemIndex(18));
            
            ValidateMonauralHISelected(H2, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Custom Mold", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Right");
            Delay.Milliseconds(0);
            
            // Step## Reselect Cluster from P3 to P4
            Report.Log(ReportLevel.Info, "Section", "Step## Reselect Cluster from P3 to P4", new RecordItemIndex(22));
            
            // Validation## Reselection of higher cluster should be possible.
            Report.Log(ReportLevel.Info, "Section", "Validation## Reselection of higher cluster should be possible.", new RecordItemIndex(23));
            
            TapOnWithValue("P3");
            Delay.Milliseconds(0);
            
            TapOnWithValue("P4");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P4", "Right");
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect to HI
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect to HI", new RecordItemIndex(27));
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output.
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output.", new RecordItemIndex(28));
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Selected Sound Profile has high amplification output.");
            Delay.Milliseconds(0);
            
            // Step## Click on OK in the pop-up appeared
            Report.Log(ReportLevel.Info, "Section", "Step## Click on OK in the pop-up appeared", new RecordItemIndex(31));
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            // Validation## Navigate to Connect Screen, Tap on Connect HI and  HI connected successfully
            Report.Log(ReportLevel.Info, "Section", "Validation## Navigate to Connect Screen, Tap on Connect HI and  HI connected successfully", new RecordItemIndex(33));
            
            // Step## Tap on Yes
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on Yes", new RecordItemIndex(34));
            
            try {
                ConnectHI();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            //ConfirmationToneYes();
            //Delay.Milliseconds(0);
            
            // Step## Press Check Sound Comfort
            Report.Log(ReportLevel.Info, "Section", "Step## Press Check Sound Comfort", new RecordItemIndex(37));
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            // Validation## Sound coumfort page appeared
            Report.Log(ReportLevel.Info, "Section", "Validation## Sound coumfort page appeared", new RecordItemIndex(39));
            
            VerifyActionBarTitle("Sound Comfort");
            Delay.Milliseconds(0);
            
            // Step## Selet the Cluster higher than the current i.e P5
            Report.Log(ReportLevel.Info, "Section", "Step## Selet the Cluster higher than the current i.e P5", new RecordItemIndex(41));
            
            TapOnWithValue("P4");
            Delay.Milliseconds(0);
            
            TapOnWithValue("P5");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Selected Sound Profile provides higher amplification than the recommended Profile. Are you sure of your selection?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            //ValidateMonauralClusterSelected("P5", "Right");
            //Delay.Milliseconds(0);
            
            // Step##Press OK and Close Session
            Report.Log(ReportLevel.Info, "Section", "Step##Press OK and Close Session", new RecordItemIndex(47));
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            CloseSession();
            Delay.Milliseconds(0);
            
            // Validation## Back to Client page
            Report.Log(ReportLevel.Info, "Section", "Validation## Back to Client page", new RecordItemIndex(50));
            
            VerifyActionBarTitle("Client");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
