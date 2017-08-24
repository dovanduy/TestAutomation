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
    ///The TabDeletingCustomer recording.
    /// </summary>
    [TestModule("83a15a31-7361-44fc-ad6f-49d4fc169e54", ModuleType.Recording, 1)]
    public partial class TabDeletingCustomer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSiOSMFApp.STSiOSMFAppRepository repository.
        /// </summary>
        public static STSiOSMFApp.STSiOSMFAppRepository repo = STSiOSMFApp.STSiOSMFAppRepository.Instance;

        static TabDeletingCustomer instance = new TabDeletingCustomer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabDeletingCustomer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabDeletingCustomer Instance
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

            // Step## Create the patient
            Report.Log(ReportLevel.Info, "Section", "Step## Create the patient", new RecordItemIndex(0));
            
            CreatePatient("Customer", "Delete");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            TapOnLeftButton("Press the back key");
            Delay.Milliseconds(0);
            
            // Step## Open the app and select list in the Customer screen
            //Report.Log(ReportLevel.Info, "Section", "Step## Open the app and select list in the Customer screen", new RecordItemIndex(4));
            
            SearchCustomer("Delete");
            Delay.Milliseconds(0);
            
            // Step## Select any of the existing customer
            Report.Log(ReportLevel.Info, "Section", "Step## Select any of the existing customer", new RecordItemIndex(6));
            
            SelectCustomer("Customer", "Delete");
            Delay.Milliseconds(0);
            
            // Step## Press the edit icon
            Report.Log(ReportLevel.Info, "Section", "Step## Press the edit icon", new RecordItemIndex(8));
            
            TapOnRightButton("Tap the edit icon");
            Delay.Milliseconds(0);
            
            // Validation## Customer form is opened with first name, last name and dob fields, existing audiogram and notes editable and option to delete the client
            Report.Log(ReportLevel.Info, "Section", "Validation## Customer form is opened with first name, last name and dob fields, existing audiogram and notes editable and option to delete the client", new RecordItemIndex(10));
            
            ValidateFirstName("Delete");
            Delay.Milliseconds(0);
            
            ValidateLastName("Customer");
            Delay.Milliseconds(0);
            
            VerifySwitchAudiogramAvailable(ValueConverter.ArgumentFromString<bool>("on", "True"));
            Delay.Milliseconds(0);
            
            ValidateCustomerEditableFields();
            Delay.Milliseconds(0);
            
            // Step## Press the Delete Client
            Report.Log(ReportLevel.Info, "Section", "Step## Press the Delete Client", new RecordItemIndex(15));
            
            DeleteClient();
            Delay.Milliseconds(0);
            
            // Validation## Returns to the Customer list screen with the respective customer deleted
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the Customer list screen with the respective customer deleted", new RecordItemIndex(17));
            
            SearchCustomer("Delete");
            Delay.Milliseconds(0);
            
            ValidateContentsContains("Customer, Delete", ValueConverter.ArgumentFromString<bool>("isFound", "False"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
