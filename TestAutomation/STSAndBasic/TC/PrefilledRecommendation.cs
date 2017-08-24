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
    ///The PrefilledRecommendation recording.
    /// </summary>
    [TestModule("bfbd4973-3e9f-468a-94ea-aeee70127925", ModuleType.Recording, 1)]
    public partial class PreFilledRecommendation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static PreFilledRecommendation instance = new PreFilledRecommendation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PreFilledRecommendation()
        {
            H1 = "";
            H2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PreFilledRecommendation Instance
        {
            get { return instance; }
        }

#region Variables

        string _H1;

        /// <summary>
        /// Gets or sets the value of variable H1.
        /// </summary>
        [TestVariable("4b6c048c-98e8-423c-b075-969be2903700")]
        public string H1
        {
            get { return _H1; }
            set { _H1 = value; }
        }

        string _H2;

        /// <summary>
        /// Gets or sets the value of variable H2.
        /// </summary>
        [TestVariable("024c24bb-e25a-4b0e-b447-6d2515b2126e")]
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

            // Step##  Custom ear molds is set On and Customer created with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step##  Custom ear molds is set On and Customer created with audiogram configured", new RecordItemIndex(0));
            
            TapOnRightButton("Tap on \"Settings\"");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            CreatePatient("PreFilled", "Recomm", "Jul_29_1955");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // --Step## Open the app, goto List. Select the existing customer
            Report.Log(ReportLevel.Info, "Section", "--Step## Open the app, goto List. Select the existing customer", new RecordItemIndex(7));
            
            StartApp();
            Delay.Milliseconds(0);
            
            ValidateCustomerScreen();
            Delay.Milliseconds(0);
            
            SearchCustomer("Recomm");
            Delay.Milliseconds(0);
            
            SelectCustomer("PreFilled", "Recomm");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram -Right with 50, 65 ,75 80 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram -Right with 50, 65 ,75 80 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done", new RecordItemIndex(12));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,50;1000,65;2000,75;4000,80");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Step## Pop-up appears to enter value for left ear
            Report.Log(ReportLevel.Info, "Section", "Step## Pop-up appears to enter value for left ear", new RecordItemIndex(16));
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            // Step## Press NO for the pop-up appeared
            Report.Log(ReportLevel.Info, "Section", "Step## Press NO for the pop-up appeared", new RecordItemIndex(18));
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Returns to the overview screen with HIType,Coupling and Cluster pre-filled and Recommended
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the overview screen with HIType,Coupling and Cluster pre-filled and Recommended", new RecordItemIndex(20));
            
            ValidateMonauralHISelected(H1, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Tip", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Right");
            Delay.Milliseconds(0);
            
            // Validation ## Tap on "Send Data to hearing Aid"
            Report.Log(ReportLevel.Info, "Section", "Validation ## Tap on \"Send Data to hearing Aid\"", new RecordItemIndex(24));
            
            ValidateWorkflowEnabled("Send Data to Hearing Aid", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect-Pair HI
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect-Pair HI", new RecordItemIndex(26));
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output.
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output.", new RecordItemIndex(27));
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            ValidateALertMessage(" Selected Sound Profile has high amplification output.");
            Delay.Milliseconds(0);
            
            // step## Press Cancel in popup appeared.
            Report.Log(ReportLevel.Info, "Section", "step## Press Cancel in popup appeared.", new RecordItemIndex(30));
            
            ClickOnAlertMessage("Cancel");
            Delay.Milliseconds(0);
            
            // Step## Tap on the HI tab and check for the pre-selected
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the HI tab and check for the pre-selected", new RecordItemIndex(32));
            
            // Validation## Right ear is the selected ear side,  Run P is selected as HI and  Tip is selected as coupling
            Report.Log(ReportLevel.Info, "Section", "Validation## Right ear is the selected ear side,  Run P is selected as HI and  Tip is selected as coupling", new RecordItemIndex(33));
            
            ValidateMonauralHISelected(H1, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Tip", "Right");
            Delay.Milliseconds(0);
            
            TapOn(H1);
            Delay.Milliseconds(0);
            
            ValidateRecommendationEnabled("Right", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            // Step## Edit Audiogram - Right with 80, 80 ,80, 80 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Edit Audiogram - Right with 80, 80 ,80, 80 dB for the required frequencies 500Hz, 1kHz, 2kHz, 4kHz and press Done", new RecordItemIndex(38));
            
            BackAction();
            Delay.Milliseconds(0);
            
            EditAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,80;1000,80;2000,80;4000,80");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation##The app recalculates and recommends Run SP, Custom Molds & P3
            Report.Log(ReportLevel.Info, "Section", "Validation##The app recalculates and recommends Run SP, Custom Molds & P3", new RecordItemIndex(45));
            
            ValidateMonauralHISelected(H2, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Custom Mold", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Right");
            Delay.Milliseconds(0);
            
            // Step##Tap on the HI tab and select HI different from that reccommended(RunP) and Select Tip
            Report.Log(ReportLevel.Info, "Section", "Step##Tap on the HI tab and select HI different from that reccommended(RunP) and Select Tip", new RecordItemIndex(49));
            
            TapOn(H2);
            Delay.Milliseconds(0);
            
            ValidateRecommendationEnabled("Right", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            TapOnWithContentDesc(H1);
            Delay.Milliseconds(0);
            
            TapOn("Tip");
            Delay.Milliseconds(0);
            
            // Validation##Cluster P5 has been calculated
            Report.Log(ReportLevel.Info, "Section", "Validation##Cluster P5 has been calculated", new RecordItemIndex(55));
            
            ValidateMonauralHISelected(H1, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Tip", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P5", "Right");
            Delay.Milliseconds(0);
            
            // Step## Press Send Data to Hearing Aid and Pairs the HI's
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send Data to Hearing Aid and Pairs the HI's", new RecordItemIndex(59));
            
            // Validate## following Message- Selected sound profile has high amplification output
            Report.Log(ReportLevel.Info, "Section", "Validate## following Message- Selected sound profile has high amplification output", new RecordItemIndex(60));
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("• Selected Sound Profile has high amplification output.");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            try {
                ConnectHI();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(64)); }
            
            ConfirmationToneYes();
            Delay.Milliseconds(0);
            
            // Step## Press Sound Comfort to adjust sound and Volume
            Report.Log(ReportLevel.Info, "Section", "Step## Press Sound Comfort to adjust sound and Volume", new RecordItemIndex(66));
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            // Validation##Sliders are adjusted Accordingly
            Report.Log(ReportLevel.Info, "Section", "Validation##Sliders are adjusted Accordingly", new RecordItemIndex(68));
            
            VolumeIncrease();
            Delay.Milliseconds(0);
            
            SoundSharper();
            Delay.Milliseconds(0);
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            // Step## Close Session
            Report.Log(ReportLevel.Info, "Section", "Step## Close Session", new RecordItemIndex(72));
            
            // Validation## Customer list screen appears
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer list screen appears", new RecordItemIndex(73));
            
            CloseSession();
            Delay.Milliseconds(0);
            
            VerifyActionBarTitle("Client");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
