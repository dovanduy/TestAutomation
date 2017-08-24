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
    ///The EditingAudiogram recording.
    /// </summary>
    [TestModule("35c6463e-e426-4938-b091-d57d991c7990", ModuleType.Recording, 1)]
    public partial class EditingAudiogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static EditingAudiogram instance = new EditingAudiogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditingAudiogram()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditingAudiogram Instance
        {
            get { return instance; }
        }

#region Variables

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

            // Step## Pre-condition - Initial setup and Access code setup is done.
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-condition - Initial setup and Access code setup is done.", new RecordItemIndex(0));
            
            // Step## Open the App and go to New
            Report.Log(ReportLevel.Info, "Section", "Step## Open the App and go to New", new RecordItemIndex(1));
            
            TapOn("new");
            Delay.Milliseconds(0);
            
            // Validation##  Customer Creation screen is displayed with editable fields
            Report.Log(ReportLevel.Info, "Section", "Validation##  Customer Creation screen is displayed with editable fields", new RecordItemIndex(3));
            
            ValidateCustomerEditableFields();
            Delay.Milliseconds(0);
            
            // Step## Enter details of Customer with Audiogram configuration enabled and Click Continue
            Report.Log(ReportLevel.Info, "Section", "Step## Enter details of Customer with Audiogram configuration enabled and Click Continue", new RecordItemIndex(5));
            
            CreatePatient("Audiogram", "Editing");
            Delay.Milliseconds(0);
            
            SwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "True"));
            Delay.Milliseconds(0);
            
            VerifySwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "True"));
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Validation## Overview Screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview Screen is displayed", new RecordItemIndex(10));
            
            VerifyActionBarTitle("Audiogram, Editing");
            Delay.Milliseconds(0);
            
            // Step##  Enter Audiogram points for both right and left side and press done
            Report.Log(ReportLevel.Info, "Section", "Step##  Enter Audiogram points for both right and left side and press done", new RecordItemIndex(12));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,40;1000,45;2000,50;4000,55");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "500,40;1000,45;2000,50;4000,55");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Overview screen with both audiogram is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen with both audiogram is displayed", new RecordItemIndex(17));
            
            VerifyActionBarTitle("Audiogram, Editing");
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Right", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Left", "500,40;1000,45;2000,50;4000,55", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
            // Step## Click on the right audiogram in overview screen and Tap on the edit button on the right corner
            Report.Log(ReportLevel.Info, "Section", "Step## Click on the right audiogram in overview screen and Tap on the edit button on the right corner", new RecordItemIndex(21));
            
            TapOnOverviewScreen("Right");
            Delay.Milliseconds(0);
            
            // Validation## Audiogram summary screen(read only) is opened. Points plotted are shown in both graphical and numeric form.
            Report.Log(ReportLevel.Info, "Section", "Validation## Audiogram summary screen(read only) is opened. Points plotted are shown in both graphical and numeric form.", new RecordItemIndex(23));
            
            VerifyActionBarTitle("Audiogram");
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnOverviewScreen("Right", "500,40;1000,45;2000,50;4000,55");
            Delay.Milliseconds(0);
            
            // Step## Tap on the edit button on the right corner
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the edit button on the right corner", new RecordItemIndex(26));
            
            // Step## Re-adjust values of any two points(say 50@500Hz and 50@1kHz) and add points to 250Hz, 8kHz to both audiograms- press Done button.
            Report.Log(ReportLevel.Info, "Section", "Step## Re-adjust values of any two points(say 50@500Hz and 50@1kHz) and add points to 250Hz, 8kHz to both audiograms- press Done button.", new RecordItemIndex(27));
            
            TapOnRightButton("Tap on \"Edit\"");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,50;1000,50");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "250,50;8000,50");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on \"Done\"");
            Delay.Milliseconds(0);
            
            // Validation## Updated Audiogram is saved and shown on the overview screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Updated Audiogram is saved and shown on the overview screen", new RecordItemIndex(32));
            
            VerifyActionBarTitle("Audiogram, Editing");
            Delay.Milliseconds(0);
            
            ValidateAudiogramPointsOnCustomerOverviewScreen("Right", "250,50;500,50;1000,50;2000,50;4000,55;8000,50", ValueConverter.ArgumentFromString<bool>("isExist", "True"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
