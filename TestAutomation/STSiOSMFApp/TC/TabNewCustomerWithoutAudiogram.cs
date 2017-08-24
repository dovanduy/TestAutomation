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
    ///The TabNewCustomerWithoutAudiogram recording.
    /// </summary>
    [TestModule("b17f855d-986d-46d3-8948-d08580d1287a", ModuleType.Recording, 1)]
    public partial class TabNewCustomerWithoutAudiogram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabNewCustomerWithoutAudiogram instance = new TabNewCustomerWithoutAudiogram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabNewCustomerWithoutAudiogram()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabNewCustomerWithoutAudiogram Instance
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

            // Step## Open the app
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app", new RecordItemIndex(0));
            
            // Validation## Customer screen is opened with new and list segmented control
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer screen is opened with new and list segmented control", new RecordItemIndex(1));
            
            TabVerifyNavBarTitle("Client List");
            Delay.Milliseconds(0);
            
            // ##Step Select New
            Report.Log(ReportLevel.Info, "Section", "##Step Select New", new RecordItemIndex(3));
            
            // ##Validation Customer form is opened with the following editable fields -First Name,Last Name,DOB (mm/dd/yyyy).Audiogram Available toggle switch (default - ON) with additional text.Notes section will expend on selection
            Report.Log(ReportLevel.Info, "Section", "##Validation Customer form is opened with the following editable fields -First Name,Last Name,DOB (mm/dd/yyyy).Audiogram Available toggle switch (default - ON) with additional text.Notes section will expend on selection", new RecordItemIndex(4));
            
            ValidateCustomerEditableFields();
            Delay.Milliseconds(0);
            
            VerifySwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "True"));
            Delay.Milliseconds(0);
            
            // Step## Enter details - last name,first name, dob (optional), audiogram Available OFF, Notes section (optional)
            Report.Log(ReportLevel.Info, "Section", "Step## Enter details - last name,first name, dob (optional), audiogram Available OFF, Notes section (optional)", new RecordItemIndex(7));
            
            CreatePatient("Audiogram", "Without");
            Delay.Milliseconds(0);
            
            SwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "False"));
            Delay.Milliseconds(0);
            
            VerifySwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "False"));
            Delay.Milliseconds(0);
            
            // Step## Hit Continue
            Report.Log(ReportLevel.Info, "Section", "Step## Hit Continue", new RecordItemIndex(11));
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Validation## Overview screen is displayed with the customer name on the top and the following workflow items-Select HI,Pure Tone Estimation,Select Sound Profile,Fit Coupling (info),Assemble HI (info),Send data to Hearing Aid,Check Sound Comfort
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen is displayed with the customer name on the top and the following workflow items-Select HI,Pure Tone Estimation,Select Sound Profile,Fit Coupling (info),Assemble HI (info),Send data to Hearing Aid,Check Sound Comfort", new RecordItemIndex(13));
            
            TabVerifyNavBarFititngTitle("Audiogram, Without");
            Delay.Milliseconds(0);
            
            ValidateContents("Pure Tone Estimation;Select Hearing Aid;Select Sound Profile;Fit Coupling;Assemble Hearing Aid;Send Data to Hearing Aid;Check Sound Comfort");
            Delay.Milliseconds(0);
            
            ValidateWorkflowEnabled("Select Hearing Aid", ValueConverter.ArgumentFromString<bool>("isEnabled", "True"));
            Delay.Milliseconds(0);
            
            // ##Step Tap back from the overview screen
            Report.Log(ReportLevel.Info, "Section", "##Step Tap back from the overview screen", new RecordItemIndex(17));
            
            TapOnLeftButton("Press the back key");
            Delay.Milliseconds(0);
            
            // ##Validation Customer management screen is displayed with List screen with the created customer in the list.
            Report.Log(ReportLevel.Info, "Section", "##Validation Customer management screen is displayed with List screen with the created customer in the list.", new RecordItemIndex(19));
            
            TabVerifyNavBarTitle("Client List");
            Delay.Milliseconds(0);
            
            // ##Step Select the created customer and tap on the edit icon
            Report.Log(ReportLevel.Info, "Section", "##Step Select the created customer and tap on the edit icon", new RecordItemIndex(21));
            
            SearchCustomer("Without");
            Delay.Milliseconds(0);
            
            SelectCustomer("Audiogram", "Without");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on the edit icon");
            Delay.Milliseconds(0);
            
            // ##Validation Ensure that all the data displayed is same as the data entered during creation
            Report.Log(ReportLevel.Info, "Section", "##Validation Ensure that all the data displayed is same as the data entered during creation", new RecordItemIndex(25));
            
            VerifySwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "False"));
            Delay.Milliseconds(0);
            
            ValidateFirstName("Without");
            Delay.Milliseconds(0);
            
            ValidateLastName("Audiogram");
            Delay.Milliseconds(0);
            
            ValidateCustomerEditableFields();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
