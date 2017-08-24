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
    ///The EditingExistingCustomer recording.
    /// </summary>
    [TestModule("9363f5a4-28bc-4281-992e-65e6501f881a", ModuleType.Recording, 1)]
    public partial class EditingExistingCustomer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static EditingExistingCustomer instance = new EditingExistingCustomer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditingExistingCustomer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditingExistingCustomer Instance
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

            // Step## Pre-Condition - Initial setup done.Disable Omniture Settings as soon as possible, if not done already in the previous test cases.At least one customer is created with audiogram configured, dob and notes duly filled.
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-Condition - Initial setup done.Disable Omniture Settings as soon as possible, if not done already in the previous test cases.At least one customer is created with audiogram configured, dob and notes duly filled.", new RecordItemIndex(0));
            
            CreatePatient("Customer", "Edit", "Jul_09_1955");
            Delay.Milliseconds(0);
            
            EditNotes("ABCXYZ");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            StartApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app and select list segmented control
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app and select list segmented control", new RecordItemIndex(6));
            
            ValidateCustomerScreen();
            Delay.Milliseconds(0);
            
            // Step## Selected the existing customer with audiogram configured from the list
            Report.Log(ReportLevel.Info, "Section", "Step## Selected the existing customer with audiogram configured from the list", new RecordItemIndex(8));
            
            SearchCustomer("Edit");
            Delay.Milliseconds(0);
            
            SelectCustomer("Customer", "Edit");
            Delay.Milliseconds(0);
            
            // Step## Tap on the edit icon
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the edit icon", new RecordItemIndex(11));
            
            TapOnRightButton("Tap on the edit icon");
            Delay.Milliseconds(0);
            
            // Validation## Customer form is opened with first , last name and dob fields, existing audiogram and notes editable and option to delete the client
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer form is opened with first , last name and dob fields, existing audiogram and notes editable and option to delete the client", new RecordItemIndex(13));
            
            ValidatePatientExist("Customer", "Edit");
            Delay.Milliseconds(0);
            
            ValidateDateEmpty(ValueConverter.ArgumentFromString<bool>("empty", "False"));
            Delay.Milliseconds(0);
            
            ValidateNotes("ABCXYZ");
            Delay.Milliseconds(0);
            
            ValidateDeleteClientOption();
            Delay.Milliseconds(0);
            
            // Step## Add additional notes and continue
            Report.Log(ReportLevel.Info, "Section", "Step## Add additional notes and continue", new RecordItemIndex(18));
            
            EditNotes("ABCXYZ MNOPQR");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Validation## Returns to overview screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to overview screen", new RecordItemIndex(21));
            
            VerifyActionBarTitle("Customer, Edit");
            Delay.Milliseconds(0);
            
            // Step## Tap on the edit icon
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the edit icon", new RecordItemIndex(23));
            
            TapOnRightButton("Tap on the edit icon");
            Delay.Milliseconds(0);
            
            // Step## Edit the first name and last name - Hit Continue/Done
            Report.Log(ReportLevel.Info, "Section", "Step## Edit the first name and last name - Hit Continue/Done", new RecordItemIndex(25));
            
            EditPatient("Edit", "Customer");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Done customer editing");
            Delay.Milliseconds(0);
            
            // Validation## Returns to overview screen with updated name at the top in the navigation bar.
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to overview screen with updated name at the top in the navigation bar.", new RecordItemIndex(28));
            
            VerifyActionBarTitle("Edit, Customer");
            Delay.Milliseconds(0);
            
            // Step## Tap on the edit icon
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the edit icon", new RecordItemIndex(30));
            
            TapOnRightButton("Tap on the edit icon");
            Delay.Milliseconds(0);
            
            // Validation## Customer edit screen is displayed.
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer edit screen is displayed.", new RecordItemIndex(32));
            
            VerifyActionBarTitle("Client");
            Delay.Milliseconds(0);
            
            // ##Step Select the dob field and tap on Clear on the data picker
            Report.Log(ReportLevel.Info, "Section", "##Step Select the dob field and tap on Clear on the data picker", new RecordItemIndex(34));
            
            ClearDateField();
            Delay.Milliseconds(0);
            
            // Validation## The picker is dismissed and existing date is cleared
            Report.Log(ReportLevel.Info, "Section", "Validation## The picker is dismissed and existing date is cleared", new RecordItemIndex(36));
            
            ValidateDateEmpty(ValueConverter.ArgumentFromString<bool>("empty", "True"));
            Delay.Milliseconds(0);
            
            // Step## Hit Continue/Done
            Report.Log(ReportLevel.Info, "Section", "Step## Hit Continue/Done", new RecordItemIndex(38));
            
            TapOnRightButton("Done customer editing");
            Delay.Milliseconds(0);
            
            // Validation## Returns to overview screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to overview screen", new RecordItemIndex(40));
            
            VerifyActionBarTitle("Edit, Customer");
            Delay.Milliseconds(0);
            
            // Step## Tap on the edit icon
            Report.Log(ReportLevel.Info, "Section", "Step## Tap on the edit icon", new RecordItemIndex(42));
            
            TapOnRightButton("Tap on the edit icon");
            Delay.Milliseconds(0);
            
            // Validation## Verify that the changes made are still there.
            Report.Log(ReportLevel.Info, "Section", "Validation## Verify that the changes made are still there.", new RecordItemIndex(44));
            
            ValidatePatientExist("Edit", "Customer");
            Delay.Milliseconds(0);
            
            ValidateDateEmpty(ValueConverter.ArgumentFromString<bool>("empty", "True"));
            Delay.Milliseconds(0);
            
            ValidateNotes("ABCXYZ MNOPQR");
            Delay.Milliseconds(0);
            
            ValidateDeleteClientOption();
            Delay.Milliseconds(0);
            
            // Step## Edit the Existing audiogram toggle from ON to OFF
            Report.Log(ReportLevel.Info, "Section", "Step## Edit the Existing audiogram toggle from ON to OFF", new RecordItemIndex(49));
            
            SwitchAudiogramAvailableinEditScreen(ValueConverter.ArgumentFromString<bool>("on", "False"), ValueConverter.ArgumentFromString<bool>("alert", "True"));
            Delay.Milliseconds(0);
            
            // Validation## Toggle button is set to off for audiogram
            Report.Log(ReportLevel.Info, "Section", "Validation## Toggle button is set to off for audiogram", new RecordItemIndex(51));
            
            ValidateAudiogramToggle(ValueConverter.ArgumentFromString<bool>("toggle", "False"));
            Delay.Milliseconds(0);
            
            // Step## Select Continue
            Report.Log(ReportLevel.Info, "Section", "Step## Select Continue", new RecordItemIndex(53));
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            // Validation## The overview screen shows up with the Puretone Workflow
            Report.Log(ReportLevel.Info, "Section", "Validation## The overview screen shows up with the Puretone Workflow", new RecordItemIndex(55));
            
            ValidateContents("Select Hearing Aid;Pure Tone Estimation;Select Sound Profile;Fit Coupling;Assemble Hearing Aid;Send Data to Hearing Aid;Check Sound Comfort");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
