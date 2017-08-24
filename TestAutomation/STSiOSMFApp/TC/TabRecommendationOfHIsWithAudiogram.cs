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
    ///The TabRecommendationOfHIsWithAudiogram recording.
    /// </summary>
    [TestModule("2b14c141-aa74-4b64-b325-8aca9e022f11", ModuleType.Recording, 1)]
    public partial class TabRecommendationOfHIsWithAudiogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabRecommendationOfHIsWithAudiogram instance = new TabRecommendationOfHIsWithAudiogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabRecommendationOfHIsWithAudiogram()
        {
            LastName = "RunP";
            FirstName = "WithAudi";
            AUPoints = "500,40;1000,45;2000,50;4000,60";
            HIName = "Run P";
            isCouplingAvailable = "False";
            Coupling = "Tip";
            Cluster = "P1";
            isAlert = "True";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabRecommendationOfHIsWithAudiogram Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("1c0bc1ad-827f-4bb2-8f53-d30b44705ac9")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("ca5f5573-b868-41eb-9077-7ee26f756666")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _AUPoints;

        /// <summary>
        /// Gets or sets the value of variable AUPoints.
        /// </summary>
        [TestVariable("53ba58ca-33c7-413f-abcd-fb7feaa2a9dc")]
        public string AUPoints
        {
            get { return _AUPoints; }
            set { _AUPoints = value; }
        }

        string _HIName;

        /// <summary>
        /// Gets or sets the value of variable HIName.
        /// </summary>
        [TestVariable("501ece12-36ea-4fbe-abd9-06a9a992ae42")]
        public string HIName
        {
            get { return _HIName; }
            set { _HIName = value; }
        }

        string _isCouplingAvailable;

        /// <summary>
        /// Gets or sets the value of variable isCouplingAvailable.
        /// </summary>
        [TestVariable("27859f19-ec7a-4652-b761-8de8ad90f457")]
        public string isCouplingAvailable
        {
            get { return _isCouplingAvailable; }
            set { _isCouplingAvailable = value; }
        }

        string _Coupling;

        /// <summary>
        /// Gets or sets the value of variable Coupling.
        /// </summary>
        [TestVariable("08b103a3-9b87-4de3-8af9-d8882a8c6d98")]
        public string Coupling
        {
            get { return _Coupling; }
            set { _Coupling = value; }
        }

        string _Cluster;

        /// <summary>
        /// Gets or sets the value of variable Cluster.
        /// </summary>
        [TestVariable("d450eecd-38c3-4396-bf38-71e646fea932")]
        public string Cluster
        {
            get { return _Cluster; }
            set { _Cluster = value; }
        }

        string _isAlert;

        /// <summary>
        /// Gets or sets the value of variable isAlert.
        /// </summary>
        [TestVariable("3a5867f3-2e14-4f98-97b1-a4416b76e0c9")]
        public string isAlert
        {
            get { return _isAlert; }
            set { _isAlert = value; }
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

            // Step##  Pre-Condition - Initial setup and Access code setup is done. Customer created with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step##  Pre-Condition - Initial setup and Access code setup is done. Customer created with audiogram configured", new RecordItemIndex(0));
            
            TapOn("SettingsIcon");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "True"));
            Delay.Milliseconds(0);
            
            TapOn("ClientIcon");
            Delay.Milliseconds(0);
            
            CreatePatient(LastName, FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List. Select the existing customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List. Select the existing customer", new RecordItemIndex(7));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            Delay.Duration(2000, false);
            
            SelectCustomer(LastName, FirstName);
            Delay.Milliseconds(0);
            
            // Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter (Right), @500Hz, @1kHz, @2kHz, @4kHz.Press Done", new RecordItemIndex(12));
            
            TapOn("Enter Audiogram");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", AUPoints);
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Click on 'Done'");
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Do you want to enter values for the \"left\" ear side too?");
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("No");
            Delay.Milliseconds(0);
            
            // Validation## Audiogram is saved - Recommendation should be @HI , @coupling type & @Cluster
            Report.Log(ReportLevel.Info, "Section", "Validation## Audiogram is saved - Recommendation should be @HI , @coupling type & @Cluster", new RecordItemIndex(18));
            
            TapOnMonauralHI("Tap on MonauralHI");
            Delay.Milliseconds(0);
            
            TapOn("Fit right ear with hearing aid");
            Delay.Milliseconds(0);
            
            TapOnWithSwipe(HIName);
            Delay.Milliseconds(0);
            
            SelectCouplingIfAvailable(ValueConverter.ArgumentFromString<bool>("isCouplingAvailable", isCouplingAvailable), Coupling);
            Delay.Milliseconds(0);
            
            ValidateMonauralHISelected(HIName, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected(Coupling, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected(Cluster, "Right");
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect to HI
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect to HI", new RecordItemIndex(26));
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output.
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output.", new RecordItemIndex(27));
            
            TapOn("Send Data to Hearing Aid");
            Delay.Milliseconds(0);
            
            try {
                ConnectHI();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            ValidateALertMessage("Selected Sound Profile has high amplification output.", ValueConverter.ArgumentFromString<bool>("isAlert", isAlert));
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            ConfirmationToneYes();
            Delay.Milliseconds(0);
            
            // Step## Press Sound Comfort and Press OK
            Report.Log(ReportLevel.Info, "Section", "Step## Press Sound Comfort and Press OK", new RecordItemIndex(33));
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            // Step## Close session.
            Report.Log(ReportLevel.Info, "Section", "Step## Close session.", new RecordItemIndex(36));
            
            CloseSession();
            Delay.Milliseconds(0);
            
            SearchCustomer(FirstName);
            Delay.Milliseconds(0);
            
            SelectCustomer(LastName, FirstName);
            Delay.Milliseconds(0);
            
            // Step## Press audiogram tab and open the edit screen
            Report.Log(ReportLevel.Info, "Section", "Step## Press audiogram tab and open the edit screen", new RecordItemIndex(40));
            
            EditAudiogram();
            Delay.Milliseconds(0);
            
            // Step## Enter (Left), @500Hz, @1kHz, @2kHz, @4kHz.Press Done.
            Report.Log(ReportLevel.Info, "Section", "Step## Enter (Left), @500Hz, @1kHz, @2kHz, @4kHz.Press Done.", new RecordItemIndex(42));
            
            DrawAudiogramPoints("Left", AUPoints);
            Delay.Milliseconds(0);
            
            TabTapOnDetailNavBarRight("Click on 'Done'");
            Delay.Milliseconds(0);
            
            TapOnWithSwipe("Continue With Left Ear");
            Delay.Milliseconds(0);
            
            ValidateBinauralHISelected(HIName, "Right");
            Delay.Milliseconds(0);
            
            ValidateBinauralCouplingSelected(Coupling, "Right");
            Delay.Milliseconds(0);
            
            ValidateBinauralClusterSelected(Cluster, "Right");
            Delay.Milliseconds(0);
            
            TapOnBinauralHI("Tap On BinauralHI", "Left");
            Delay.Milliseconds(0);
            
            TapOnWithSwipe(HIName);
            Delay.Milliseconds(0);
            
            SelectCouplingIfAvailable(ValueConverter.ArgumentFromString<bool>("isCouplingAvailable", isCouplingAvailable), Coupling);
            Delay.Milliseconds(0);
            
            ValidateBinauralHISelected(HIName, "Left");
            Delay.Milliseconds(0);
            
            ValidateBinauralCouplingSelected(Coupling, "Left");
            Delay.Milliseconds(0);
            
            ValidateBinauralClusterSelected(Cluster, "Left");
            Delay.Milliseconds(0);
            
            // Step## Press Send data to HI and Connect to HI for Left side
            Report.Log(ReportLevel.Info, "Section", "Step## Press Send data to HI and Connect to HI for Left side", new RecordItemIndex(55));
            
            // Validation## warning message is displayed as Selected sound profile has high amplification output.
            Report.Log(ReportLevel.Info, "Section", "Validation## warning message is displayed as Selected sound profile has high amplification output.", new RecordItemIndex(56));
            
            SendDataToHearingAid("Left");
            Delay.Milliseconds(0);
            
            ConnectHI();
            Delay.Milliseconds(0);
            
            ValidateALertMessage("Selected Sound Profile has high amplification output.", ValueConverter.ArgumentFromString<bool>("isAlert", isAlert));
            Delay.Milliseconds(0);
            
            ClickOnAlertMessage("OK");
            Delay.Milliseconds(0);
            
            ConfirmationToneYes();
            Delay.Milliseconds(0);
            
            // Step## Press Sound Comfort and Press OK
            Report.Log(ReportLevel.Info, "Section", "Step## Press Sound Comfort and Press OK", new RecordItemIndex(62));
            
            TapOn("Check Sound Comfort");
            Delay.Milliseconds(0);
            
            SoundComfortOk();
            Delay.Milliseconds(0);
            
            // Step## Press Close session
            Report.Log(ReportLevel.Info, "Section", "Step## Press Close session", new RecordItemIndex(65));
            
            CloseSession();
            Delay.Milliseconds(0);
            
            // Validation## Returns to Customer list screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to Customer list screen", new RecordItemIndex(67));
            
            TabVerifyNavBarTitle("Client List");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
